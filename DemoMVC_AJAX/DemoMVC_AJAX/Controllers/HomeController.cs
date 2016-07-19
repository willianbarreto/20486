using DemoMVC_AJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC_AJAX.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string nome)
        {
            if(MemoryCache.Default.Get("msg") == null)
                MemoryCache.Default.Add("msg", 
                    string.Format("Nome = {0}", nome??"sem nome"), 
                    DateTime.Now.AddMinutes(2));


            ViewBag.Mensagem = MemoryCache.Default.Get("msg").ToString();
            return View();
        }

        [OutputCache(Duration=0)]
        public PartialViewResult Mensagem() {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Thread.Sleep(5000);
            ViewBag.mensagem = string.Format("Esta é uma mensagem enviada as {0}", DateTime.Now.ToLongTimeString());
            return PartialView();
        }

        public string AutorizarUsuario(string nome, string senha)
        {
            if(nome == "willian" && senha == "1234")
                return "Você está autorizado";
            return "Você digitou um usuário e ou senha desconhecido.";
        }

        [OutputCache(Duration=40)]
        public ActionResult ServerTime(int id) {
            Thread.Sleep(5000);

            ViewBag.mensagem = string.Format("Horario do servidor {0} - id = {1}", DateTime.Now.ToLongTimeString(), id);
            return View();
        }

        public ActionResult RequisicoesAjax() {
            
            return View();
        }

        public string jqueryget() {
            return "Esta é uma mensagem assíncrona via JQueryGet";
        }

        public JsonResult Autenticacao(Usuario usuario) {
            if ((!string.IsNullOrEmpty(usuario.Nome)) && ((usuario.Nome == "Willian" && usuario.Senha == "123") || (usuario.Nome == "Edson" && usuario.Senha == "456")))
                return Json(new RetornoRequisicao {Sucesso=true, Mensagem="Usuário autenticado com sucesso." });
            return Json(new RetornoRequisicao {Sucesso=false, Mensagem="Usuário e ou senha incorretos." });
        }

        public string Inverter(string palavra) {
            var palavra2 = string.Join("", palavra.ToCharArray().Reverse());
            return string.Format("A palavra {0} invertida é {1}", palavra, palavra2);
        }

        public ActionResult jQueryUI() {
            return View();
        }
    }
}
