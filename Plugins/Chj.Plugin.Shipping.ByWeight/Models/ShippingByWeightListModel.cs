using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Shipping.ByWeight.Models
{
    public class ShippingByWeightListModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugins.Shipping.ByWeight.Fields.LimitMethodsToCreated")]
        public bool LimitMethodsToCreated { get; set; }
        
    }
}