namespace Tp_WindowsForms
{
    partial class Form_GrillaVenta
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
            this.dataGridView_GrillaVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeDescuentoAplicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteAsociadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_cliente = new System.Windows.Forms.Label();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GrillaVenta
            // 
            this.dataGridView_GrillaVenta.AllowUserToAddRows = false;
            this.dataGridView_GrillaVenta.AutoGenerateColumns = false;
            this.dataGridView_GrillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.FechaVenta,
            this.PorcentajeDescuentoAplicado,
            this.TotalVenta,
            this.Cliente,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn,
            this.totalVentaDataGridViewTextBoxColumn,
            this.clienteAsociadoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.dataGridView_GrillaVenta.DataSource = this.listaVentasBindingSource1;
            this.dataGridView_GrillaVenta.Location = new System.Drawing.Point(37, 81);
            this.dataGridView_GrillaVenta.MultiSelect = false;
            this.dataGridView_GrillaVenta.Name = "dataGridView_GrillaVenta";
            this.dataGridView_GrillaVenta.Size = new System.Drawing.Size(1184, 412);
            this.dataGridView_GrillaVenta.TabIndex = 1;
            this.dataGridView_GrillaVenta.VirtualMode = true;
            this.dataGridView_GrillaVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GrillaVenta_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Venta";
            this.Codigo.Name = "Codigo";
            // 
            // FechaVenta
            // 
            this.FechaVenta.DataPropertyName = "FechaVenta";
            this.FechaVenta.HeaderText = "Fecha";
            this.FechaVenta.Name = "FechaVenta";
            // 
            // PorcentajeDescuentoAplicado
            // 
            this.PorcentajeDescuentoAplicado.DataPropertyName = "PorcentajeDescuentoAplicado";
            this.PorcentajeDescuentoAplicado.HeaderText = "Descuento";
            this.PorcentajeDescuentoAplicado.Name = "PorcentajeDescuentoAplicado";
            // 
            // TotalVenta
            // 
            this.TotalVenta.DataPropertyName = "TotalVenta";
            this.TotalVenta.HeaderText = "Monto Total";
            this.TotalVenta.Name = "TotalVenta";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "ClienteAsociado";
            this.Cliente.HeaderText = "Cliente asociado";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 120;
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha de venta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.Width = 120;
            // 
            // porcentajeDescuentoAplicadoDataGridViewTextBoxColumn
            // 
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeDescuentoAplicado";
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.HeaderText = "Porcentaje descuento aplicado";
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.Name = "porcentajeDescuentoAplicadoDataGridViewTextBoxColumn";
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalVentaDataGridViewTextBoxColumn
            // 
            this.totalVentaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenta";
            this.totalVentaDataGridViewTextBoxColumn.HeaderText = "Total venta";
            this.totalVentaDataGridViewTextBoxColumn.Name = "totalVentaDataGridViewTextBoxColumn";
            // 
            // clienteAsociadoDataGridViewTextBoxColumn
            // 
            this.clienteAsociadoDataGridViewTextBoxColumn.DataPropertyName = "ClienteAsociado";
            this.clienteAsociadoDataGridViewTextBoxColumn.HeaderText = "Cliente asociado";
            this.clienteAsociadoDataGridViewTextBoxColumn.Name = "clienteAsociadoDataGridViewTextBoxColumn";
            this.clienteAsociadoDataGridViewTextBoxColumn.Width = 120;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // listaVentasBindingSource1
            // 
            this.listaVentasBindingSource1.DataMember = "ListaVentas";
            this.listaVentasBindingSource1.DataSource = this.empresaBindingSource;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Logica.cs.Empresa);
            // 
            // listaVentasBindingSource
            // 
            this.listaVentasBindingSource.DataMember = "ListaVentas";
            this.listaVentasBindingSource.DataSource = this.empresaBindingSource;
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.DataSource = this.listaClientesBindingSource;
            this.comboBox_cliente.DisplayMember = "Apellido";
            this.comboBox_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(37, 40);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(201, 24);
            this.comboBox_cliente.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox_cliente, "Seleccione apellido del cliente");
            this.comboBox_cliente.ValueMember = "Codigo";
            this.comboBox_cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_cliente_SelectedIndexChanged);
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataMember = "ListaClientes";
            this.listaClientesBindingSource.DataSource = this.empresaBindingSource;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cliente.Location = new System.Drawing.Point(37, 18);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(102, 16);
            this.label_cliente.TabIndex = 3;
            this.label_cliente.Text = "Filtro por cliente";
            // 
            // button_nuevo
            // 
            this.button_nuevo.Location = new System.Drawing.Point(1028, 31);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(136, 33);
            this.button_nuevo.TabIndex = 4;
            this.button_nuevo.Text = "Nueva Venta";
            this.toolTip1.SetToolTip(this.button_nuevo, "Carga una nueva venta");
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // Form_GrillaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 533);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.dataGridView_GrillaVenta);
            this.Name = "Form_GrillaVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_GrillaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GrillaVenta;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.BindingSource listaVentasBindingSource;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.BindingSource listaVentasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeDescuentoAplicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDescuentoAplicadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteAsociadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}