using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication4
{
  public class MvcApplication : System.Web.HttpApplication
  {
    /// <summary>
    /// Uygulama ayağa kalkarken 1 kere buraya girer. down olana kadar girmez. application yeniden IIS üzerinden start olursa buraya tekrar düşer. 1.sıra
    /// </summary>
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    /// <summary>
    /// Yani yeni bir client tarayıcıdan sunucuya istek attığında burası tetiklenir.
    /// 3.sıra
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Session_Start(object sender, EventArgs e)
    {
      // your code here, it will be executed upon session start
    }

    /// <summary>
    /// Client browser üzerinden sunucu sayfasını kapadığında burası tetiklenir.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Session_End(object sender, EventArgs e)
    {
      // your code here, it will be executed upon session end
    }

    /// <summary>
    /// Uygulamaya gelen her istek önce buraya düşer.
    /// 2.sırada tetiklenir.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Application_BeginRequest(object sender, EventArgs e)
    {
      

    }


  }
}
