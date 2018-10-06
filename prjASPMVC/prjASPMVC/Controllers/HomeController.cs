using prjEscola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjEscola.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroAula()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroAula(Aula aula)
        {
            if(ModelState.IsValid)
            {
                var Cad = new AulaRepositorio();
                Cad.Salvar(aula);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ListarAulas()
        {
            var ListaAulas = new AulaRepositorio();

            return View(ListaAulas.ListarTodos());
        }

        public ActionResult TesteLogico()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TesteLogico(TesteLogico teste)
        {
            if (ModelState.IsValid)
            {
                ViewBag.quantidade = teste.QuantidadeIteracoes;
            }
            return View();
        }
    }
}