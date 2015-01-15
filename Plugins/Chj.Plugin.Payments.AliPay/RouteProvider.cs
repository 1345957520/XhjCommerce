﻿using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.Payments.AliPay
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //Notify
            routes.MapRoute("Plugin.Payments.AliPay.Notify",
                 "Plugins/PaymentAliPay/Notify",
                 new { controller = "PaymentAliPay", action = "Notify" },
                 new[] { "Chj.Plugin.Payments.AliPay.Controllers" }
            );

            //Notify
            routes.MapRoute("Plugin.Payments.AliPay.Return",
                 "Plugins/PaymentAliPay/Return",
                 new { controller = "PaymentAliPay", action = "Return" },
                 new[] { "Chj.Plugin.Payments.AliPay.Controllers" }
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
