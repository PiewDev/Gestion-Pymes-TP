using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.cs;

namespace Tp_WindowsForms
{
    public partial class Form_Reporte2 : Form
    {
        public Form_Reporte2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Reporte2_Load(object sender, EventArgs e)
        {
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            //Cargo productos en el combo
            List<Productos> Producto = new List<Productos>();
            Productos NuevoProducto = new Productos();
            NuevoProducto.NombreProducto = "Seleccione...";
            NuevoProducto.TipoProducto.ID = 0;

            Producto.Add(NuevoProducto);

            if (Form_MenuPrincipal != null)
            {
               Producto.AddRange(Form_MenuPrincipal.TodosLosProductos());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_Nombre.DataSource = Producto;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Nombre.DisplayMember = "Nombre";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_Nombre.ValueMember = "NombreProducto";
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
           
            ReporteProdVendidosContraProdDefectuosos NuevoReporte = new ReporteProdVendidosContraProdDefectuosos();
            Interface_Reportes Form_MenuPrincipal = this.Owner as Interface_Reportes;
            if (Form_MenuPrincipal!=null)
            {
                NuevoReporte = Form_MenuPrincipal.Reporte2(comboBox_Nombre.Text);                
            }

            label_MostrarNombreProducto.Text = NuevoReporte.NombreProducto;
            label_MostrarCantidadVendidos.Text = NuevoReporte.CantidadVendidos;
            label_MostrarCantidadDefectuosos.Text = NuevoReporte.CantidadDefectuosos;
            label_MostrarDefsobreVen.Text = NuevoReporte.PorcentajeDefecYVendidos;
        }

        private void comboBox_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Nombre.Text == "Seleccione...")
            {
                button_Confirmar.Enabled = false;
            }
            else
            {
                button_Confirmar.Enabled = true;
            }
        }
    }
}
