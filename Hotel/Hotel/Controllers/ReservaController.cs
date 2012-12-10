using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class ReservaController : Controller
    {
        //
        // GET: /Reserva/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Reserva rr)
        {
            if (ModelState.IsValid)
            {
                conectorDataContext db = new conectorDataContext();
                rr.Fecha = DateTime.Now;
                db.Reserva.InsertOnSubmit(rr);
                db.SubmitChanges();
                return RedirectToAction("Exito", "Reserva");
            }
            else
            {
                return RedirectToAction("Fallo", "Reserva");
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
    }
}
