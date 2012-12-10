using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class AgenciaController : Controller
    {
        //
        // GET: /Agencia/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarAg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarAg(ClienteAgencia ca)
        {
            conectorDataContext db = new conectorDataContext();
            int b = db.Usuario.OrderByDescending(a => a.Id).First().Id;
            ca.IdUsuario = b;
            db.ClienteAgencia.InsertOnSubmit(ca);
            db.SubmitChanges();
            return View();
        }

    }
}
