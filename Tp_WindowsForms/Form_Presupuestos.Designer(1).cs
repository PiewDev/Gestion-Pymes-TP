namespace Tp_WindowsForms
{
    partial class Form_Presupuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_NombreCliente = new System.Windows.Forms.Label();
            this.label_ApellidoCliente = new System.Windows.Forms.Label();
            this.label_Producto = new System.Windows.Forms.Label();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.label_PrecioUnitario = new System.Windows.Forms.Label();
            this.label_Importe = new System.Windows.Forms.Label();
            this.button_AgregarCompra = new System.Windows.Forms.Button();
            this.comboBox_ApellidoCliente = new System.Windows.Forms.ComboBox();
            this.comboBox_NombreCliente = new System.Windows.Forms.ComboBox();
            this.comboBox_Producto = new System.Windows.Forms.ComboBox();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label_MostrarPrecioUnitario = new System.Windows.Forms.Label();
            this.label_MostrarImporteDelProcuto = new System.Windows.Forms.Label();
            this.dataGridView_GrillaPresupuestos = new System.Windows.Forms.DataGridView();
            this.label_TotalBruto = new System.Windows.Forms.Label();
            this.label_Descuento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_MostrarTotalBruto = new System.Windows.Forms.Label();
            this.label_MostrarDescuento = new System.Windows.Forms.Label();
            this.label_MostrarPorcentajeDescuento = new System.Windows.Forms.Label();
            this.label_MostrarPrecioTotal = new System.Windows.Forms.Label();
            this.button_GuardarPresupuesto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CantidadDiaValidez = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio unitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio unitario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Importe";
            this.dataGridViewTextBoxColumn5.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cliente.Location = new System.Drawing.Point(12, 9);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(62, 20);
            this.label_Cliente.TabIndex = 0;
            this.label_Cliente.Text = "Cliente:";
            // 
            // label_NombreCliente
            // 
            this.label_NombreCliente.AutoSize = true;
            this.label_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreCliente.Location = new System.Drawing.Point(38, 39);
            this.label_NombreCliente.Name = "label_NombreCliente";
            this.label_NombreCliente.Size = new System.Drawing.Size(60, 16);
            this.label_NombreCliente.TabIndex = 0;
            this.label_NombreCliente.Text = "Nombre:";
            // 
            // label_ApellidoCliente
            // 
            this.label_ApellidoCliente.AutoSize = true;
            this.label_ApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ApellidoCliente.Location = new System.Drawing.Point(238, 39);
            this.label_ApellidoCliente.Name = "label_ApellidoCliente";
            this.label_ApellidoCliente.Size = new System.Drawing.Size(61, 16);
            this.label_ApellidoCliente.TabIndex = 0;
            this.label_ApellidoCliente.Text = "Apellido:";
            // 
            // label_Producto
            // 
            this.label_Producto.AutoSize = true;
            this.label_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Producto.Location = new System.Drawing.Point(24, 96);
            this.label_Producto.Name = "label_Producto";
            this.label_Producto.Size = new System.Drawing.Size(65, 16);
            this.label_Producto.TabIndex = 0;
            this.label_Producto.Text = "Producto:";
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cantidad.Location = new System.Drawing.Point(249, 97);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(65, 16);
            this.label_Cantidad.TabIndex = 0;
            this.label_Cantidad.Text = "Cantidad:";
            // 
            // label_PrecioUnitario
            // 
            this.label_PrecioUnitario.AutoSize = true;
            this.label_PrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecioUnitario.Location = new System.Drawing.Point(441, 97);
            this.label_PrecioUnitario.Name = "label_PrecioUnitario";
            this.label_PrecioUnitario.Size = new System.Drawing.Size(96, 16);
            this.label_PrecioUnitario.TabIndex = 0;
            this.label_PrecioUnitario.Text = "Precio unitario:";
            // 
            // label_Importe
            // 
            this.label_Importe.AutoSize = true;
            this.label_Importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Importe.Location = new System.Drawing.Point(656, 95);
            this.label_Importe.Name = "label_Importe";
            this.label_Importe.Size = new System.Drawing.Size(56, 16);
            this.label_Importe.TabIndex = 0;
            this.label_Importe.Text = "Importe:";
            // 
            // button_AgregarCompra
            // 
            this.button_AgregarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AgregarCompra.Location = new System.Drawing.Point(1004, 82);
            this.button_AgregarCompra.Name = "button_AgregarCompra";
            this.button_AgregarCompra.Size = new System.Drawing.Size(143, 46);
            this.button_AgregarCompra.TabIndex = 1;
            this.button_AgregarCompra.Text = "Agregar compra al presupuesto";
            this.button_AgregarCompra.UseVisualStyleBackColor = true;
            this.button_AgregarCompra.Click += new System.EventHandler(this.button_AgregarCompra_Click);
            // 
            // comboBox_ApellidoCliente
            // 
            this.comboBox_ApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ApellidoCliente.FormattingEnabled = true;
            this.comboBox_ApellidoCliente.Location = new System.Drawing.Point(305, 39);
            this.comboBox_ApellidoCliente.Name = "comboBox_ApellidoCliente";
            this.comboBox_ApellidoCliente.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ApellidoCliente.TabIndex = 2;
            this.comboBox_ApellidoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_ApellidoCliente_SelectedIndexChanged);
            // 
            // comboBox_NombreCliente
            // 
            this.comboBox_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NombreCliente.FormattingEnabled = true;
            this.comboBox_NombreCliente.Location = new System.Drawing.Point(104, 39);
            this.comboBox_NombreCliente.Name = "comboBox_NombreCliente";
            this.comboBox_NombreCliente.Size = new System.Drawing.Size(121, 24);
            this.comboBox_NombreCliente.TabIndex = 2;
            this.comboBox_NombreCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_NombreCliente_SelectedIndexChanged);
            // 
            // comboBox_Producto
            // 
            this.comboBox_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Producto.FormattingEnabled = true;
            this.comboBox_Producto.Location = new System.Drawing.Point(95, 94);
            this.comboBox_Producto.Name = "comboBox_Producto";
            this.comboBox_Producto.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Producto.TabIndex = 2;
            this.comboBox_Producto.SelectedIndexChanged += new System.EventHandler(this.comboBox_Producto_SelectedIndexChanged);
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(322, 96);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.ShortcutsEnabled = false;
            this.textBox_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cantidad.TabIndex = 3;
            this.textBox_Cantidad.TextChanged += new System.EventHandler(this.textBox_Cantidad_TextChanged_1);
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label_MostrarPrecioUnitario
            // 
            this.label_MostrarPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.label_MostrarPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPrecioUnitario.Location = new System.Drawing.Point(544, 94);
            this.label_MostrarPrecioUnitario.Name = "label_MostrarPrecioUnitario";
            this.label_MostrarPrecioUnitario.Size = new System.Drawing.Size(96, 22);
            this.label_MostrarPrecioUnitario.TabIndex = 0;
            // 
            // label_MostrarImporteDelProcuto
            // 
            this.label_MostrarImporteDelProcuto.BackColor = System.Drawing.Color.White;
            this.label_MostrarImporteDelProcuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarImporteDelProcuto.Location = new System.Drawing.Point(719, 93);
            this.label_MostrarImporteDelProcuto.Name = "label_MostrarImporteDelProcuto";
            this.label_MostrarImporteDelProcuto.Size = new System.Drawing.Size(96, 22);
            this.label_MostrarImporteDelProcuto.TabIndex = 0;
            // 
            // dataGridView_GrillaPresupuestos
            // 
            this.dataGridView_GrillaPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaPresupuestos.Location = new System.Drawing.Point(185, 138);
            this.dataGridView_GrillaPresupuestos.Name = "dataGridView_GrillaPresupuestos";
            this.dataGridView_GrillaPresupuestos.Size = new System.Drawing.Size(701, 282);
            this.dataGridView_GrillaPresupuestos.TabIndex = 4;
            // 
            // label_TotalBruto
            // 
            this.label_TotalBruto.AutoSize = true;
            this.label_TotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalBruto.Location = new System.Drawing.Point(224, 451);
            this.label_TotalBruto.Name = "label_TotalBruto";
            this.label_TotalBruto.Size = new System.Drawing.Size(73, 16);
            this.label_TotalBruto.TabIndex = 0;
            this.label_TotalBruto.Text = "TotalBruto:";
            // 
            // label_Descuento
            // 
            this.label_Descuento.AutoSize = true;
            this.label_Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descuento.Location = new System.Drawing.Point(429, 451);
            this.label_Descuento.Name = "label_Descuento";
            this.label_Descuento.Size = new System.Drawing.Size(76, 16);
            this.label_Descuento.TabIndex = 0;
            this.label_Descuento.Text = "Descuento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio total:";
            // 
            // label_MostrarTotalBruto
            // 
            this.label_MostrarTotalBruto.BackColor = System.Drawing.Color.White;
            this.label_MostrarTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarTotalBruto.Location = new System.Drawing.Point(201, 478);
            this.label_MostrarTotalBruto.Name = "label_MostrarTotalBruto";
            this.label_MostrarTotalBruto.Size = new System.Drawing.Size(96, 22);
            this.label_MostrarTotalBruto.TabIndex = 0;
            // 
            // label_MostrarDescuento
            // 
            this.label_MostrarDescuento.BackColor = System.Drawing.Color.White;
            this.label_MostrarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarDescuento.Location = new System.Drawing.Point(438, 478);
            this.label_MostrarDescuento.Name = "label_MostrarDescuento";
            this.label_MostrarDescuento.Size = new System.Drawing.Size(124, 37);
            this.label_MostrarDescuento.TabIndex = 0;
            // 
            // label_MostrarPorcentajeDescuento
            // 
            this.label_MostrarPorcentajeDescuento.BackColor = System.Drawing.Color.White;
            this.label_MostrarPorcentajeDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPorcentajeDescuento.Location = new System.Drawing.Point(385, 478);
            this.label_MostrarPorcentajeDescuento.Name = "label_MostrarPorcentajeDescuento";
            this.label_MostrarPorcentajeDescuento.Size = new System.Drawing.Size(37, 22);
            this.label_MostrarPorcentajeDescuento.TabIndex = 0;
            // 
            // label_MostrarPrecioTotal
            // 
            this.label_MostrarPrecioTotal.BackColor = System.Drawing.Color.White;
            this.label_MostrarPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPrecioTotal.Location = new System.Drawing.Point(716, 478);
            this.label_MostrarPrecioTotal.Name = "label_MostrarPrecioTotal";
            this.label_MostrarPrecioTotal.Size = new System.Drawing.Size(96, 22);
            this.label_MostrarPrecioTotal.TabIndex = 0;
            // 
            // button_GuardarPresupuesto
            // 
            this.button_GuardarPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GuardarPresupuesto.Location = new System.Drawing.Point(893, 468);
            this.button_GuardarPresupuesto.Name = "button_GuardarPresupuesto";
            this.button_GuardarPresupuesto.Size = new System.Drawing.Size(152, 44);
            this.button_GuardarPresupuesto.TabIndex = 5;
            this.button_GuardarPresupuesto.Text = "Guardar presupuesto";
            this.button_GuardarPresupuesto.UseVisualStyleBackColor = true;
            this.button_GuardarPresupuesto.Click += new System.EventHandler(this.button_GuardarPresupuesto_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(830, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "   Dias validez:";
            // 
            // textBox_CantidadDiaValidez
            // 
            this.textBox_CantidadDiaValidez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CantidadDiaValidez.Location = new System.Drawing.Point(892, 94);
            this.textBox_CantidadDiaValidez.Name = "textBox_CantidadDiaValidez";
            this.textBox_CantidadDiaValidez.ShortcutsEnabled = false;
            this.textBox_CantidadDiaValidez.Size = new System.Drawing.Size(52, 22);
            this.textBox_CantidadDiaValidez.TabIndex = 6;
            this.textBox_CantidadDiaValidez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CantidadDiaValidez_KeyPress);
            // 
            // Form_Presupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 524);
            this.Controls.Add(this.textBox_CantidadDiaValidez);
            this.Controls.Add(this.button_GuardarPresupuesto);
            this.Controls.Add(this.dataGridView_GrillaPresupuestos);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.comboBox_Producto);
            this.Controls.Add(this.comboBox_NombreCliente);
            this.Controls.Add(this.comboBox_ApellidoCliente);
            this.Controls.Add(this.button_AgregarCompra);
            this.Controls.Add(this.label_MostrarImporteDelProcuto);
            this.Controls.Add(this.label_MostrarDescuento);
            this.Controls.Add(this.label_MostrarPorcentajeDescuento);
            this.Controls.Add(this.label_MostrarPrecioTotal);
            this.Controls.Add(this.label_MostrarTotalBruto);
            this.Controls.Add(this.label_MostrarPrecioUnitario);
            this.Controls.Add(this.label_PrecioUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Importe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Descuento);
            this.Controls.Add(this.label_TotalBruto);
            this.Controls.Add(this.label_Cantidad);
            this.Controls.Add(this.label_Producto);
            this.Controls.Add(this.label_ApellidoCliente);
            this.Controls.Add(this.label_NombreCliente);
            this.Controls.Add(this.label_Cliente);
            this.Name = "Form_Presupuestos";
            this.Text = "Form_Presupuestos";
            this.Load += new System.EventHandler(this.Form_Presupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaPresupuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_NombreCliente;
        private System.Windows.Forms.Label label_ApellidoCliente;
        private System.Windows.Forms.Label label_Producto;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.Label label_PrecioUnitario;
        private System.Windows.Forms.Label label_Importe;
        private System.Windows.Forms.Button button_AgregarCompra;
        private System.Windows.Forms.ComboBox comboBox_ApellidoCliente;
        private System.Windows.Forms.ComboBox comboBox_NombreCliente;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label_MostrarPrecioUnitario;
        private System.Windows.Forms.Label label_MostrarImporteDelProcuto;
        private System.Windows.Forms.DataGridView dataGridView_GrillaPresupuestos;
        private System.Windows.Forms.Label label_TotalBruto;
        private System.Windows.Forms.Label label_Descuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_MostrarTotalBruto;
        private System.Windows.Forms.Label label_MostrarDescuento;
        private System.Windows.Forms.Label label_MostrarPorcentajeDescuento;
        private System.Windows.Forms.Label label_MostrarPrecioTotal;
        private System.Windows.Forms.Button button_GuardarPresupuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CantidadDiaValidez;
    }
}