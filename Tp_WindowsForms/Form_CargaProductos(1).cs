﻿using System;
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
    public partial class Form_CargaProductos : Form
    {
        public Form_CargaProductos(string numerocodigo)
        {
            InitializeComponent();
            label_IDcorrelativo.Text = numerocodigo;
        }
        public Form_CargaProductos(Productos producto)
        {
            InitializeComponent();
            label_IDcorrelativo.Text = producto.TipoProducto.ID.ToString();
            textBox_CantidadStock.Text = producto.CantidadStock.ToString();
            textBox_Descripcion.Text = producto.TipoProducto.Detalle;
            textBox_Nombre.Text = producto.NombreProducto;
            textBox_PrecioUnitario.Text = producto.PrecioUnitario.ToString();




        }
        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Form_CargaProductos_Load(object sender, EventArgs e)
        {

        }
        private bool ComprobarCampos()
        {
            if
                (
                !string.IsNullOrWhiteSpace(textBox_CantidadStock.Text) &&
                !string.IsNullOrWhiteSpace(textBox_Descripcion.Text) &&
                !string.IsNullOrWhiteSpace(textBox_Nombre.Text) &&
                !string.IsNullOrWhiteSpace(textBox_PrecioUnitario.Text)

                )

                return true;
            else
                return false;


            
            
        }
        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (this.ComprobarCampos())
            { 
            Productos NuevoProducto = new Productos();

            NuevoProducto.CantidadStock = int.Parse(textBox_CantidadStock.Text);
            NuevoProducto.NombreProducto = textBox_Nombre.Text;
            NuevoProducto.PrecioUnitario = decimal.Parse(textBox_PrecioUnitario.Text);
            NuevoProducto.FechaBaja = DateTime.Today;

            if (NuevoProducto.TipoProducto != null)
            {
                NuevoProducto.TipoProducto.Detalle = textBox_Descripcion.Text;
                NuevoProducto.TipoProducto.ID = int.Parse(label_IDcorrelativo.Text);
            }

            bool CargaExitosa = false;

            if (this.Owner is Form_GrillaProductos)
            {
                Interface_CargaProductos Form_Menu = this.Owner.Owner as Interface_CargaProductos;
                if (Form_Menu != null)
                {
                    Form_Menu.Modificar_EliminarProductos(NuevoProducto);
                    CargaExitosa = true;
                    Interfaz_Grilla Grilla = this.Owner as Interfaz_Grilla;
                    Grilla.ActualizarGrilla();
                }

            }
            else
            {
                Interface_CargaProductos Form_MenuPrincipal = this.Owner as Interface_CargaProductos;
                if (Form_MenuPrincipal != null)
                {
                    Form_MenuPrincipal.GuardarProductos(NuevoProducto);
                    CargaExitosa = true;
                }

                
            }
            if (CargaExitosa)
            {
                var mensaje = MessageBox.Show("La carga se realizo con éxito", "Notificación", MessageBoxButtons.OK);

                if (mensaje == DialogResult.OK)
                {
                    this.Close();
                }
            }
            }
            else
                MessageBox.Show("Hay campos vacios", "Faltan Datos", MessageBoxButtons.OK);
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

        private void textBox_CantidadStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_PrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_PrecioUnitario.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
    }
}
