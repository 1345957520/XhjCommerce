﻿using System.Collections.Generic;
using System.Linq;
using Chj.Core.Caching;
using Chj.Core.Data;
using Chj.Core.Domain.Localization;
using Chj.Services.Configuration;
using Chj.Services.Events;
using Chj.Services.Localization;
using Chj.Services.Stores;
using Chj.Tests;
using NUnit.Framework;
using Rhino.Mocks;

namespace Chj.Services.Tests.Localization
{
    [TestFixture]
    public class LanguageServiceTests : ServiceTest
    {
        private IRepository<Language> _languageRepo;
        private IStoreMappingService _storeMappingService;
        private ILanguageService _languageService;
        private ISettingService _settingService;
        private IEventPublisher _eventPublisher;
        private LocalizationSettings _localizationSettings;

        [SetUp]
        public new void SetUp()
        {
            _languageRepo = MockRepository.GenerateMock<IRepository<Language>>();
            var lang1 = new Language
            {
                Name = "English",
                LanguageCulture = "en-Us",
                FlagImageFileName = "us.png",
                Published = true,
                DisplayOrder = 1
            };
            var lang2 = new Language
            {
                Name = "Russian",
                LanguageCulture = "ru-Ru",
                FlagImageFileName = "ru.png",
                Published = true,
                DisplayOrder = 2
            };

            _languageRepo.Expect(x => x.Table).Return(new List<Language> { lang1, lang2 }.AsQueryable());

            _storeMappingService = MockRepository.GenerateMock<IStoreMappingService>();

            var cacheManager = new NopNullCache();

            _settingService = MockRepository.GenerateMock<ISettingService>();

            _eventPublisher = MockRepository.GenerateMock<IEventPublisher>();
            _eventPublisher.Expect(x => x.Publish(Arg<object>.Is.Anything));

            _localizationSettings = new LocalizationSettings();
            _languageService = new LanguageService(cacheManager, _languageRepo, _storeMappingService,
                _settingService, _localizationSettings, _eventPublisher);
        }

        [Test]
        public void Can_get_all_languages()
        {
            var languages = _languageService.GetAllLanguages();
            languages.ShouldNotBeNull();
            (languages.Count > 0).ShouldBeTrue();
        }
    }
}
