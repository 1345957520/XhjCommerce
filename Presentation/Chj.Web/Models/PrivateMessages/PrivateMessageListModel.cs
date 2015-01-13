using System.Collections.Generic;
using Chj.Web.Models.Common;

namespace Chj.Web.Models.PrivateMessages
{
    public partial class PrivateMessageListModel
    {
        public IList<PrivateMessageModel> Messages { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}