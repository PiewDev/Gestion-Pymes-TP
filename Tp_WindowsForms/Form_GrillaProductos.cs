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
    public partial class Form_GrillaProductos : Form, Interfaz_Grilla
    {
        
        public Form_GrillaProductos(Form datos)
        {
            InitializeComponent();

            this.Owner = datos;
            this.ActualizarDatos();


            

        }
        public void ActualizarDatos()
        {
            var padre = this.Owner as Interface_CargaProductos;
            if (padre != null)
            {
                this.dataGridView_GrillaProductos.DataSource = padre.ProductosNoEliminados();
                if (!(padre.ProductosNoEliminados().Count == 0))
                {
                    this.button_modif.Enabled = true;
                    this.button1.Enabled = true;

                }
                else
                {
                    this.button_modif.Enabled = false;
                    this.button1.Enabled = false;
                }
                this.ActualizarGrilla();
                this.button_modif.Refresh();
                this.button1.Refresh();

            }
        }


        private void dataGridView_GrillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_modif_Click(object sender, EventArgs e)
        {
            
            var padre = this.Owner as Interface_GuardarCargas;
            var nuevo = padre.ProductoPorCodigo(dataGridView_GrillaProductos.CurrentRow.Cells["Nombre"].Value.ToString());
            Form NuevaFormularioProducto = new Form_CargaProductos(nuevo,this);
            NuevaFormularioProducto.Owner = this;
            NuevaFormularioProducto.Show();
        }

        public void ActualizarGrilla()
        {
            this.dataGridView_GrillaProductos.Refresh();
        }

        private void button_elim_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar Producto", MessageBoxButtons.OKCancel);

            
            if (result == DialogResult.OK)
            {
                
                var padre = this.Owner as Interface_GuardarCargas;
                var nuevo = padre.ProductoPorCodigo(dataGridView_GrillaProductos.CurrentRow.Cells["Nombre"].Value.ToString());
                nuevo.FechaBaja = DateTime.MinValue;
                var padres = this.Owner as Interface_CargaProductos;
                padres.Modificar_EliminarProductos(nuevo);
                this.dataGridView_GrillaProductos.DataSource = padres.ProductosNoEliminados();
                this.ActualizarGrilla();
                this.ActualizarDatos();
                

            }
        }

        private void Form_GrillaProductos_Load(object sender, EventArgs e)
        {

        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            var padre = this.Owner as Interface_ObtenerDatos;
            Form NuevaFormularioProducto = new Form_CargaProductos( padre.Empresa.ObtenerNumeroSiguienteProducto(),this);
            NuevaFormularioProducto.Owner = this.Owner;
            NuevaFormularioProducto.Show();

        }
    }
}
