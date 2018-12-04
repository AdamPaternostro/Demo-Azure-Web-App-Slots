using System.Web;
using System.Web.Mvc;

namespace Demo_Azure_Web_App_Slots
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
