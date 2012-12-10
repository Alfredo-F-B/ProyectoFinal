using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;
using System.IO;

//using LumenWorks.Framework.IO.Csv;


namespace Hotel.Controllers
{
    public class HabitacionController : Controller
    {
        //
        // GET: /Habitacion/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrar() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Habitacion aa)
        {
                conectorDataContext db = new conectorDataContext();
                aa.Fecha = DateTime.Now;
                db.Habitacion.InsertOnSubmit(aa);
                db.SubmitChanges();
                return View();
        }
        public ActionResult Fallo()
        {

            return View();
        }

        public ActionResult Mostrar()
        {
            conectorDataContext db = new conectorDataContext();
            List<habit> lista = db.Habitacion.Select(a => new habit()
            {
                numero=a.Numero,
                categoria=a.Categoria,
                estado=a.Estado,
                descripcion=a.Descripcion,
                piso=a.Piso,
                precio=a.Precio,
                pago=a.TipoPago,
                fecha=a.Fecha,
                tvcable=a.TvCable,
                baño=a.Baño,
                acondicionador=a.Acondicionador,
                calefaccion=a.Calefaccion
            }).ToList();
            ViewBag.info = lista;
            return View();
        }

        public ActionResult Eliminar() 
        {
            return View();
        }
    }
}
