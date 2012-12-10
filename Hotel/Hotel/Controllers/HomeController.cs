using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modifique esta plantilla para poner en marcha su aplicación ASP.NET MVC.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descripción de la aplicación.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";
            return View();
        }
        public ActionResult Informacion()
        {
            ViewBag.Message = "Informacion.";
            return View();
        }
        public ActionResult Contactenos()
        {
            ViewBag.Message = "Contactenos.";
            return View();
        }
        public ActionResult Promociones()
        {
            ViewBag.Message = "Promociones.";
            return View();
        }
        public ActionResult Politicas()
        {
            ViewBag.Message = "Politicas.";
            return View();
        }
    }
}
