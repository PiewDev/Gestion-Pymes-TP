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
    public partial class Form_Reporte1 : Form
    {
        public Form_Reporte1()
        {
            InitializeComponent();
        }

        private void Form_Reporte1_Load(object sender, EventArgs e)
        {
            //Cargo clientes en el combo
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            List<Clientes> clientes = new List<Clientes>();
            clientes.Add(new Clientes() { Codigo = 0, Nombre = "Seleccione..." });

            if (Form_MenuPrincipal != null)
            {
                clientes.AddRange(Form_MenuPrincipal.Clientes());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_Nombre.DataSource = clientes;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Nombre.DisplayMember = "Nombre";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_Nombre.ValueMember = "Nombre";

            // cargo Apellido en el combo por si hay dos nombre iguales
            List<Clientes> Apellido = new List<Clientes>();
            Apellido.Add(new Clientes() { Codigo = 0, Apellido = "Seleccione..." });

            if (Form_MenuPrincipal != null)
            {
                Apellido.AddRange(Form_MenuPrincipal.Clientes());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_Apellido.DataSource = Apellido;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Apellido.DisplayMember = "Apellido";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_Apellido.ValueMember = "Apellido";
        }
        ClienteSeleccionadoVentas ClienteSeleccionado = new ClienteSeleccionadoVentas();
        int c = 0;
        private void comboBox_Apellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = c + 1;

            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ClienteSeleccionado = Form_MenuPrincipal.ClientePorNombreApellido(comboBox_Nombre.Text, comboBox_Apellido.Text);
            }
            //Verificar si el cliente existe
            if (comboBox_Apellido.Text != "Seleccione..." && comboBox_Nombre.Text != "Seleccione..." & c >= 2)
            {
                this.button_Buscar.Enabled = true;
                if (ClienteSeleccionado.Ok == false)
                {
                    var mensaje = MessageBox.Show("El cliente seleccionado no existe", "Notificación", MessageBoxButtons.OK);
                    this.button_Buscar.Enabled = false;
                }
            }
            else
            {
                this.button_Buscar.Enabled = false;               
            }
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            Interface_Reportes Form_MenuPrincipal = this.Owner as Interface_Reportes;
            if (Form_MenuPrincipal!=null)
            {

                dataGridView1.AutoGenerateColumns = true;
                var lista= Form_MenuPrincipal.Reporte1(DateTime.Parse(dateTimePicker_FechaDeste.Text), DateTime.Parse(dateTimePicker_FechaHasta.Text), ClienteSeleccionado.ClienteSelect.Nombre, ClienteSeleccionado.ClienteSelect.Apellido);

                if (lista.Count!=0)
                {
                    dataGridView1.DataSource = lista;
                }
                else
                {
                    var mensaje = MessageBox.Show("No existe ninguna venta para el cliente seleccionado", "Notificación", MessageBoxButtons.OK);
                }
               
            }
        }

        private void comboBox_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
        }
    }
}
