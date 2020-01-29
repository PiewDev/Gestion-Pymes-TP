using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.cs
{
    public class Presupuestos : Ventas
    {
        public DateTime FechaPresupuesto { get; set; }
        public int DiasDeValidez { get; set; }

        public Presupuestos()
        {
            this.DiasDeValidez = 30;
        }


    }
}
