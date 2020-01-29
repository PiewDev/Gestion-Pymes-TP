using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.cs
{
    public class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int PorcentajeDescuento { get; set; }
        //
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public DateTime Fechabaja { get; set; }


        public Clientes()
        {
            FechaNacimiento = new DateTime();
            Fechabaja = new DateTime();
            
        }
       
    }
}
