using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Chj.Admin.Validators.Common;
using Chj.Web.Framework;
using Chj.Web.Framework.Localization;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Common
{
    [Validator(typeof(AddressAttributeValueValidator))]
    public partial class AddressAttributeValueModel : BaseNopEntityModel, ILocalizedModel<AddressAttributeValueLocalizedModel>
    {
        public AddressAttributeValueModel()
        {
            Locales = new List<AddressAttributeValueLocalizedModel>();
        }

        public int AddressAttributeId { get; set; }

        [NopResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [NopResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<AddressAttributeValueLocalizedModel> Locales { get; set; }

    }

    public partial class AddressAttributeValueLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }
    }
}