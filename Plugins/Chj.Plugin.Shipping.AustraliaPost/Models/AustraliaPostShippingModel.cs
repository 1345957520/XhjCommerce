using Chj.Web.Framework;

namespace Chj.Plugin.Shipping.AustraliaPost.Models
{
    public class AustraliaPostShippingModel
    {
        [NopResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.GatewayUrl")]
        public string GatewayUrl { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }
    }
}