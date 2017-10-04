using System.Web;
using System.Web.Mvc;

namespace ValidateJS.Mvc.Demo.NetFx
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
