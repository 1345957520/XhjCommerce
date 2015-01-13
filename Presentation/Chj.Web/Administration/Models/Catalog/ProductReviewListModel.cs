using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Catalog
{
    public partial class ProductReviewListModel : BaseNopModel
    {
        [NopResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [NopResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [NopResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchText")]
        [AllowHtml]
        public string SearchText { get; set; }
    }
}