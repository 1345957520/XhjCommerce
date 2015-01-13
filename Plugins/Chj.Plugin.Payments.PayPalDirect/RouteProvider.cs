using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.Payments.PayPalDirect
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //IPN
            routes.MapRoute("Plugin.Payments.PayPalDirect.IPNHandler",
                 "Plugins/PaymentPayPalDirect/IPNHandler",
                 new { controller = "PaymentPayPalDirect", action = "IPNHandler" },
                 new[] { "Chj.Plugin.Payments.PayPalDirect.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
