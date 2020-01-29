using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.cs
{
    public class ReporteProdVendidosContraProdDefectuosos
    {
        public string NombreProducto { get; set; }
        public string CantidadVendidos { get; set; }
        public string CantidadDefectuosos { get; set; }
        public string PorcentajeDefecYVendidos { get; set; }
    }
}
