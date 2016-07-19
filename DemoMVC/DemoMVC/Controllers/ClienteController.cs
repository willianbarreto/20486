using DemoMVC.Filters;
using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio repo = new ClienteRepositorio();
        public ActionResult Index()
        {
            var clientes = repo.Listar();
            return View(clientes);
        }

        //[Authorize]
        //[DemoActionFilter]
        [HandleError(ExceptionType=typeof(NotImplementedException), View="UnderConstruction")]
        public ActionResult Details(int id)
        {
            //throw new NotImplementedException("Teste de erro");
            ViewBag.datahora = string.Format("A data atual é {0} e o horario de agora é {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            var cliente = repo.Buscar(id);
            return View(cliente);
        }

        //private Cliente SelecionarCliente(int id)
        //{
        //    var cliente = new Cliente();
        //    switch (id)
        //    {
        //        case 1:
        //            cliente = new Cliente { Id = 1, Nome = "Willian", DataNascimento = new DateTime(1987, 11, 24), Email = "ws.barreto@hotmail.com", Idade = 28 };
        //            break;
        //        case 2:
        //            cliente = new Cliente { Id = 2, Nome = "Edson", DataNascimento = new DateTime(1965, 09, 24), Email = "xxx@example.com", Idade = 21 };
        //            break;
        //        case 3:
        //            cliente = new Cliente { Id = 3, Nome = "Isabele", DataNascimento = new DateTime(2009, 01, 16), Email = "", Idade = 0 };
        //            break;
        //        case 4:
        //            cliente = new Cliente { Id = 4, Nome = "Mikaelle", DataNascimento = new DateTime(2005, 04, 20), Email = "", Idade = 0 };
        //            break;
        //        case 5:
        //            cliente = new Cliente { Id = 5, Nome = "Miguel", DataNascimento = new DateTime(2000, 07, 02), Email = "", Idade = 0 };
        //            break;
        //        case 6:
        //            cliente = new Cliente { Id = 6, Nome = "Henrique", DataNascimento = new DateTime(2002, 08, 11), Email = "", Idade = 0 };
        //            break;
        //        default:
        //            break;
        //    }
        //    return cliente;
        //}

        public ActionResult Create()
        {
            return View("CreateNovo");
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Adicionar(cliente);
                    return RedirectToAction("Index");
                }
                return View("CreateNovo");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var cliente = repo.Buscar(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Editar(cliente);
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var cliente = repo.Buscar(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                repo.Deletar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Busca(string filtro)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busca(string filtro, string val)
        {
            if (filtro == "idade")
            {
                try{
                    var cliente = repo.BuscarClientePorIdade(int.Parse(val));
                    return View("Index", cliente);
                }
                catch{
                    return View("~/Shared/Error");
                }
            }
            else
            {
                try{
                    var cliente = repo.BuscarClientePorNome(val);
                    return View("Index", cliente);
                }
                catch
                {
                    return View("~/Shared/Error");
                }
            }
        }

        public ActionResult Lista() {
            ViewBag.carros = new string[] {"Onix", "Cruze","X1","Cayenne","Ferrari","Gol" };
            var clientes = repo.Listar();            
            return View(clientes);
        }

        public string Mensagem(int tipo) {
            return string.Format("Mensagem para o cliente {0}", repo.Buscar(tipo).Nome);
        }

        public PartialViewResult PartialCliente() { 
            return PartialView(); 
        }

        public ActionResult NovaRota(int id, string cor)
        {
            var msg = string.Format("Você escolheu o id {0} e a cor {1}", id, cor);
            ViewBag.msg = msg;

            return View();
        }
    }
}
