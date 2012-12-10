using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarPer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarPer(ClientePersona ca, Reserva ra, Habitacion hh)
        {
            conectorDataContext db = new conectorDataContext();
            int b = db.Usuario.OrderByDescending(a => a.Id).First().Id;
            ca.IdUsuario = b;
            db.ClientePersona.InsertOnSubmit(ca);
            db.SubmitChanges();

            ra.IdUsuario = b;

            int d = db.Habitacion.OrderByDescending(a => a.Id).First().Id;
            ra.IdHabitacion = d;
            ra.CantDias = ra.Salida.Day - ra.LLegada.Day;
            ra.Fecha = DateTime.Now;
            db.Reserva.InsertOnSubmit(ra);
            db.SubmitChanges();

            if (hh.Id == ra.IdHabitacion && hh.Estado=="Libre")
            {
                hh.Estado = "Ocupado";
                db.Habitacion.InsertOnSubmit(hh);
                db.SubmitChanges();
            }
            return View();
        }

        /*[HttpPost]
        public ActionResult RegistrarPer(Reserva ca)
        {
            conectorDataContext db = new conectorDataContext();
            int b = db.Usuario.OrderByDescending(a => a.Id).First().Id;
            ca.IdUsuario = b;
            int d = db.Habitacion.OrderByDescending(a => a.Id).First().Id;
            ca.IdHabitacion = d;
            ca.CantDias = ca.Salida.Day - ca.LLegada.Day;
            ca.Fecha = DateTime.Now;
            db.Reserva.InsertOnSubmit(ca);
            db.SubmitChanges();
            return View();
        }*/

    }
}
