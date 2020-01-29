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
    public partial class Form_GrillaPresupuestos : Form , Interfaz_Grilla
    {
        public Form_GrillaPresupuestos()
        {
            InitializeComponent();       
        }

        private void Form_GrillaPresupuestos_Load(object sender, EventArgs e)
        {            

            //Cargo clientes en el combo apellidos
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            List<Clientes> clientesnombre = new List<Clientes>();
            clientesnombre.Add(new Clientes() { Codigo = 0, Nombre = "Seleccione..." });


            if (Form_MenuPrincipal != null)
            {
                clientesnombre.AddRange(Form_MenuPrincipal.Clientes());
                dataGridView_GrillaPresuspuestos.DataSource = Form_MenuPrincipal.TodosLosPresupuestos();
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_Nombre.DataSource = clientesnombre;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Nombre.DisplayMember = "Nombre";


            //Cargo clientes en el combo nombres     
            List<Clientes> apellidos = new List<Clientes>();
            apellidos.Add(new Clientes() { Codigo = 0, Apellido = "Seleccione..." });

            if (Form_MenuPrincipal != null)
            {
                apellidos.AddRange(Form_MenuPrincipal.Clientes());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_Apellido.DataSource = apellidos;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Apellido.DisplayMember = "Apellido";
            




        }
        public void ActualizarDatos()
        {
            var padre = this.Owner as  Interface_GuardarCargas;
            if (padre != null)
            {
                dataGridView_GrillaPresuspuestos.DataSource =padre.TodosLosPresupuestos().Where(x => x.ClienteAsociado.ToString() != "Error").ToList();

                if (!(padre.TodosLosPresupuestos().Count == 0))
                {
                    this.button_Conver.Enabled = true;
                    

                }
                else
                {
                    
                    this.button_Conver.Enabled = false;
                }            
                this.button_Conver.Refresh();

            }

        }

        private void comboBox_FiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Nombre.Text != "Seleccione...")
            {
                this.comboBox_Apellido.Text = this.comboBox_Nombre.SelectedValue.ToString();


            }
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ClienteSeleccionado = Form_MenuPrincipal.ClientePorNombreApellido(comboBox_Nombre.Text, comboBox_Apellido.Text);
            }
        }

        ConverPresupuestoEnVenta PasarAVenta = new ConverPresupuestoEnVenta();

        ClienteSeleccionadoVentas ClienteSeleccionado = new ClienteSeleccionadoVentas();

        string codigopresupuesto;
        private void button1_Click(object sender, EventArgs e)
        {           

            if (comboBox_Apellido.Text == "Seleccione..." && comboBox_Nombre.Text == "Seleccione...")
            {
                ClienteSeleccionado.Ok = false;
            }

            if (ClienteSeleccionado.Ok == false)
            {
                var mensaje = MessageBox.Show("El cliente seleccionado no existe", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                

            Presupuestos PresuBuscado = new Presupuestos();
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal!= null)
            {
                codigopresupuesto = dataGridView_GrillaPresuspuestos.CurrentRow.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString(); //Para obtener el nombre

                //Busca el presupuesto seleccionado
                PresuBuscado = Form_MenuPrincipal.BuscarPresupuesto(int.Parse(codigopresupuesto)); //Buscar codigo del presupuesto
               //Verifica si lo puede pasar a venta
                    PasarAVenta = Form_MenuPrincipal.ConvertirPresupueso(PresuBuscado);

                    if (PasarAVenta.Ok)
                    { 
                    //Elimino el presupuesto    
                    PresuBuscado.FechaBaja = DateTime.MinValue;
                    //Crea la venta
                        Ventas NuevaVenta = new Ventas();
                        NuevaVenta.ClienteAsociado = ClienteSeleccionado.ClienteSelect.Codigo;
                        NuevaVenta.FechaVenta = DateTime.Today;
                        NuevaVenta.ListadoProductosVendidos = PasarAVenta.Presupuesto.ListadoProductosVendidos;
                        NuevaVenta.PorcentajeDescuentoAplicado = PasarAVenta.Presupuesto.PorcentajeDescuentoAplicado;
                        NuevaVenta.TotalVenta =(PasarAVenta.Presupuesto.TotalVenta - ((PasarAVenta.Presupuesto.TotalVenta*ClienteSeleccionado.ClienteSelect.PorcentajeDescuento) /100));
                    //Lo agrega a la lista de ventas
                        Form_MenuPrincipal.GuardarVentas(NuevaVenta);
                    var mensaje = MessageBox.Show(PasarAVenta.Texto, "Notificación", MessageBoxButtons.OK);
                    if (mensaje== DialogResult.OK)
                    {
                        //Actualizo la grilla
                        dataGridView_GrillaPresuspuestos.DataSource = Form_MenuPrincipal.TodosLosPresupuestos();

                    }
                }
                    else
                    {
                        var mensaje = MessageBox.Show(PasarAVenta.Texto, "Notificación", MessageBoxButtons.OK);
                }         
            }
            this.ActualizarDatos();

            }
        }

        private void dataGridView_GrillaPresuspuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        
        private void dataGridView_GrillaPresuspuestos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form NuevaVenta = new Form_Presupuestos(this);
            NuevaVenta.Owner = this.Owner;
            NuevaVenta.Show();  

        }

        private void comboBox_Apellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ClienteSeleccionado = Form_MenuPrincipal.ClientePorNombreApellido(comboBox_Nombre.Text, comboBox_Apellido.Text);
            }
        }

        public void ActualizarGrilla()
        {
            this.dataGridView_GrillaPresuspuestos.Refresh();
        }
    }
}
