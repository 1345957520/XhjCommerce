using FluentValidation;
using Chj.Admin.Models.Directory;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Directory
{
    public class MeasureDimensionValidator : BaseNopValidator<MeasureDimensionModel>
    {
        public MeasureDimensionValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Dimensions.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Dimensions.Fields.SystemKeyword.Required"));
        }
    }
}