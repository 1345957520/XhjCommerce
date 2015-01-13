using System.Collections.Generic;
using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Misc.FacebookShop.Models
{
    //just a simplified copy of \Chj.Web\Models\Catalog\SearchModel.cs
    public partial class SearchModel : BaseNopModel
    {
        public SearchModel()
        {
            PagingFilteringContext = new CatalogPagingFilteringModel();
            Products = new List<ProductOverviewModel>();
        }

        public string Warning { get; set; }

        public bool NoResults { get; set; }

        /// <summary>
        /// Query string
        /// </summary>
        [NopResourceDisplayName("Search.SearchTerm")]
        [AllowHtml]
        public string Q { get; set; }


        public CatalogPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<ProductOverviewModel> Products { get; set; }
    }
}