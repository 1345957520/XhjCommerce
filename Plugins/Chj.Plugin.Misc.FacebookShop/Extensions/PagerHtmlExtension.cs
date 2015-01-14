using System.Web.Mvc;
using Chj.Web.Framework.UI.Paging;

namespace Chj.Plugin.Misc.FacebookShop.Extensions
{
    public static class PagerHtmlExtension
    {
        //jsut a copy of \Presentation\Chj.Web\Extensions\PagerHtmlExtension.cs
        public static Pager Pager(this HtmlHelper helper, IPageableModel pagination)
        {
            return new Pager(pagination, helper.ViewContext);
        }
    }
}
