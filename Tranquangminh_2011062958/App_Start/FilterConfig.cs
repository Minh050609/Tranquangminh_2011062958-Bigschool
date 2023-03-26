using System.Web;
using System.Web.Mvc;

namespace Tranquangminh_2011062958
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
