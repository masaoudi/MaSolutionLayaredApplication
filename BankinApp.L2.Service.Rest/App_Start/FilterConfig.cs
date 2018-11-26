using System.Web;
using System.Web.Mvc;

namespace BankinApp.L2.Service.Rest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
