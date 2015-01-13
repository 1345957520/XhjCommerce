﻿
using Chj.Core.Configuration;

namespace Chj.Core.Domain.Directory
{
    public class CurrencySettings : ISettings
    {
        public bool DisplayCurrencyLabel { get; set; }
        public int PrimaryStoreCurrencyId { get; set; }
        public int PrimaryExchangeRateCurrencyId { get; set; }
        public string ActiveExchangeRateProviderSystemName { get; set; }
        public bool AutoUpdateEnabled { get; set; }
        public long LastUpdateTime { get; set; }
    }
}