using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.cs;

namespace Tp_WindowsForms
{
    interface Interface_GuardarCargas
    {
        void GuardarVentas(Ventas parametro_venta);
        List<Productos> ListaProductosConStock();
        ClienteSeleccionadoVentas ClientePorNombreApellido(string nombre, string apellido);
        Productos ProductoPorCodigo(string nombre);
        List<Clientes> Clientes();
        void RestarCantidadDeProductos(int codigo, int cantidad);
        void CargarPresupuesto(Presupuestos parametro_presupuesto);
        List<Productos> TodosLosProductos();
        List<Ventas> Ventas();
    }
}
