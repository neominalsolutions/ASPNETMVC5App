using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Attributes
{
  /// <summary>
  /// ActionFilterAttribute ile uygulama gelen istekleri filtreleyebiliriz.
  /// Bütün istekler eğer global bir tanım varsa buradan geçecek.
  /// </summary>
  public class IPControlAttribute:ActionFilterAttribute
  {
    /// <summary>
    /// Action girmeden önce çalışır
    /// </summary>
    /// <param name="filterContext"></param>
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      base.OnActionExecuting(filterContext);
    }

    /// <summary>
    /// Actiona girdikten sonra tetiklenir. actiondan çıktıktan sonra.
    /// </summary>
    /// <param name="filterContext"></param>
    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {
      base.OnActionExecuted(filterContext);
    }
  }
}