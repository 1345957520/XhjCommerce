﻿using System.Web.Mvc;
using FluentValidation.Attributes;
using Chj.Admin.Models.Common;
using Chj.Admin.Validators.Shipping;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Shipping
{
    [Validator(typeof(WarehouseValidator))]
    public partial class WarehouseModel : BaseNopEntityModel
    {
        public WarehouseModel()
        {
            this.Address = new AddressModel();
        }

        [NopResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.AdminComment")]
        [AllowHtml]
        public string AdminComment { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Address")]
        public AddressModel Address { get; set; }
    }
}