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
    public partial class Form_GrillaVenta : Form ,Interfaz_Grilla


    {
        public Form_GrillaVenta(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
            var datos = this.Owner as Interface_GuardarCargas;
            if (datos.Clientes() != null)

                this.comboBox_cliente.DataSource = datos.Clientes();
           


        }



        private void Form_GrillaVenta_Load(object sender, EventArgs e)
        {
            //Cargo clientes en el combo
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            List<Clientes> clientes = new List<Clientes>();
            clientes.Add(new Clientes() { Codigo = 0, Apellido = "Seleccione..." });

            if (Form_MenuPrincipal != null)
            {
                clientes.AddRange(Form_MenuPrincipal.Clientes());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_cliente.DataSource = clientes;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_cliente.DisplayMember = "Apellido";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item




        }


        private void dataGridView_GrillaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var datos = this.Owner as Interface_GuardarCargas;
           
            if (comboBox_cliente.Text=="Seleccione...")
            {
                dataGridView_GrillaVenta.DataSource = datos.Ventas();
            }
            else
            {
                dataGridView_GrillaVenta.DataSource = datos.Ventas().Where(x => x.ClienteAsociado.ToString() == this.comboBox_cliente.SelectedValue.ToString()).ToList();
            }

            this.ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            this.dataGridView_GrillaVenta.Refresh();
            



        }

        public void ActualizarDatos()
        {
            var datos = this.Owner as Interface_GuardarCargas;
            if (datos != null)
            {
                if (datos.Ventas() != null)
                    dataGridView_GrillaVenta.DataSource = datos.Ventas().Where(x => x.ClienteAsociado.ToString() != "error").ToList(); ;



            }

            ActualizarGrilla();



        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            Form NuevaVenta = new Form_CargaVentas(this);
            NuevaVenta.Owner = this.Owner;
            NuevaVenta.Show();

        }
    }
}
