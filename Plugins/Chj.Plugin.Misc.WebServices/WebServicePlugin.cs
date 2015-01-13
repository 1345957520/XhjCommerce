﻿using System.Web.Routing;
using Chj.Core.Plugins;
using Chj.Plugin.Misc.WebServices.Security;
using Chj.Services.Common;
using Chj.Services.Localization;
using Chj.Services.Security;

namespace Chj.Plugin.Misc.WebServices
{
    public class WebServicePlugin : BasePlugin, IMiscPlugin
    {
        #region Fields

        private readonly IPermissionService _permissionService;

        #endregion

        #region Ctor

        public WebServicePlugin(IPermissionService permissionService)
        {
            this._permissionService = permissionService;
        }

        #endregion

        #region Methods

        public override void Install()
        {
            //install new permissions
            _permissionService.InstallPermissions(new WebServicePermissionProvider());

            //locales
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.WebServices.Description1", "Actually configuration is not required. Just some notes:");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.WebServices.Description2", "Ensure that permissions are properly configured on Access Control List page (disabled by default)");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.WebServices.Description3", "To access service use {0}");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.WebServices.Description4", "For mex endpoint use {0}");
            
            base.Install();
        }

        public override void Uninstall()
        {
            //uninstall permissions
            _permissionService.UninstallPermissions(new WebServicePermissionProvider());

            //locales
            this.DeletePluginLocaleResource("Plugins.Misc.WebServices.Description1");
            this.DeletePluginLocaleResource("Plugins.Misc.WebServices.Description2");
            this.DeletePluginLocaleResource("Plugins.Misc.WebServices.Description3");
            this.DeletePluginLocaleResource("Plugins.Misc.WebServices.Description4");
            
            base.Uninstall();
        }

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MiscWebServices";
            routeValues = new RouteValueDictionary { { "Namespaces", "Chj.Plugin.Misc.WebServices.Controllers.Controllers" }, { "area", null } };
        }

        #endregion
    }
}