using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.cs
{
    public class Ventas
    {
        public DateTime FechaVenta { get; set; }
        public List<ProductosVendidos> ListadoProductosVendidos { get; set; }
        public int PorcentajeDescuentoAplicado { get; set; }
        public decimal TotalVenta { get; set; }
        public int ClienteAsociado { get; set; }
        public int Codigo { get; set; }

        public Ventas()
        {
            this.ListadoProductosVendidos = new List<ProductosVendidos>();
        }

    }
}
