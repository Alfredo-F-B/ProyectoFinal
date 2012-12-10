using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistrarEmpleado()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado cc)
        {
            conectorDataContext db = new conectorDataContext();
            int b = db.Usuario.OrderByDescending(a => a.Id).First().Id;
            cc.IdUsuario = b;
            cc.FechaRegistro = DateTime.Now;
            db.Empleado.InsertOnSubmit(cc);
            db.SubmitChanges();

            return View();
        }
        public ActionResult Mostrar()
        {
            conectorDataContext db = new conectorDataContext();
            List<AdEm> lista = db.Empleado.Select(a => new AdEm()
            {
                id = a.Id,
                idUs = a.IdUsuario,
                ci = a.CI,
                apPaterno = a.ApPaterno,
                apMaterno = a.ApMaterno,
                nombres = a.Nombres,
                sexo = a.Sexo,
                fechaNacimiento = a.FechaNacimiento,
                nacionalidad = a.Nacionalidad,
                direccion = a.Direccion,
                telefono = a.Telefono,
                celular = a.Celular,
                fecharegistro = a.FechaRegistro
            }).ToList();
            ViewBag.info = lista;
            return View();
        }


    }
}
