using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{

  /// <summary>
  /// Layout üzerinde istedeğimiz kadar veri çekip layout'a ekleyeceğmiz bir backend dosyamız olur.
  /// </summary>
    public class LayoutController : Controller
    {
    // GET: Layout

    [ChildActionOnly]
        public PartialViewResult GetMenus()
        {
          var menus = new List<MenuModel>();
      menus.Add(new MenuModel { ControllerName = "Home", ActionName = "Index", Name = "Anasayfa" });

      menus.Add(new MenuModel { ControllerName = "Home", ActionName = "About", Name = "Hakkımızda" });

      menus.Add(new MenuModel { ControllerName = "Home", ActionName = "Privacy", Name = "Gizlilik" });

      menus.Add(new MenuModel { ControllerName = "Home", ActionName = "Contact", Name = "İletişim" });


          return PartialView("_menu",menus);
        }
    }
}