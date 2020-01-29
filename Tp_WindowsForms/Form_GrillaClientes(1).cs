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
    public partial class Form_GrillaClientes : Form, Interfaz_Grilla
    {
        public Form_GrillaClientes(Form owner)
        {
            InitializeComponent();
            var padre = owner as Interface_ObtenerDatos;

            if (padre != null)
                this.listaClientesBindingSource1.DataSource = padre.Empresa.ListaClientesSinEliminados();

            

        }

        
        private void dataGridView_GrillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionadoVentas Nuevo = new ClienteSeleccionadoVentas();
            var padre = this.Owner as Interface_ObtenerDatos;
            if (padre != null)
            {
                Nuevo = padre.ObtenerClientePorNombreYApellido(dataGridView_GrillaClientes.CurrentRow.Cells["Nombre"].Value.ToString(), dataGridView_GrillaClientes.CurrentRow.Cells["Apellido"].Value.ToString());
                Form NuevoCLiente = new Form_CargaClientes("", this.Owner, Nuevo.ClienteSelect);
                NuevoCLiente.Owner = this;
                NuevoCLiente.Show();
                
            }
            else
            { }
                
            
            
            
            
        }

        private void Form_GrillaClientes_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarGrilla()
        {
            this.dataGridView_GrillaClientes.Refresh();
        }

        private void dataGridView_GrillaClientes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            

        }

        private void dataGridView_GrillaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.OKCancel);


            if (result == DialogResult.OK)
            {
                ClienteSeleccionadoVentas Nuevo = new ClienteSeleccionadoVentas();
                var padre = this.Owner as Interface_ObtenerDatos;
                if (padre != null)
                { 
                Nuevo = padre.ObtenerClientePorNombreYApellido(dataGridView_GrillaClientes.CurrentRow.Cells["Nombre"].Value.ToString(), dataGridView_GrillaClientes.CurrentRow.Cells["Apellido"].Value.ToString());
                Nuevo.ClienteSelect.Fechabaja = DateTime.MinValue;
                padre.Modificar_EliminarClientes(Nuevo.ClienteSelect);
                this.listaClientesBindingSource1.DataSource = padre.Empresa.ListaClientesSinEliminados();
                }
                this.ActualizarGrilla();
                
            }
        }
    }
}
