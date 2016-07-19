using DemoMVC_Autenticacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DemoMVC_Autenticacao.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login() {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(User user) {
            if (Membership.ValidateUser(user.UserName, user.Password))
                return RedirectToAction("Index", "Home");
            return View("Login");
        }

        public string ValidaUsuario(User user) {
            if (Membership.ValidateUser(user.UserName, user.Password))
                return "Usuário válido";
            return "Usuário e ou senha inválidos";
        }

    }
}
