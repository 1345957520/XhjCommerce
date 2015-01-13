using System.Collections.Generic;
using Chj.Web.Framework.Mvc;

namespace Chj.Web.Models.Catalog
{
    public partial class CategoryNavigationModel : BaseNopModel
    {
        public CategoryNavigationModel()
        {
            Categories = new List<CategorySimpleModel>();
        }

        public int CurrentCategoryId { get; set; }
        public List<CategorySimpleModel> Categories { get; set; }
    }
}