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
    public partial class Form_Presupuestos : Form
    {
        public Form_Presupuestos()
        {
            InitializeComponent();
            textBox_CantidadDiaValidez.Text = "30";
        }
        DataTable Tabla = new DataTable();
        private void Form_Presupuestos_Load(object sender, EventArgs e)
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
            comboBox_NombreCliente.DataSource = clientes;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_NombreCliente.DisplayMember = "Nombre";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_NombreCliente.ValueMember = "Nombre";
            
            // cargo Apellido en el combo por si hay dos nombre iguales
            List<Clientes> Apellido = new List<Clientes>();
            Apellido.Add(new Clientes() { Codigo = 0, Apellido = "Seleccione..." });

            if (Form_MenuPrincipal != null)
            {
                Apellido.AddRange(Form_MenuPrincipal.Clientes());
            }

            //Origen de datos: Lista de los elementos a mostrar en el control
            comboBox_ApellidoCliente.DataSource = Apellido;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_ApellidoCliente.DisplayMember = "Apellido";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_ApellidoCliente.ValueMember = "Apellido";



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
            comboBox_Producto.DataSource = Producto;
            //Nombre de la propiedad que queremos que se muestre en el control
            comboBox_Producto.DisplayMember = "Nombre";
            //Nombre de la propiedad de la que queremos obtener el valor 
            //cuando se seleccione un item
            comboBox_Producto.ValueMember = "NombreProducto";

            //Agrego columnas a la grilla
            Tabla.Columns.Add("Codigo", typeof(string));
            Tabla.Columns.Add("Nombre", typeof(string));
            Tabla.Columns.Add("Cantidad", typeof(string));
            Tabla.Columns.Add("Precio unitario", typeof(string));
            Tabla.Columns.Add("Importe", typeof(string));
            Tabla.Columns.Add("Días de validez", typeof(string));
            dataGridView_GrillaPresupuestos.DataSource = Tabla;
                        
        }

        ClienteSeleccionadoVentas ClienteSeleccionado = new ClienteSeleccionadoVentas();
        

        private void comboBox_NombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_ApellidoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ClienteSeleccionado = Form_MenuPrincipal.ClientePorNombreApellido(comboBox_NombreCliente.Text, comboBox_ApellidoCliente.Text);
            }
            
        }
        Productos ProductoSeleccionado = new Productos();
        private void comboBox_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
            if (Form_MenuPrincipal != null)
            {
                ProductoSeleccionado = Form_MenuPrincipal.ProductoPorCodigo(comboBox_Producto.Text);
            }

            if (ProductoSeleccionado != null)
            {
                label_MostrarImporteDelProcuto.Text = ProductoSeleccionado.PrecioUnitario.ToString("N2");
                label_MostrarPrecioUnitario.Text = ProductoSeleccionado.PrecioUnitario.ToString("N2");
                textBox_Cantidad.Text = "1";
            }
            else
            {
                label_MostrarPrecioUnitario.Text = 0.ToString("N2");
                label_MostrarImporteDelProcuto.Text = 0.ToString("N2");
                textBox_Cantidad.Text = "0";
            }
        }

        private void textBox_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Cantidad.Text != "")
            {
                if (ProductoSeleccionado != null && int.Parse(textBox_Cantidad.Text) > ProductoSeleccionado.CantidadStock)
                {
                    textBox_Cantidad.Text = ProductoSeleccionado.CantidadStock.ToString(); //Si la cantidad es mayor al stock pongo el maximo
                }

                if (ProductoSeleccionado != null)
                {//Multiplico la cantidad por el precio
                    label_MostrarImporteDelProcuto.Text = (ProductoSeleccionado.PrecioUnitario * int.Parse(textBox_Cantidad.Text)).ToString("N2");
                }
            }  
            else
            {
                label_MostrarImporteDelProcuto.Text = 0.ToString();
            }

        }

        private void textBox_Cantidad_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox_Cantidad.Text != "")
            {
                if (ProductoSeleccionado != null && int.Parse(textBox_Cantidad.Text) > ProductoSeleccionado.CantidadStock)
                {
                    textBox_Cantidad.Text = ProductoSeleccionado.CantidadStock.ToString(); //Si la cantidad es mayor al stock pongo el maximo
                }

                if (ProductoSeleccionado != null)
                {//Multiplico la cantidad por el precio
                    label_MostrarImporteDelProcuto.Text = (ProductoSeleccionado.PrecioUnitario * int.Parse(textBox_Cantidad.Text)).ToString("N2");
                }
            }
            else
            {
                label_MostrarImporteDelProcuto.Text = 0.ToString();
            }
        }

        Presupuestos NuevoPresupuesto = new Presupuestos();
        decimal totalventa = 0;
        private void button_AgregarCompra_Click(object sender, EventArgs e)
        {
            //Capturo los datos
            if (comboBox_ApellidoCliente.Text == "Seleccione..." && comboBox_NombreCliente.Text == "Seleccione...")
            {
                ClienteSeleccionado.Ok = false;
            }

            if (ClienteSeleccionado.Ok == false)
            {
                var mensaje = MessageBox.Show("El cliente seleccionado no existe", "Notificación", MessageBoxButtons.OK);
            }

            else
            {
                if (decimal.Parse(label_MostrarImporteDelProcuto.Text) != 0)
                {
                    Tabla.Rows.Add(ProductoSeleccionado.TipoProducto.ID.ToString(), ProductoSeleccionado.NombreProducto, textBox_Cantidad.Text, label_MostrarPrecioUnitario.Text, label_MostrarImporteDelProcuto.Text, textBox_CantidadDiaValidez.Text);
                    ProductosVendidos NuevoProductoVendido = new ProductosVendidos();
                    //Prop del producto
                    NuevoProductoVendido.Cantidad = int.Parse(textBox_Cantidad.Text);
                    NuevoProductoVendido.CodigoProducto = ProductoSeleccionado.TipoProducto.ID;
                    NuevoProductoVendido.PrecioPorUnidad = ProductoSeleccionado.PrecioUnitario;
                    //Agrego a la lista
                    NuevoPresupuesto.ListadoProductosVendidos.Add(NuevoProductoVendido);
                    //Resto los productos vendidos                         

                    if (ProductoSeleccionado != null)
                    {
                        textBox_Cantidad.Text = 0.ToString();
                    }

                    decimal acu = 0, descuento = 0;
                    foreach (var item in NuevoPresupuesto.ListadoProductosVendidos)
                    {
                        acu = (item.Cantidad * item.PrecioPorUnidad) + acu;
                    }


                    if (ClienteSeleccionado.ClienteSelect.Tipo != "Vip" && acu < 1000)
                    {
                        //Completo los campos informativos del presupuesto
                        label_MostrarPorcentajeDescuento.Text = ClienteSeleccionado.ClienteSelect.PorcentajeDescuento.ToString() + "%";
                        label_MostrarDescuento.Text = "La compra no supera los $1000";
                        label_MostrarTotalBruto.Text = "$  " + acu.ToString("N2");
                        label_MostrarPrecioTotal.Text = "$  " + acu.ToString("N2");
                        totalventa = acu;
                    }
                    else
                    {
                        //Completo los campos informativos del presupuesto
                        label_MostrarPorcentajeDescuento.Text = ClienteSeleccionado.ClienteSelect.PorcentajeDescuento.ToString() + "%";
                        label_MostrarTotalBruto.Text = "$  " + acu.ToString("N2");
                        descuento = (acu * ClienteSeleccionado.ClienteSelect.PorcentajeDescuento) / 100;
                        label_MostrarDescuento.Text = "$  " + descuento.ToString("N2");
                        label_MostrarPrecioTotal.Text = "$  " + (acu - descuento).ToString("N2");
                        totalventa = acu - descuento;
                    }
                }
                else
                    MessageBox.Show("Seleccione un producto", "Faltan Datos");
            }
        }

        private void button_GuardarPresupuesto_Click(object sender, EventArgs e)
        {
            if (NuevoPresupuesto.ListadoProductosVendidos.Count != 0)
            {
                //completo caracteristicas del presupuesto
                NuevoPresupuesto.FechaPresupuesto = DateTime.Today;
                NuevoPresupuesto.FechaVenta = DateTime.MinValue;
                NuevoPresupuesto.ClienteAsociado = ClienteSeleccionado.ClienteSelect.Codigo;
                NuevoPresupuesto.PorcentajeDescuentoAplicado = ClienteSeleccionado.ClienteSelect.PorcentajeDescuento;
                NuevoPresupuesto.TotalVenta = totalventa;
                NuevoPresupuesto.DiasDeValidez = int.Parse(textBox_CantidadDiaValidez.Text);
                bool presupuestook = false;
                Interface_GuardarCargas Form_MenuPrincipal = this.Owner as Interface_GuardarCargas;
                if (Form_MenuPrincipal != null)
                {
                    Form_MenuPrincipal.CargarPresupuesto(NuevoPresupuesto);
                    presupuestook = true;
                }
                if (presupuestook)
                {
                    var mensaje = MessageBox.Show("La carga se realizo con éxito", "Notificación", MessageBoxButtons.OK);

                    if (mensaje == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay productos cargados", "Faltan Datos");
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

        private void textBox_CantidadDiaValidez_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
