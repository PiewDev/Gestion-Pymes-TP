namespace Tp_WindowsForms
{
    partial class Form_GrillaPresupuestos
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
            this.label_Cliente = new System.Windows.Forms.Label();
            this.dataGridView_GrillaPresuspuestos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPresupuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDeValidezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Nombre = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Conver = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.comboBox_Apellido = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaPresuspuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cliente.Location = new System.Drawing.Point(12, 18);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(62, 20);
            this.label_Cliente.TabIndex = 0;
            this.label_Cliente.Text = "Cliente:";
            // 
            // dataGridView_GrillaPresuspuestos
            // 
            this.dataGridView_GrillaPresuspuestos.AutoGenerateColumns = false;
            this.dataGridView_GrillaPresuspuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaPresuspuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.fechaPresupuestoDataGridViewTextBoxColumn,
            this.diasDeValidezDataGridViewTextBoxColumn,
            this.totalVentaDataGridViewTextBoxColumn});
            this.dataGridView_GrillaPresuspuestos.DataSource = this.presupuestosBindingSource;
            this.dataGridView_GrillaPresuspuestos.Location = new System.Drawing.Point(237, 106);
            this.dataGridView_GrillaPresuspuestos.Name = "dataGridView_GrillaPresuspuestos";
            this.dataGridView_GrillaPresuspuestos.Size = new System.Drawing.Size(592, 451);
            this.dataGridView_GrillaPresuspuestos.TabIndex = 1;
            this.dataGridView_GrillaPresuspuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GrillaPresuspuestos_CellContentClick);
            this.dataGridView_GrillaPresuspuestos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_GrillaPresuspuestos_RowHeaderMouseClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // fechaPresupuestoDataGridViewTextBoxColumn
            // 
            this.fechaPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "FechaPresupuesto";
            this.fechaPresupuestoDataGridViewTextBoxColumn.HeaderText = "Fecha de presupuesto";
            this.fechaPresupuestoDataGridViewTextBoxColumn.Name = "fechaPresupuestoDataGridViewTextBoxColumn";
            this.fechaPresupuestoDataGridViewTextBoxColumn.Width = 170;
            // 
            // diasDeValidezDataGridViewTextBoxColumn
            // 
            this.diasDeValidezDataGridViewTextBoxColumn.DataPropertyName = "DiasDeValidez";
            this.diasDeValidezDataGridViewTextBoxColumn.HeaderText = "Dias de validez";
            this.diasDeValidezDataGridViewTextBoxColumn.Name = "diasDeValidezDataGridViewTextBoxColumn";
            this.diasDeValidezDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalVentaDataGridViewTextBoxColumn
            // 
            this.totalVentaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenta";
            this.totalVentaDataGridViewTextBoxColumn.HeaderText = "Total venta";
            this.totalVentaDataGridViewTextBoxColumn.Name = "totalVentaDataGridViewTextBoxColumn";
            this.totalVentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataSource = typeof(Logica.cs.Presupuestos);
            // 
            // comboBox_Nombre
            // 
            this.comboBox_Nombre.DataSource = this.clientesBindingSource;
            this.comboBox_Nombre.DisplayMember = "Nombre";
            this.comboBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Nombre.FormattingEnabled = true;
            this.comboBox_Nombre.Location = new System.Drawing.Point(149, 45);
            this.comboBox_Nombre.Name = "comboBox_Nombre";
            this.comboBox_Nombre.Size = new System.Drawing.Size(154, 24);
            this.comboBox_Nombre.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox_Nombre, "Seleccione un apellido");
            this.comboBox_Nombre.ValueMember = "Apellido";
            this.comboBox_Nombre.SelectedIndexChanged += new System.EventHandler(this.comboBox_FiltroCliente_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(Logica.cs.Clientes);
            // 
            // button_Conver
            // 
            this.button_Conver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Conver.Location = new System.Drawing.Point(25, 174);
            this.button_Conver.Name = "button_Conver";
            this.button_Conver.Size = new System.Drawing.Size(166, 35);
            this.button_Conver.TabIndex = 3;
            this.button_Conver.Text = "Convertir a venta";
            this.toolTip1.SetToolTip(this.button_Conver, "Convierte el presupuesto seleccionado en venta");
            this.button_Conver.UseVisualStyleBackColor = true;
            this.button_Conver.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_nuevo
            // 
            this.button_nuevo.Location = new System.Drawing.Point(791, 38);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(150, 26);
            this.button_nuevo.TabIndex = 4;
            this.button_nuevo.Text = "Nuevo Presupuesto";
            this.toolTip1.SetToolTip(this.button_nuevo, "Carga una nueva venta");
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(83, 48);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(60, 16);
            this.label_Nombre.TabIndex = 0;
            this.label_Nombre.Text = "Nombre:";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apellido.Location = new System.Drawing.Point(309, 48);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(61, 16);
            this.label_Apellido.TabIndex = 0;
            this.label_Apellido.Text = "Apellido:";
            // 
            // comboBox_Apellido
            // 
            this.comboBox_Apellido.DataSource = this.clientesBindingSource;
            this.comboBox_Apellido.DisplayMember = "Apellido";
            this.comboBox_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Apellido.FormattingEnabled = true;
            this.comboBox_Apellido.Location = new System.Drawing.Point(376, 45);
            this.comboBox_Apellido.Name = "comboBox_Apellido";
            this.comboBox_Apellido.Size = new System.Drawing.Size(154, 24);
            this.comboBox_Apellido.TabIndex = 5;
            this.comboBox_Apellido.ValueMember = "Codigo";
            this.comboBox_Apellido.SelectedIndexChanged += new System.EventHandler(this.comboBox_Apellido_SelectedIndexChanged);
            // 
            // Form_GrillaPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 588);
            this.Controls.Add(this.comboBox_Apellido);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.button_Conver);
            this.Controls.Add(this.comboBox_Nombre);
            this.Controls.Add(this.dataGridView_GrillaPresuspuestos);
            this.Controls.Add(this.label_Apellido);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Cliente);
            this.Name = "Form_GrillaPresupuestos";
            this.Text = "Form_GrillaPresupuestos";
            this.Load += new System.EventHandler(this.Form_GrillaPresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaPresuspuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.DataGridView dataGridView_GrillaPresuspuestos;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private System.Windows.Forms.ComboBox comboBox_Nombre;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.Button button_Conver;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.ComboBox comboBox_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPresupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDeValidezDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn;
    }
}