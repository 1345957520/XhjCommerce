
using Chj.Core.Configuration;

namespace Chj.Plugin.Shipping.AustraliaPost
{
    public class AustraliaPostSettings : ISettings
    {
        public string GatewayUrl { get; set; }

        public decimal AdditionalHandlingCharge { get; set; }
    }
}