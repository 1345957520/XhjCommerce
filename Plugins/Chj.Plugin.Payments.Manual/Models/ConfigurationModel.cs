﻿using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Payments.Manual.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Manual.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Manual.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        public int TransactModeId { get; set; }
        [NopResourceDisplayName("Plugins.Payments.Manual.Fields.TransactMode")]
        public SelectList TransactModeValues { get; set; }
        public bool TransactModeId_OverrideForStore { get; set; }
    }
}