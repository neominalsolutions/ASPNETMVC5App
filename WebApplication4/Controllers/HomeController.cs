using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Attributes;

namespace WebApplication4.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {

     

      return View();
    }

    /// <summary>
    /// Eğer kullanıcı oturum açmadıysa kullanıcıyı bu view'e yönlendirmiyor.
    /// </summary>
    /// <returns></returns>
    [Authorize(Roles = "Admin")] // sadece Admin rolünde ve kimlik doğrulanmış olan kişi bu view'e ulaşabilir.
    public ActionResult About()
    {

      ViewBag.Message = "Your application description page.";

      return View();
    }

    [IPControl] // AOP Aspect Oriented Programing, cross cutting işlemlerde loglama,validasyon kontrolü, session control, authentication control
    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    public ActionResult Privacy()
    {
      return View();
    }
  }
}