using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.cs;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace Tp_WindowsForms
{
    public partial class Form_MenuPrincipal : Form, Interface_ObtenerDatos, Interface_CargaProductos, Interface_GuardarCargas, Interface_Reportes
    {
        Empresa NuevaEmpresa = new Empresa();
        public ListaProvincias Lista_Provincias { get; private set; }

        public Empresa Empresa
        {
            get
            {
                return this.NuevaEmpresa;
            }
        }
        private void nUEVOPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_NuevoProducto = new Form_CargaProductos(this.NuevaEmpresa.ObtenerNumeroSiguienteProducto());
            frm_NuevoProducto.Owner = this;
            frm_NuevoProducto.Show();
        }


        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        void Interface_ObtenerDatos.Modificar_EliminarClientes(Clientes Cliente)
        {
            this.NuevaEmpresa.Modificar_EliminarClientes(Cliente);
        }

        ClienteSeleccionadoVentas Interface_ObtenerDatos.ObtenerClientePorNombreYApellido(string nombre, string apellido)
        {
            return this.NuevaEmpresa.ObtenerClientePorNombreYApellido(nombre, apellido);
        }

        private void nUEVAVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaVenta = new Form_CargaVentas();
            NuevaVenta.Owner = this;
            NuevaVenta.Show();

        }

        private void nUEVOPRESUPUESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoPresupuesto = new Form_Presupuestos();
            NuevoPresupuesto.Owner = this;
            NuevoPresupuesto.Show();
        }



        private void vERGRILLADEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaGrillaProductos = new Form_GrillaProductos(this);
            NuevaGrillaProductos.Owner = this;
            NuevaGrillaProductos.Show();
        }

        public Form_MenuPrincipal()
        {
            InitializeComponent();
            this.Lista_Provincias = new ListaProvincias();

            string outputJSON = File.ReadAllText(Directory.GetCurrentDirectory() + "\\localidades.json");
            Lista_Provincias.Lista = JsonConvert.DeserializeObject<List<Provincia>>(outputJSON);
        }



        private void nUEVOCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoCLiente = new Form_CargaClientes(this.NuevaEmpresa.ObtenerNumeroSiguienteCliente(), this);
            NuevoCLiente.Owner = this;
            NuevoCLiente.Show();
        }


        private void vERGRILLADECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaGrillaClientes = new Form_GrillaClientes(this);
            NuevaGrillaClientes.Owner = this;
            NuevaGrillaClientes.Show();
        }



        public void GuardarClientes(Clientes parametro_clientes)
        {
            NuevaEmpresa.CargarClientes(parametro_clientes);
        }
        //Productos
        public void GuardarProductos(Productos parametro_producto)
        {
            this.NuevaEmpresa.CargarProductos(parametro_producto);
        }

        public List<Productos> LisProductos()
        {
            return NuevaEmpresa.ListaProductosSinEliminados();
        }

        //Ventas
        public void GuardarVentas(Ventas parametro_venta)
        {
            this.NuevaEmpresa.GuardarVentas(parametro_venta);
        }

        public List<Productos> ListaProductosConStock()
        {
            return NuevaEmpresa.ListaProductosConLosQueTienenStock();
        }

        public Productos ProductoPorCodigo(string nombre)
        {
            return NuevaEmpresa.ObtenerProductoPorNombre(nombre);
        }

        public ClienteSeleccionadoVentas ClientePorNombreApellido(string nombre, string apellido)
        {
            return NuevaEmpresa.ObtenerClientePorNombreYApellido(nombre, apellido);
        }

        public List<Clientes> Clientes()
        {
            return this.NuevaEmpresa.ListaClientesSinEliminados();
        }

        public void RestarCantidadDeProductos(int codigo, int cantidad)
        {
            this.NuevaEmpresa.RestarProductosEnStock(codigo, cantidad);
        }

        //Presupuesto
        public void CargarPresupuesto(Presupuestos parametro_presupuesto)
        {
            this.NuevaEmpresa.CargarPresupuesto(parametro_presupuesto);
        }

        private void lISTADEVENTASENUNADETERMINADAFECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoFormularioReporte1 = new Form_Reporte1();
            NuevoFormularioReporte1.Owner = this;
            NuevoFormularioReporte1.Show();
        }

        public List<ReporteListaEnPeriodoFechas> Reporte1(DateTime fechadesde, DateTime fechahasta, string nombre, string apellido)
        {
            return this.NuevaEmpresa.ReporteEnUnPeriodoDeFechasYClientePorParametro(fechadesde, fechahasta, nombre, apellido);
        }

        private void pORCENTAJEDEPRODUCTOSDEFECTUOSOSCONTRAPRODUCTOSVENDIDOSDEUNDETERMINADOTIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoFormularioReporte2 = new Form_Reporte2();
            NuevoFormularioReporte2.Owner = this;
            NuevoFormularioReporte2.Show();
        }

        public ReporteProdVendidosContraProdDefectuosos Reporte2(string nombre)
        {
            return this.NuevaEmpresa.ReporteProducVencontraDefec(nombre);
        }

        public List<Productos> TodosLosProductos()
        {
            return this.NuevaEmpresa.ListaProductos;
        }

        private void gANANCIASTOTALESPORMESENUNADERTERMINADAFECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoFormularioReporte3 = new Form_Reporte3();
            NuevoFormularioReporte3.Owner = this;
            NuevoFormularioReporte3.Show();
        }

        public List<ReporteVendidoPorMes> Reporte3(DateTime fechadesde, DateTime fechahasta)
        {
            return this.NuevaEmpresa.ReporteVentasPorMesEnUnRangoDeFechas(fechadesde, fechahasta);
        }

        public void Modificar_EliminarProductos(Productos productos_parametro)
        {
            this.NuevaEmpresa.Modificar_EliminarProductos(productos_parametro);
        }

        public List<Productos> ProductosNoEliminados()
        {
            List<Productos> Lista = new List<Productos>();
            Lista = this.NuevaEmpresa.ListaProductosSinEliminados();
            return Lista;
        }

        public Productos ObtenerProductoPorNyC(string nombre, int codigo)
        {
            return this.NuevaEmpresa.ObtenerProductoPorNyC(nombre, codigo);
        }

        private void vERGRILLADEVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoGrillaVenta = new Form_GrillaVenta();
            NuevoGrillaVenta.Owner = this;
            NuevoGrillaVenta.Show();

        }

        public List<Ventas> Ventas()
        {
            return this.NuevaEmpresa.ListaVentas;
        }

        private void lISTADEVENTASENUNADETERMINADAFECHAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form Reporte1 = new Form_Reporte1();
            Reporte1.Owner = this;
            Reporte1.Show();
            

             
        }

        private void pORCENTAJEDEPRODUCTOSDEFECTUOSOSCONTRAPRODUCTOSVENDIDOSDEUNDETERMINADOTIPOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form Reporte2 = new Form_Reporte2();
            Reporte2.Owner = this;
            Reporte2.Show();

        }

        private void gANANCIASTOTALESPORMESENUNADERTERMINADAFECHAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form Reporte3 = new Form_Reporte3();
            Reporte3.Owner = this;
            Reporte3.Show();
        }

        public List<Devolucion_Defectuosa> Defectuosos()
        {
            return this.NuevaEmpresa.ListasDevolucionDefectuosa;
        }
    }
}