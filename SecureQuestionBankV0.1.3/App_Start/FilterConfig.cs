using System.Web;
using System.Web.Mvc;

namespace SecureQuestionBankV0._1._3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
