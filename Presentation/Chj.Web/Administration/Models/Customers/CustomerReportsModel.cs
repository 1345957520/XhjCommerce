using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Customers
{
    public partial class CustomerReportsModel : BaseNopModel
    {
        public BestCustomersReportModel BestCustomersByOrderTotal { get; set; }
        public BestCustomersReportModel BestCustomersByNumberOfOrders { get; set; }
    }
}