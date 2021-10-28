using System.Web;
using System.Web.Mvc;

namespace _6_DemoHtmlHelper
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
