using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Filters
{
    public class DemoActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var msg = string.Format("Passou por aqui as {0}", DateTime.Now.ToLongTimeString());
            Debug.WriteLine(msg);
            base.OnActionExecuting(filterContext);
        }
    }
}