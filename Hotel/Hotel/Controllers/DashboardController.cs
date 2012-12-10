using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;

namespace Hotel.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dash()
        {
            conectorDataContext db = new conectorDataContext();
            List<habit> lista = db.Habitacion.Select(a => new habit()
            {
                numero = a.Numero,
                descripcion = a.Descripcion,
                reservas = a.Reserva.Select(b => new reserPersona()
                {
                    idHabit=b.IdHabitacion,
                    llegada = b.LLegada,
                    salida = b.Salida,
                    cantDias = b.Salida.Day-b.LLegada.Day+1
                }).ToList()
            }).ToList();
            ViewBag.info = lista;


            //para sacar las fechas de los dias
            DateTime hoy = DateTime.Now;
            int anio = hoy.Year;
            int mes = hoy.Month;
            int dia = hoy.Day;
            string value = "";
            while (value != "Monday")
            {
                DateTime find = new DateTime(anio, mes, dia);
                dia--;
                if (dia < 1)
                {
                    mes--;
                    if (mes < 1)
                    {
                        anio--;
                        mes = 12;
                    }
                    dia = DateTime.DaysInMonth(anio, mes);
                }
                value = find.DayOfWeek.ToString();
            }
            dia++;
            DateTime hh = new DateTime(anio, mes, dia);
            //fin para sacar las fechas de los dias

            //para sacar una lista de las semanas
            List<DateTime> semanas = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                semanas.Add(hh.AddDays(i));
            }
            ViewBag.fechas = semanas;
            //fin para sacar las lista de las semanas


            return View();
        }

        public ActionResult Anterior()
        {
            conectorDataContext db = new conectorDataContext();
            List<habit> lista = db.Habitacion.Select(a => new habit()
            {
                numero = a.Numero,
                descripcion = a.Descripcion,
                reservas = a.Reserva.Select(b => new reserPersona()
                {
                    idHabit = b.IdHabitacion,
                    llegada = b.LLegada,
                    salida = b.Salida,
                    cantDias = b.Salida.Day - b.LLegada.Day + 1
                }).ToList()
            }).ToList();
            ViewBag.info = lista;


            //para sacar las fechas de los dias
            DateTime hoy = DateTime.Now;
            int anio = hoy.Year;
            int mes = hoy.Month;
            int dia = hoy.Day-7;
            string value = "";
            while (value != "Monday")
            {
                DateTime find = new DateTime(anio, mes, dia);
                dia--;
                if (dia < 1)
                {
                    mes--;
                    if (mes < 1)
                    {
                        anio--;
                        mes = 12;
                    }
                    dia = DateTime.DaysInMonth(anio, mes);
                }
                value = find.DayOfWeek.ToString();
            }
            dia++;
            DateTime hh = new DateTime(anio, mes, dia);
            //fin para sacar las fechas de los dias

            //para sacar una lista de las semanas
            List<DateTime> semanas = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                semanas.Add(hh.AddDays(i));
            }
            ViewBag.fechas = semanas;
            //fin para sacar las lista de las semanas


            return View();
        }





        public ActionResult Siguiente()
        {
            conectorDataContext db = new conectorDataContext();
            List<habit> lista = db.Habitacion.Select(a => new habit()
            {
                numero = a.Numero,
                descripcion = a.Descripcion,
                reservas = a.Reserva.Select(b => new reserPersona()
                {
                    idHabit = b.IdHabitacion,
                    llegada = b.LLegada,
                    salida = b.Salida,
                    cantDias = b.Salida.Day - b.LLegada.Day + 1
                }).ToList()
            }).ToList();
            ViewBag.info = lista;


            //para sacar las fechas de los dias
            DateTime hoy = DateTime.Now;
            int anio = hoy.Year;
            int mes = hoy.Month;
            int dia = hoy.Day+7;
            string value = "";
            while (value != "Monday")
            {
                DateTime find = new DateTime(anio, mes, dia);
                dia--;
                if (dia < 1)
                {
                    mes--;
                    if (mes < 1)
                    {
                        anio--;
                        mes = 12;
                    }
                    dia = DateTime.DaysInMonth(anio, mes);
                }
                value = find.DayOfWeek.ToString();
            }
            dia++;
            DateTime hh = new DateTime(anio, mes, dia);
            //fin para sacar las fechas de los dias

            //para sacar una lista de las semanas
            List<DateTime> semanas = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                semanas.Add(hh.AddDays(i));
            }
            ViewBag.fechas = semanas;
            //fin para sacar las lista de las semanas


            return View();
        }

    }
}
