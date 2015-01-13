using System.Collections.Generic;
using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Orders
{
    public partial class GiftCardListModel : BaseNopModel
    {
        public GiftCardListModel()
        {
            ActivatedList = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Admin.GiftCards.List.CouponCode")]
        [AllowHtml]
        public string CouponCode { get; set; }

        [NopResourceDisplayName("Admin.GiftCards.List.RecipientName")]
        [AllowHtml]
        public string RecipientName { get; set; }

        [NopResourceDisplayName("Admin.GiftCards.List.Activated")]
        public int ActivatedId { get; set; }

        [NopResourceDisplayName("Admin.GiftCards.List.Activated")]
        public IList<SelectListItem> ActivatedList { get; set; }
    }
}