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
    public partial class Form_CargaVentas : Form
    {
        public Form Hijo { get; set; }
        public bool ventaok { get; set; }
        public Form_CargaVentas(Form hijo)
        {
            InitializeComponent();
            this.Hijo = hijo;
          
          

        }
        DataTable Tabla = new DataTable();


        private void label_MostrarPrecioTotal_Click(object sender, EventArgs e)
        {

        }

        private void label_Descuento_Click(object sender, EventArgs e)
        {

        }    
     
        ClienteSeleccionadoVentas ClienteSeleccionado = new ClienteSeleccionadoVentas();
        
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_ClientesNombre.Text != "Seleccione...")
            {
                this.comboBox_ClienteApellido.Text = this.comboBox_ClientesNombre.SelectedValue.ToString();
                

            }

            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal!=null)
            {                
               ClienteSeleccionado = Form_MenuPrincipal.ClientePorNombreApellido(comboBox_ClientesNombre.Text,comboBox_ClienteApellido.Text );
            }
                          
        }

        private void Form_CargaVentas_Load(object sender, EventArgs e)
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
                comboBox_ClientesNombre.DataSource = clientes;
                //Nombre de la propiedad que queremos que se muestre en el control


                // cargo Apellido en el combo por si hay dos nombre iguales
                List<Clientes> Apellido = new List<Clientes>();
                Apellido.Add(new Clientes() { Codigo = 0, Apellido = "Seleccione..." });

                if (Form_MenuPrincipal != null)
                {
                    Apellido.AddRange(Form_MenuPrincipal.Clientes());
                }

                //Origen de datos: Lista de los elementos a mostrar en el control
                comboBox_ClienteApellido.DataSource = Apellido;
                //Nombre de la propiedad que queremos que se muestre en el control


           

            //Cargo productos en el combo
            List<Productos> Producto = new List<Productos>();
            Productos NuevoProducto = new Productos();
            NuevoProducto.NombreProducto = "Seleccione...";
            NuevoProducto.TipoProducto.ID = 0;

            Producto.Add(NuevoProducto);           

            if (Form_MenuPrincipal != null)
            {
                Producto.AddRange(Form_MenuPrincipal.ListaProductosConStock());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_Productos.DataSource = Producto;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Productos.DisplayMember = "Nombre";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_Productos.ValueMember = "NombreProducto";

            //Agrego columnas a la grilla
            Tabla.Columns.Add("Codigo", typeof(string));
            Tabla.Columns.Add("Nombre", typeof(string));
            Tabla.Columns.Add("Cantidad", typeof(string));
            Tabla.Columns.Add("Precio unitario", typeof(string));
            Tabla.Columns.Add("Importe", typeof(string));
            dataGridView_Venta.DataSource = Tabla;


        }


        Productos ProductoSeleccionado = new Productos();
        private void comboBox_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ProductoSeleccionado = Form_MenuPrincipal.ProductoPorCodigo(comboBox_Productos.Text);
            }

            if (ProductoSeleccionado!=null)
            {
                label_MostrarPrecioProducto.Text = ProductoSeleccionado.PrecioUnitario.ToString("N2");
                label_MostrarPrecioUnitario.Text = ProductoSeleccionado.PrecioUnitario.ToString("N2");
                textBox_Cantidad.Text = "1";
            }
            else
            {
                label_MostrarPrecioUnitario.Text = 0.ToString("N2");
                label_MostrarPrecioProducto.Text = 0.ToString("N2");
                textBox_Cantidad.Text = "0";
            }
        }

        private void textBox_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Cantidad.Text !="")
            {              
                if (ProductoSeleccionado != null && int.Parse(textBox_Cantidad.Text) > ProductoSeleccionado.CantidadStock )
                {
                    textBox_Cantidad.Text = ProductoSeleccionado.CantidadStock.ToString(); //Si la cantidad es mayor al stock pongo el maximo
                }                

                if (ProductoSeleccionado != null)
                {//Multiplico la cantidad por el precio
                    label_MostrarPrecioProducto.Text = (ProductoSeleccionado.PrecioUnitario * int.Parse(textBox_Cantidad.Text)).ToString("N2");
                }                
            }
            else
            {
                label_MostrarPrecioProducto.Text = 0.ToString();
            }


        }


        Ventas NuevaVenta = new Ventas();
        decimal totalventa = 0;
        private void button_AgregarCompra_Click(object sender, EventArgs e)
        {
            //Capturo los datos
            //Verificar si el cliente existe

            if (comboBox_ClienteApellido.Text == "Seleccione..." && comboBox_ClientesNombre.Text == "Seleccione...")
            {
                ClienteSeleccionado.Ok = false;
            }
            
            if (ClienteSeleccionado.Ok == false)
                {
                      var mensaje = MessageBox.Show("El cliente seleccionado no existe", "Notificación", MessageBoxButtons.OK);
                }
                
            else
            { 
            if (decimal.Parse(label_MostrarPrecioProducto.Text) != 0)
            {
                // Agrega filas a la lista de vetnas
                Tabla.Rows.Add(ProductoSeleccionado.TipoProducto.ID.ToString(), ProductoSeleccionado.NombreProducto, textBox_Cantidad.Text, label_MostrarPrecioUnitario.Text, label_MostrarPrecioProducto.Text);
                ProductosVendidos NuevoProductoVendido = new ProductosVendidos();
                //Prop del producto
                NuevoProductoVendido.Cantidad = int.Parse(textBox_Cantidad.Text);
                NuevoProductoVendido.CodigoProducto = ProductoSeleccionado.TipoProducto.ID;
                NuevoProductoVendido.PrecioPorUnidad = ProductoSeleccionado.PrecioUnitario;
                //Agrego a la lista
                NuevaVenta.ListadoProductosVendidos.Add(NuevoProductoVendido);
                //Resto los productos vendidos
                Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
                if (Form_MenuPrincipal != null)
                {
                    Form_MenuPrincipal.RestarCantidadDeProductos(ProductoSeleccionado.TipoProducto.ID, int.Parse(textBox_Cantidad.Text));
                }

                if (ProductoSeleccionado != null)
                {
                    textBox_Cantidad.Text = 0.ToString();
                }

                decimal acu = 0, descuento = 0, acutotal=0;
                foreach (var item in NuevaVenta.ListadoProductosVendidos)
                {
                        acu = (item.Cantidad * item.PrecioPorUnidad) ;
                        acutotal = acutotal + acu;
                }


                if (ClienteSeleccionado.ClienteSelect.Tipo != "Vip" && acutotal < 1000)
                {
                    //Completo los campos informativos de la venta
                    label_MostrarPorcentajeDescuento.Text = ClienteSeleccionado.ClienteSelect.PorcentajeDescuento.ToString() + "%";
                    label_MostrarDescuento.Text = "La compra no supera los $1000";
                    label_MostrarTotalBruto.Text = "$  " + acutotal.ToString("N2");
                    label_MostrarPrecioTotal.Text = "$  " + acutotal.ToString("N2");
                    totalventa = acutotal;
                }
                else
                {
                    //Completo los campos informativos de la venta
                    label_MostrarPorcentajeDescuento.Text = ClienteSeleccionado.ClienteSelect.PorcentajeDescuento.ToString() + "%";
                    label_MostrarTotalBruto.Text = "$  " + acutotal.ToString("N2");
                    descuento = (acutotal * ClienteSeleccionado.ClienteSelect.PorcentajeDescuento) / 100;
                    label_MostrarDescuento.Text = "$  " + descuento.ToString("N2");
                    label_MostrarPrecioTotal.Text = "$  " + (acutotal - descuento).ToString("N2");
                    totalventa = acutotal - descuento;
                }
            }
            else
                MessageBox.Show("Seleccione un producto", "Faltan Datos");
        }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button_GuargarVenta_Click(object sender, EventArgs e)
        {
            if (NuevaVenta.ListadoProductosVendidos.Count()!=0)
            { 
            //completo caracteristicas del la venta 
            NuevaVenta.FechaVenta = DateTime.Today;
            NuevaVenta.ClienteAsociado = ClienteSeleccionado.ClienteSelect.Codigo;
            NuevaVenta.PorcentajeDescuentoAplicado = ClienteSeleccionado.ClienteSelect.PorcentajeDescuento;
            NuevaVenta.TotalVenta = totalventa;

            ventaok = false;
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                Form_MenuPrincipal.GuardarVentas(NuevaVenta);
                ventaok = true;
         
            }
            if (ventaok)
            {
                var mensaje = MessageBox.Show("La carga se realizo con éxito", "Notificación", MessageBoxButtons.OK);

                if (mensaje == DialogResult.OK)
                {
                        if (this.Hijo is Form_GrillaVenta)
                        {
                            var padre = Hijo as Interfaz_Grilla;
                            padre.ActualizarDatos();
                        }
                        this.Close();
                }
            }
            }
            else
            {
                MessageBox.Show("No hay productos cargados", "Faltan Datos");
            }

        }

        private void label_MostrarPrecioUnitario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_ClientesNombre_Click(object sender, EventArgs e)
        {
          

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ClienteSeleccionado = Form_MenuPrincipal.ClientePorNombreApellido(comboBox_ClientesNombre.Text, comboBox_ClienteApellido.Text);
            }
        }

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void Form_CargaVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.ventaok && !(Hijo is Form_GrillaVenta))
            {
                DialogResult result = MessageBox.Show("Desea cargar otra Venta?", "Salir", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var padre = this.Owner as Interface_ObtenerDatos;
                    Form NuevaVenta = new Form_CargaVentas(this.Owner);
                    NuevaVenta.Owner = this.Owner;
                    NuevaVenta.Show();

                }


            }
        }
    }
}
