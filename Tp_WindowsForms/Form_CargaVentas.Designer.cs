namespace Tp_WindowsForms
{
    partial class Form_CargaVentas
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
            this.components = new System.ComponentModel.Container();
            this.button_GuargarVenta = new System.Windows.Forms.Button();
            this.comboBox_ClientesNombre = new System.Windows.Forms.ComboBox();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Productos = new System.Windows.Forms.ComboBox();
            this.button_AgregarCompra = new System.Windows.Forms.Button();
            this.label_SeleccioneCliente = new System.Windows.Forms.Label();
            this.label_Producto = new System.Windows.Forms.Label();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.label_PrecioTotal = new System.Windows.Forms.Label();
            this.label_MostrarPrecioTotal = new System.Windows.Forms.Label();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label_MostrarPrecioProducto = new System.Windows.Forms.Label();
            this.label_Descuento = new System.Windows.Forms.Label();
            this.label_MostrarDescuento = new System.Windows.Forms.Label();
            this.label_PrecioUnitario = new System.Windows.Forms.Label();
            this.label_MostrarPrecioUnitario = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.dataGridView_Venta = new System.Windows.Forms.DataGridView();
            this.label_TotalBruto = new System.Windows.Forms.Label();
            this.label_MostrarTotalBruto = new System.Windows.Forms.Label();
            this.label_MostrarPorcentajeDescuento = new System.Windows.Forms.Label();
            this.listaClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_ClienteApellido = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GuargarVenta
            // 
            this.button_GuargarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GuargarVenta.Location = new System.Drawing.Point(873, 456);
            this.button_GuargarVenta.Name = "button_GuargarVenta";
            this.button_GuargarVenta.Size = new System.Drawing.Size(146, 37);
            this.button_GuargarVenta.TabIndex = 1;
            this.button_GuargarVenta.Text = "Guardar Venta";
            this.toolTip1.SetToolTip(this.button_GuargarVenta, "Confirma la venta y la guarda");
            this.button_GuargarVenta.UseVisualStyleBackColor = true;
            this.button_GuargarVenta.Click += new System.EventHandler(this.button_GuargarVenta_Click);
            // 
            // comboBox_ClientesNombre
            // 
            this.comboBox_ClientesNombre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource1, "Apellido", true));
            this.comboBox_ClientesNombre.DataSource = this.listaClientesBindingSource;
            this.comboBox_ClientesNombre.DisplayMember = "Nombre";
            this.comboBox_ClientesNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClientesNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ClientesNombre.FormattingEnabled = true;
            this.comboBox_ClientesNombre.Location = new System.Drawing.Point(113, 33);
            this.comboBox_ClientesNombre.Name = "comboBox_ClientesNombre";
            this.comboBox_ClientesNombre.Size = new System.Drawing.Size(112, 24);
            this.comboBox_ClientesNombre.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox_ClientesNombre, "Seleccione nombre del cliente");
            this.comboBox_ClientesNombre.ValueMember = "Apellido";
            this.comboBox_ClientesNombre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox_ClientesNombre.Click += new System.EventHandler(this.comboBox_ClientesNombre_Click);
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataMember = "ListaClientes";
            this.listaClientesBindingSource.DataSource = this.empresaBindingSource;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Logica.cs.Empresa);
            // 
            // comboBox_Productos
            // 
            this.comboBox_Productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Productos.FormattingEnabled = true;
            this.comboBox_Productos.Location = new System.Drawing.Point(158, 80);
            this.comboBox_Productos.Name = "comboBox_Productos";
            this.comboBox_Productos.Size = new System.Drawing.Size(136, 24);
            this.comboBox_Productos.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBox_Productos, "Seleccione nombre del producto");
            this.comboBox_Productos.SelectedIndexChanged += new System.EventHandler(this.comboBox_Productos_SelectedIndexChanged);
            // 
            // button_AgregarCompra
            // 
            this.button_AgregarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AgregarCompra.Location = new System.Drawing.Point(903, 69);
            this.button_AgregarCompra.Name = "button_AgregarCompra";
            this.button_AgregarCompra.Size = new System.Drawing.Size(125, 43);
            this.button_AgregarCompra.TabIndex = 4;
            this.button_AgregarCompra.Text = "Agregar compra";
            this.toolTip1.SetToolTip(this.button_AgregarCompra, "Agrega producto a la lista de compras");
            this.button_AgregarCompra.UseVisualStyleBackColor = true;
            this.button_AgregarCompra.Click += new System.EventHandler(this.button_AgregarCompra_Click);
            // 
            // label_SeleccioneCliente
            // 
            this.label_SeleccioneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SeleccioneCliente.Location = new System.Drawing.Point(12, 9);
            this.label_SeleccioneCliente.Name = "label_SeleccioneCliente";
            this.label_SeleccioneCliente.Size = new System.Drawing.Size(79, 25);
            this.label_SeleccioneCliente.TabIndex = 5;
            this.label_SeleccioneCliente.Text = "Cliente:";
            // 
            // label_Producto
            // 
            this.label_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Producto.Location = new System.Drawing.Point(89, 81);
            this.label_Producto.Name = "label_Producto";
            this.label_Producto.Size = new System.Drawing.Size(67, 24);
            this.label_Producto.TabIndex = 5;
            this.label_Producto.Text = "Producto:";
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cantidad.Location = new System.Drawing.Point(308, 82);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(105, 24);
            this.label_Cantidad.TabIndex = 5;
            this.label_Cantidad.Text = "Cantidad:";
            // 
            // label_PrecioTotal
            // 
            this.label_PrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecioTotal.Location = new System.Drawing.Point(634, 445);
            this.label_PrecioTotal.Name = "label_PrecioTotal";
            this.label_PrecioTotal.Size = new System.Drawing.Size(105, 24);
            this.label_PrecioTotal.TabIndex = 5;
            this.label_PrecioTotal.Text = "Precio Total:";
            // 
            // label_MostrarPrecioTotal
            // 
            this.label_MostrarPrecioTotal.BackColor = System.Drawing.Color.White;
            this.label_MostrarPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPrecioTotal.Location = new System.Drawing.Point(626, 469);
            this.label_MostrarPrecioTotal.Name = "label_MostrarPrecioTotal";
            this.label_MostrarPrecioTotal.Size = new System.Drawing.Size(105, 24);
            this.label_MostrarPrecioTotal.TabIndex = 5;
            this.label_MostrarPrecioTotal.Click += new System.EventHandler(this.label_MostrarPrecioTotal_Click);
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cantidad.Location = new System.Drawing.Point(372, 80);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.ShortcutsEnabled = false;
            this.textBox_Cantidad.Size = new System.Drawing.Size(83, 22);
            this.textBox_Cantidad.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox_Cantidad, "Complete el cuadro con la cantidad");
            this.textBox_Cantidad.TextChanged += new System.EventHandler(this.textBox_Cantidad_TextChanged);
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label_Precio
            // 
            this.label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Precio.Location = new System.Drawing.Point(696, 81);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(56, 24);
            this.label_Precio.TabIndex = 7;
            this.label_Precio.Text = "Importe:";
            // 
            // label_MostrarPrecioProducto
            // 
            this.label_MostrarPrecioProducto.BackColor = System.Drawing.Color.White;
            this.label_MostrarPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPrecioProducto.Location = new System.Drawing.Point(754, 80);
            this.label_MostrarPrecioProducto.Name = "label_MostrarPrecioProducto";
            this.label_MostrarPrecioProducto.Size = new System.Drawing.Size(84, 21);
            this.label_MostrarPrecioProducto.TabIndex = 8;
            // 
            // label_Descuento
            // 
            this.label_Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descuento.Location = new System.Drawing.Point(393, 445);
            this.label_Descuento.Name = "label_Descuento";
            this.label_Descuento.Size = new System.Drawing.Size(78, 24);
            this.label_Descuento.TabIndex = 5;
            this.label_Descuento.Text = "Descuento:";
            this.label_Descuento.Click += new System.EventHandler(this.label_Descuento_Click);
            // 
            // label_MostrarDescuento
            // 
            this.label_MostrarDescuento.BackColor = System.Drawing.Color.White;
            this.label_MostrarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarDescuento.Location = new System.Drawing.Point(412, 469);
            this.label_MostrarDescuento.Name = "label_MostrarDescuento";
            this.label_MostrarDescuento.Size = new System.Drawing.Size(124, 37);
            this.label_MostrarDescuento.TabIndex = 5;
            this.label_MostrarDescuento.Click += new System.EventHandler(this.label_MostrarPrecioTotal_Click);
            // 
            // label_PrecioUnitario
            // 
            this.label_PrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecioUnitario.Location = new System.Drawing.Point(477, 82);
            this.label_PrecioUnitario.Name = "label_PrecioUnitario";
            this.label_PrecioUnitario.Size = new System.Drawing.Size(103, 24);
            this.label_PrecioUnitario.TabIndex = 7;
            this.label_PrecioUnitario.Text = "Precio unitario:";
            // 
            // label_MostrarPrecioUnitario
            // 
            this.label_MostrarPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.label_MostrarPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPrecioUnitario.Location = new System.Drawing.Point(576, 81);
            this.label_MostrarPrecioUnitario.Name = "label_MostrarPrecioUnitario";
            this.label_MostrarPrecioUnitario.Size = new System.Drawing.Size(84, 21);
            this.label_MostrarPrecioUnitario.TabIndex = 8;
            this.label_MostrarPrecioUnitario.Click += new System.EventHandler(this.label_MostrarPrecioUnitario_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(53, 34);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(60, 24);
            this.label_Nombre.TabIndex = 5;
            this.label_Nombre.Text = "Nombre:";
            // 
            // label_Apellido
            // 
            this.label_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apellido.Location = new System.Drawing.Point(229, 35);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(68, 24);
            this.label_Apellido.TabIndex = 5;
            this.label_Apellido.Text = "Apellido:";
            // 
            // dataGridView_Venta
            // 
            this.dataGridView_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Venta.Location = new System.Drawing.Point(167, 131);
            this.dataGridView_Venta.Name = "dataGridView_Venta";
            this.dataGridView_Venta.Size = new System.Drawing.Size(645, 301);
            this.dataGridView_Venta.TabIndex = 9;
            this.dataGridView_Venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_TotalBruto
            // 
            this.label_TotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalBruto.Location = new System.Drawing.Point(178, 445);
            this.label_TotalBruto.Name = "label_TotalBruto";
            this.label_TotalBruto.Size = new System.Drawing.Size(77, 24);
            this.label_TotalBruto.TabIndex = 5;
            this.label_TotalBruto.Text = "Total bruto:";
            this.label_TotalBruto.Click += new System.EventHandler(this.label_Descuento_Click);
            // 
            // label_MostrarTotalBruto
            // 
            this.label_MostrarTotalBruto.BackColor = System.Drawing.Color.White;
            this.label_MostrarTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarTotalBruto.Location = new System.Drawing.Point(164, 469);
            this.label_MostrarTotalBruto.Name = "label_MostrarTotalBruto";
            this.label_MostrarTotalBruto.Size = new System.Drawing.Size(105, 24);
            this.label_MostrarTotalBruto.TabIndex = 5;
            this.label_MostrarTotalBruto.Click += new System.EventHandler(this.label_MostrarPrecioTotal_Click);
            // 
            // label_MostrarPorcentajeDescuento
            // 
            this.label_MostrarPorcentajeDescuento.BackColor = System.Drawing.Color.White;
            this.label_MostrarPorcentajeDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarPorcentajeDescuento.Location = new System.Drawing.Point(362, 469);
            this.label_MostrarPorcentajeDescuento.Name = "label_MostrarPorcentajeDescuento";
            this.label_MostrarPorcentajeDescuento.Size = new System.Drawing.Size(44, 24);
            this.label_MostrarPorcentajeDescuento.TabIndex = 5;
            this.label_MostrarPorcentajeDescuento.Click += new System.EventHandler(this.label_MostrarPrecioTotal_Click);
            // 
            // listaClientesBindingSource1
            // 
            this.listaClientesBindingSource1.DataMember = "ListaClientes";
            this.listaClientesBindingSource1.DataSource = this.empresaBindingSource;
            // 
            // comboBox_ClienteApellido
            // 
            this.comboBox_ClienteApellido.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClientesBindingSource, "Apellido", true));
            this.comboBox_ClienteApellido.DataSource = this.listaClientesBindingSource;
            this.comboBox_ClienteApellido.DisplayMember = "Apellido";
            this.comboBox_ClienteApellido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClienteApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ClienteApellido.FormattingEnabled = true;
            this.comboBox_ClienteApellido.Location = new System.Drawing.Point(299, 33);
            this.comboBox_ClienteApellido.Name = "comboBox_ClienteApellido";
            this.comboBox_ClienteApellido.Size = new System.Drawing.Size(114, 24);
            this.comboBox_ClienteApellido.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox_ClienteApellido, "Seleccione apellido del cliente");
            this.comboBox_ClienteApellido.ValueMember = "Apellido";
            this.comboBox_ClienteApellido.SelectedIndexChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form_CargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1123, 509);
            this.Controls.Add(this.dataGridView_Venta);
            this.Controls.Add(this.label_MostrarPrecioUnitario);
            this.Controls.Add(this.label_PrecioUnitario);
            this.Controls.Add(this.label_MostrarPrecioProducto);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.label_MostrarTotalBruto);
            this.Controls.Add(this.label_MostrarDescuento);
            this.Controls.Add(this.label_TotalBruto);
            this.Controls.Add(this.label_MostrarPorcentajeDescuento);
            this.Controls.Add(this.label_MostrarPrecioTotal);
            this.Controls.Add(this.label_Descuento);
            this.Controls.Add(this.label_PrecioTotal);
            this.Controls.Add(this.label_Cantidad);
            this.Controls.Add(this.label_Producto);
            this.Controls.Add(this.label_Apellido);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_SeleccioneCliente);
            this.Controls.Add(this.button_AgregarCompra);
            this.Controls.Add(this.comboBox_Productos);
            this.Controls.Add(this.comboBox_ClienteApellido);
            this.Controls.Add(this.comboBox_ClientesNombre);
            this.Controls.Add(this.button_GuargarVenta);
            this.Name = "Form_CargaVentas";
            this.Text = "Form_CargaVentas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CargaVentas_FormClosed);
            this.Load += new System.EventHandler(this.Form_CargaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_GuargarVenta;
        private System.Windows.Forms.ComboBox comboBox_ClientesNombre;
        private System.Windows.Forms.ComboBox comboBox_Productos;
        private System.Windows.Forms.Button button_AgregarCompra;
        private System.Windows.Forms.Label label_SeleccioneCliente;
        private System.Windows.Forms.Label label_Producto;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.Label label_PrecioTotal;
        private System.Windows.Forms.Label label_MostrarPrecioTotal;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.Label label_MostrarPrecioProducto;
        private System.Windows.Forms.Label label_Descuento;
        private System.Windows.Forms.Label label_MostrarDescuento;
        private System.Windows.Forms.Label label_PrecioUnitario;
        private System.Windows.Forms.Label label_MostrarPrecioUnitario;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.DataGridView dataGridView_Venta;
        private System.Windows.Forms.Label label_TotalBruto;
        private System.Windows.Forms.Label label_MostrarTotalBruto;
        private System.Windows.Forms.Label label_MostrarPorcentajeDescuento;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.BindingSource listaClientesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox_ClienteApellido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}