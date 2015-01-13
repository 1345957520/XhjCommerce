using System.Collections.Generic;
using Chj.Web.Models.Common;

namespace Chj.Web.Models.Profile
{
    public partial class ProfilePostsModel
    {
        public IList<PostsModel> Posts { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}