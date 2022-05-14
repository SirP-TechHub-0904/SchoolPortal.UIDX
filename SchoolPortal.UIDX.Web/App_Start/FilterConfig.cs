using System.Web;
using System.Web.Mvc;

namespace SchoolPortal.UIDX.UIDX.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
