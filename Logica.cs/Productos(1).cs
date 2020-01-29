using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.cs
{
    public class Productos
    {
        public string NombreProducto { get; set; }
        public int CantidadStock { get; set; }
        public decimal PrecioUnitario { get; set; }
        public TipoDeProducto TipoProducto { get; set; }
        public DateTime FechaBaja { get; set; }
        

        public Productos()
        {
            this.TipoProducto = new TipoDeProducto();
        }

    }
}
