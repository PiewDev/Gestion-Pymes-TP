using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.cs;

namespace Tp_WindowsForms
{
   public interface Interface_ObtenerDatos
    {
        void GuardarClientes(Clientes parametro_clientes);
        Empresa Empresa { get; }
        ListaProvincias Lista_Provincias { get; }
        void Modificar_EliminarClientes(Clientes Cliente);
        ClienteSeleccionadoVentas ObtenerClientePorNombreYApellido(string nombre, string apellido);
    }
}
