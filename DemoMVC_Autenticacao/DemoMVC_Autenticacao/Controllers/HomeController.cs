using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DemoMVC_Autenticacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult Detalhes() {
            return View();
        }

        //public ActionResult LoginTemporario() {
        //    FormsAuthentication.SetAuthCookie("Willian Barreto", false);
        //    return RedirectToAction("Index");
        //}
    }
}
