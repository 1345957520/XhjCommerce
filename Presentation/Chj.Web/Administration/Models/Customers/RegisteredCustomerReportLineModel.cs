using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Customers
{
    public partial class RegisteredCustomerReportLineModel : BaseNopModel
    {
        [NopResourceDisplayName("Admin.Customers.Reports.RegisteredCustomers.Fields.Period")]
        public string Period { get; set; }

        [NopResourceDisplayName("Admin.Customers.Reports.RegisteredCustomers.Fields.Customers")]
        public int Customers { get; set; }
    }
}