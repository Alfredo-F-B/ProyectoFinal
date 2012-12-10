using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class EmpresaController : Controller
    {
        //
        // GET: /Empresa/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarEmp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarEmp(ClienteEmpresa ce)
        {
            conectorDataContext db = new conectorDataContext();
            int b = db.Usuario.OrderByDescending(a => a.Id).First().Id;
            ce.IdUsuario = b;
            db.ClienteEmpresa.InsertOnSubmit(ce);
            db.SubmitChanges();
            return View();
        }

    }
}
