using BlogPessoalWeb.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoalWeb.Filtros
{
    public class ExibirCategoriaDeArtigoActionFilter : ActionFilterAttribute
    {
        private BlogPessoalContexto db = new BlogPessoalContexto();
        public int CategoriaDeArtigoId { get; set; }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var categoriaDeArtigo = db.CategoriasDeArtigo
            .Where(t => t.Id == CategoriaDeArtigoId)
            .OrderByDescending(t => t.Descricao).Take(3).ToList();

            filterContext.Controller.ViewBag.CategoriaDeArtigos = categoriaDeArtigo;
            base.OnResultExecuting(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values
                ["controller"];
            var actionName = filterContext.RouteData.Values
                ["action"];
            var message = String.Format("{0} controller:{1} cation: {2}", "onactionexecuting",
                controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
            base.OnActionExecuting(filterContext);

        }
    }

    
}