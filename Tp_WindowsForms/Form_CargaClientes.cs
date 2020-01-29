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
using System.Text.RegularExpressions;

namespace Tp_WindowsForms
{
    public partial class Form_CargaClientes : Form
    {
        public bool Modificar { get; set; }
        public Form Hijo { get; set; }
        public bool CargaExitosa { get; set; }

        public Form_CargaClientes(string numerocodigo, Form padre, Form hijo)
        {
            InitializeComponent();

            this.label_Codigo.Text = numerocodigo;
            this.comboBox_TipoCliente.Text = "Regular";
            this.Hijo = hijo;
            this.Owner = padre;
            var datos = padre as Interface_ObtenerDatos;
            this.Modificar = false;

            if (datos != null)
            { 
                this.listaBindingSource2.DataSource = datos.Lista_Provincias;
                
            }
            


        }

        public Form_CargaClientes(string numerocodigo, Form padre, Clientes Cliente)
        {
            InitializeComponent();
            this.Owner = padre;
            var datos = padre as Interface_ObtenerDatos;
            if (datos != null)
                this.listaBindingSource2.DataSource = datos.Lista_Provincias;

            
            this.label_Codigo.Text = Cliente.Codigo.ToString();
            this.textBox_Apellido.Text = Cliente.Apellido;
            this.textBox_Nombre.Text = Cliente.Nombre;
            this.textBox_Correo.Text = Cliente.Email;
            this.textBox_Telefono.Text = Cliente.Telefono;
            this.dateTimePicker_Fecha.Value = Cliente.FechaNacimiento;
            this.comboBox_Localidad.Text = Cliente.Localidad;
            this.comboBox_Provincia.Text = Cliente.Provincia;
            this.comboBox_TipoCliente.Text = Cliente.Tipo;
            this.Modificar = true;



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_CargaClientes_Load(object sender, EventArgs e)
        {

        }

        private void Form_CargaClientes_Shown(object sender, EventArgs e)
        {

        }
        private int ComprobarCampos()
        {
            int Comprobar = 0;
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!Regex.IsMatch(textBox_Correo.Text, sFormato))
            {
                if (!(Regex.Replace(textBox_Correo.Text, sFormato, String.Empty).Length == 0))
                {
                  Comprobar = 1;
                }
            

            }
         

            if
            (
              String.IsNullOrWhiteSpace(textBox_Apellido.Text) ||
              String.IsNullOrWhiteSpace(textBox_Nombre.Text) ||
              String.IsNullOrWhiteSpace(textBox_Telefono.Text) ||
              String.IsNullOrWhiteSpace(comboBox_TipoCliente.Text)              
            )
            {
                Comprobar = 2;

            }

            
            return Comprobar;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos() == 1)
            {
                MessageBox.Show("Correo no valido");
            }
            else
            {
                if (ComprobarCampos() == 2)
                {
                    MessageBox.Show("Hay campos en blanco");

                }
                else
                {
                    Clientes NuevoCliente = new Clientes()
                    {
                        Codigo = int.Parse(label_Codigo.Text),
                        Apellido = textBox_Apellido.Text,
                        Nombre = textBox_Nombre.Text,
                        Email = textBox_Correo.Text,
                        FechaNacimiento = DateTime.Parse(dateTimePicker_Fecha.Text),
                        Telefono = textBox_Telefono.Text,
                        Tipo = comboBox_TipoCliente.Text,
                        Localidad = comboBox_Localidad.Text,
                        Provincia = comboBox_Provincia.Text,


                    };



                    CargaExitosa = false;

                    if (NuevoCliente.Tipo == "Vip")
                    {
                        NuevoCliente.PorcentajeDescuento = 10;
                    }
                    else
                    {
                        NuevoCliente.PorcentajeDescuento = 5;
                    }

                    
                    if (Modificar)
                    {
                        Interface_ObtenerDatos Form_MenuPrincipal = this.Owner.Owner as Interface_ObtenerDatos;
                        Form_MenuPrincipal.Modificar_EliminarClientes(NuevoCliente);
                        CargaExitosa = true;
                        Interfaz_Grilla Form_Grilla = this.Owner as Interfaz_Grilla;
                        Form_Grilla.ActualizarGrilla();
                    }
                    else
                    {
                        Interface_ObtenerDatos Form_MenuPrincipal = this.Owner as Interface_ObtenerDatos;
                        if (Form_MenuPrincipal != null)
                    {
                        
                        Form_MenuPrincipal.GuardarClientes(NuevoCliente);
                        CargaExitosa = true;
                        if (this.Hijo is Form_GrillaClientes)
                            { 
                            Interfaz_Grilla Form_Grilla = this.Hijo as Interfaz_Grilla;
                            Form_Grilla.ActualizarGrilla();
                                Form_Grilla.ActualizarDatos();
                            }
                        }
                    }
                    if (CargaExitosa)
                    {
                        var mensaje = MessageBox.Show("La carga se realizo con éxito", "Notificación", MessageBoxButtons.OK);

                        if (mensaje == DialogResult.OK)
                        {
                            CargaExitosa = true;
                            this.Close();
                        }
                    }

                }






            }
        }

        private void label_Codigo_Click(object sender, EventArgs e)
        {


        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                ;
                e.Handled = true;
                return;
            }


        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                ;
                e.Handled = true;
                return;
            }
        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var opcion = (Provincia)this.comboBox_Provincia.SelectedItem;
            listaLocalidadesBindingSource1.DataSource = opcion.Lista_Localidades;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox_Localidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_TipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_CargaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.CargaExitosa && !Modificar && !(Hijo is Form_GrillaClientes) )
            {
                DialogResult result = MessageBox.Show("Desea cargar otro cliente?", "Salir", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var padre = this.Owner as Interface_ObtenerDatos;
                    Form NuevoCLiente = new Form_CargaClientes(padre.Empresa.ObtenerNumeroSiguienteCliente(), this.Owner, this.Owner);
                    NuevoCLiente.Owner = this.Owner;
                    NuevoCLiente.Show();

                }


            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
