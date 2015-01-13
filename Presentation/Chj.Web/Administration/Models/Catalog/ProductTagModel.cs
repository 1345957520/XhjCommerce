using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Chj.Admin.Validators.Catalog;
using Chj.Web.Framework;
using Chj.Web.Framework.Localization;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Catalog
{
    [Validator(typeof(ProductTagValidator))]
    public partial class ProductTagModel : BaseNopEntityModel, ILocalizedModel<ProductTagLocalizedModel>
    {
        public ProductTagModel()
        {
            Locales = new List<ProductTagLocalizedModel>();
        }
        [NopResourceDisplayName("Admin.Catalog.ProductTags.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.Catalog.ProductTags.Fields.ProductCount")]
        public int ProductCount { get; set; }

        public IList<ProductTagLocalizedModel> Locales { get; set; }
    }

    public partial class ProductTagLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.ProductTags.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }
    }
}