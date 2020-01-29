using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logica.cs
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "ciudades")]
        public List<Localidades> Lista_Localidades { get; set; }
    }
}
