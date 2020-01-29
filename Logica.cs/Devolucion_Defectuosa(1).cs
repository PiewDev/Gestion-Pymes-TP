using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.cs
{
        public class Devolucion_Defectuosa : Devoluciones
        {
            public string MotivoDefecto { get; set; }
            public int NumeroReclamo { get; set; }
            public string ComentarioCliente { get; set; }
        }
    
}
