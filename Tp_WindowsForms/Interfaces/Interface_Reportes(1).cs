using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.cs;

namespace Tp_WindowsForms
{
    interface Interface_Reportes
    {
        List<ReporteListaEnPeriodoFechas> Reporte1(DateTime fechadesde, DateTime fechahasta, string nombre, string apellido);
        ReporteProdVendidosContraProdDefectuosos Reporte2(string nombre);
        List<ReporteVendidoPorMes> Reporte3(DateTime fechadesde, DateTime fechahasta);
        List<Devolucion_Defectuosa> Defectuosos();
    }
}
