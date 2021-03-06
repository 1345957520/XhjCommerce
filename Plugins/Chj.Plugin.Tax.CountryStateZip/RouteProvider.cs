﻿using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.Tax.CountryStateZip
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Tax.CountryStateZip.AddTaxRate",
                 "Plugins/TaxCountryStateZip/AddTaxRate",
                 new { controller = "TaxCountryStateZip", action = "AddTaxRate" },
                 new[] { "Chj.Plugin.Tax.CountryStateZip.Controllers" }
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
