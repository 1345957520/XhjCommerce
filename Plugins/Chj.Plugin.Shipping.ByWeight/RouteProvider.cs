﻿using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.Shipping.ByWeight
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Shipping.ByWeight.SaveGeneralSettings",
                 "Plugins/ShippingByWeight/SaveGeneralSettings",
                 new { controller = "ShippingByWeight", action = "SaveGeneralSettings", },
                 new[] { "Chj.Plugin.Shipping.ByWeight.Controllers" }
            );

            routes.MapRoute("Plugin.Shipping.ByWeight.AddPopup",
                 "Plugins/ShippingByWeight/AddPopup",
                 new { controller = "ShippingByWeight", action = "AddPopup" },
                 new[] { "Chj.Plugin.Shipping.ByWeight.Controllers" }
            );
            routes.MapRoute("Plugin.Shipping.ByWeight.EditPopup",
                 "Plugins/ShippingByWeight/EditPopup",
                 new { controller = "ShippingByWeight", action = "EditPopup" },
                 new[] { "Chj.Plugin.Shipping.ByWeight.Controllers" }
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
