using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class ServicioController : Controller
    {
        //
        // GET: /Servicio/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Servicio ss)
        {
            if (ModelState.IsValid)
            {
                conectorDataContext db = new conectorDataContext();
                ss.Fecha = DateTime.Now;
                db.Servicio.InsertOnSubmit(ss);
                db.SubmitChanges();
                return RedirectToAction("Exito", "Servicio");
            }
            else
            {
                return RedirectToAction("Fallo", "Servicio");
            }
        }
        public ActionResult Exito()
        {
            return View();
        }
        public ActionResult Fallo()
        {
            return View();
        }
        public ActionResult Mostrar() 
        {
            conectorDataContext db = new conectorDataContext();
            List<serv> lista = db.Servicio.Select(a => new serv()
            {
                id=a.Id,
                categoria=a.Categoria,
                precio=a.Precio,
                descripcion=a.Descripcion,
                fecha=a.Fecha
            }).ToList();
            ViewBag.info = lista;
            return View();
        }
    }
}
