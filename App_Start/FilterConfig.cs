using System.Web;
using System.Web.Mvc;

namespace st101030534_part2_CLDV7111
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
