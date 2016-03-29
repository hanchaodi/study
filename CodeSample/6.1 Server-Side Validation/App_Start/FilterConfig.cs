using System.Web;
using System.Web.Mvc;

namespace _6._1_Server_Side_Validation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
