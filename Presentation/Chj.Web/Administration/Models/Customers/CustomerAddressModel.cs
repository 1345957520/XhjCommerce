using Chj.Admin.Models.Common;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseNopModel
    {
        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}