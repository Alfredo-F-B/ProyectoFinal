using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{

    public class habit
    {
        public int id { set; get; }
        public int numero { set; get; }
        public DateTime fecha { set; get; }
        public string categoria { set; get; }
        public string estado { set; get; }
        public string descripcion { set; get; }
        public string piso { set; get; }
        public double precio { set; get; }
        public string pago { set; get; }
        public string tvcable { set; get; }
        public string baño { set; get; }
        public string acondicionador { set; get; }
        public string calefaccion { set; get; }
        public List<reserPersona> reservas { set; get; }
    }
    public class serv
    {
        public int id { set; get; }
        public string categoria { set; get; }
        public double precio { set; get; }
        public string descripcion { set; get; }
        public DateTime fecha { set; get; }
    }
    public class AdEm
    {
        public int id { set; get; }
        public int idUs { set; get; }
        public string ci { set; get; }
        public string apPaterno { set; get; }
        public string apMaterno { set; get; }
        public string nombres { set; get; }
        public string sexo { set; get; }
        public DateTime fechaNacimiento { set; get; }
        public string nacionalidad { set; get; }
        public string direccion { set; get; }
        public string telefono { set; get; }
        public string celular { set; get; }
        public DateTime fecharegistro { set; get; }

    }
    public class reserPersona
    {
        public int idHabit { set; get; }
        public int cantDias { set; get; }
        public DateTime llegada { set; get; }
        public DateTime salida { set; get; }
        public DateTime fecha { set; get; }
        public string tipopago { set; get; }
        public int idpersona {set ;get; }
	    public int idUsuario {set ;get; }
	    public int ci {set ;get; }
	    public string apPaterno {set ;get; }
	    public string apMaterno {set ;get; }
	    public string nombre {set ;get; }
	    public string pasaporte {set ;get; }
	    public string categoria {set ;get; }
	    public string telefono {set ;get; }
	    public string celular {set ;get; }
	    public string email {set ;get; }
	    public string direccion {set ;get; }
	    public string ciudad {set ;get; }
	    public string estado {set ;get; }
	    public string pais {set ;get; }
	    public string comentarios {set ;get; }
        public string cumpleanos { set; get; }
    }
    public class variable
    {
        public int numhabit { set; get; }
    }



    /*public class Dashboard
    {
        public string numero { set; get; }
        public string descripcion { set; get; }
        public List<reserPersona> reservas { set; get; }
    }*/
}