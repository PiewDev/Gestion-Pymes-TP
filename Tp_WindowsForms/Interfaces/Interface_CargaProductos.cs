using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.cs;

namespace Tp_WindowsForms
{
    interface Interface_CargaProductos
    {
        void GuardarProductos(Productos parametro_producto);
        void Modificar_EliminarProductos(Productos productos_parametro);
        List<Productos> ProductosNoEliminados();
        Productos ObtenerProductoPorNyC(string nombre, int codigo);
       


    }
}
