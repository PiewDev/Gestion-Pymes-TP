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
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.label_cliente = new System.Windows.Forms.Label();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteAsociadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GrillaVenta
            // 
            this.dataGridView_GrillaVenta.AllowUserToAddRows = false;
            this.dataGridView_GrillaVenta.AutoGenerateColumns = false;
            this.dataGridView_GrillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn,
            this.totalVentaDataGridViewTextBoxColumn,
            this.clienteAsociadoDataGridViewTextBoxColumn});
            this.dataGridView_GrillaVenta.DataSource = this.listaVentasBindingSource1;
            this.dataGridView_GrillaVenta.Location = new System.Drawing.Point(37, 83);
            this.dataGridView_GrillaVenta.Name = "dataGridView_GrillaVenta";
            this.dataGridView_GrillaVenta.Size = new System.Drawing.Size(845, 412);
            this.dataGridView_GrillaVenta.TabIndex = 1;
            this.dataGridView_GrillaVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GrillaVenta_CellContentClick);
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
            this.comboBox_cliente.DisplayMember = "Nombre";
            this.comboBox_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(37, 40);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(201, 21);
            this.comboBox_cliente.TabIndex = 2;
            this.comboBox_cliente.ValueMember = "Apellido";
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Location = new System.Drawing.Point(37, 21);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(81, 13);
            this.label_cliente.TabIndex = 3;
            this.label_cliente.Text = "Filtro por cliente";
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataMember = "ListaClientes";
            this.listaClientesBindingSource.DataSource = this.empresaBindingSource;
            // 
            // listaVentasBindingSource1
            // 
            this.listaVentasBindingSource1.DataMember = "ListaVentas";
            this.listaVentasBindingSource1.DataSource = this.empresaBindingSource;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            // 
            // porcentajeDescuentoAplicadoDataGridViewTextBoxColumn
            // 
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeDescuentoAplicado";
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.HeaderText = "PorcentajeDescuentoAplicado";
            this.porcentajeDescuentoAplicadoDataGridViewTextBoxColumn.Name = "porcentajeDescuentoAplicadoDataGridViewTextBoxColumn";
            // 
            // totalVentaDataGridViewTextBoxColumn
            // 
            this.totalVentaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenta";
            this.totalVentaDataGridViewTextBoxColumn.HeaderText = "TotalVenta";
            this.totalVentaDataGridViewTextBoxColumn.Name = "totalVentaDataGridViewTextBoxColumn";
            // 
            // clienteAsociadoDataGridViewTextBoxColumn
            // 
            this.clienteAsociadoDataGridViewTextBoxColumn.DataPropertyName = "ClienteAsociado";
            this.clienteAsociadoDataGridViewTextBoxColumn.HeaderText = "ClienteAsociado";
            this.clienteAsociadoDataGridViewTextBoxColumn.Name = "clienteAsociadoDataGridViewTextBoxColumn";
            // 
            // Form_GrillaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 533);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.dataGridView_GrillaVenta);
            this.Name = "Form_GrillaVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_GrillaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDescuentoAplicadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteAsociadoDataGridViewTextBoxColumn;
    }
}