using Chj.Core.Domain.Tax;
using Chj.Web.Framework.Mvc;

namespace Chj.Web.Models.Common
{
    public partial class TaxTypeSelectorModel : BaseNopModel
    {
        public TaxDisplayType CurrentTaxType { get; set; }
    }
}