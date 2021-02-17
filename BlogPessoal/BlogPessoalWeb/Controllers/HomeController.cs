using BlogPessoalWeb.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoalWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private BlogPessoalContexto db = new BlogPessoalContexto();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoriasDeArtigo()
        {
            var lista = db.CategoriasDeArtigo.ToList();
            return PartialView("../Shared/_Categorias", lista);
        }
    }
}