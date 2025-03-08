using System.Web;
using System.Web.Mvc;

namespace u24687473_INF272_Practical_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
