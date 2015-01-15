using Chj.Core.Configuration;

namespace Chj.Plugin.Payments.AliPay
{
    public class AliPayPaymentSettings : ISettings
    {
        public string SellerEmail { get; set; }
        public string Key { get; set; }
        public string Partner { get; set; }
        public decimal AdditionalFee { get; set; }
    }
}
