using System.Web;
using System.Web.Mvc;
using WebApplication4.Attributes;

namespace WebApplication4
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      //filters.Add(new HandleErrorAttribute());
      // uygulama genelinde her action buradaki tanımlayı uygulamak zorundadır.
      filters.Add(new IPControlAttribute());
    }
  }
}
