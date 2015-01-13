using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Chj.Admin.Validators.Shipping;
using Chj.Web.Framework;
using Chj.Web.Framework.Localization;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Shipping
{
    [Validator(typeof(DeliveryDateValidator))]
    public partial class DeliveryDateModel : BaseNopEntityModel, ILocalizedModel<DeliveryDateLocalizedModel>
    {
        public DeliveryDateModel()
        {
            Locales = new List<DeliveryDateLocalizedModel>();
        }
        [NopResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<DeliveryDateLocalizedModel> Locales { get; set; }
    }

    public partial class DeliveryDateLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

    }
}