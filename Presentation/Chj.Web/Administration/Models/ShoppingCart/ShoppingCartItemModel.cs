using System;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartItemModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }
        [NopResourceDisplayName("Admin.CurrentCarts.Product")]
        public int ProductId { get; set; }
        [NopResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductName { get; set; }

        [NopResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        [NopResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }
        [NopResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }
        [NopResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}