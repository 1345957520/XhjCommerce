﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Orders
{
    public partial class BestsellersReportModel : BaseNopModel
    {
        public BestsellersReportModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }


        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.OrderStatus")]
        public int OrderStatusId { get; set; }
        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.Category")]
        public int CategoryId { get; set; }
        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.Manufacturer")]
        public int ManufacturerId { get; set; }
        [NopResourceDisplayName("Admin.SalesReport.Bestsellers.BillingCountry")]
        public int BillingCountryId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        
        public bool IsLoggedInAsVendor { get; set; }
    }
}