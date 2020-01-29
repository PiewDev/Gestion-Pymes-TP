namespace Tp_WindowsForms
{
    partial class Form_GrillaProductos
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
            this.dataGridView_GrillaProductos = new System.Windows.Forms.DataGridView();
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_modif = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_nuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GrillaProductos
            // 
            this.dataGridView_GrillaProductos.AllowUserToAddRows = false;
            this.dataGridView_GrillaProductos.AllowUserToDeleteRows = false;
            this.dataGridView_GrillaProductos.AllowUserToOrderColumns = true;
            this.dataGridView_GrillaProductos.AutoGenerateColumns = false;
            this.dataGridView_GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.cantidadStockDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.dataGridView_GrillaProductos.DataSource = this.listaProductosBindingSource;
            this.dataGridView_GrillaProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_GrillaProductos.Location = new System.Drawing.Point(193, 12);
            this.dataGridView_GrillaProductos.Name = "dataGridView_GrillaProductos";
            this.dataGridView_GrillaProductos.ReadOnly = true;
            this.dataGridView_GrillaProductos.Size = new System.Drawing.Size(643, 499);
            this.dataGridView_GrillaProductos.TabIndex = 0;
            this.dataGridView_GrillaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GrillaProductos_CellContentClick);
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataMember = "ListaProductos";
            this.listaProductosBindingSource.DataSource = this.empresaBindingSource;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Logica.cs.Empresa);
            // 
            // button_modif
            // 
            this.button_modif.Location = new System.Drawing.Point(12, 136);
            this.button_modif.Name = "button_modif";
            this.button_modif.Size = new System.Drawing.Size(125, 35);
            this.button_modif.TabIndex = 1;
            this.button_modif.Text = "Modificar";
            this.toolTip1.SetToolTip(this.button_modif, "Modifica un producto seleccionado");
            this.button_modif.UseVisualStyleBackColor = true;
            this.button_modif.Click += new System.EventHandler(this.button_modif_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.button1, "Elimina un producto seleccionado");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_elim_Click);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(Logica.cs.Productos);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Tp_WindowsForms.Program);
            // 
            // button_nuevo
            // 
            this.button_nuevo.Location = new System.Drawing.Point(13, 71);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(124, 35);
            this.button_nuevo.TabIndex = 3;
            this.button_nuevo.Text = "Nuevo";
            this.toolTip1.SetToolTip(this.button_nuevo, "Carga un nuevo producto");
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "TipoProducto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreProducto";
            this.Nombre.HeaderText = "Nombre del producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // cantidadStockDataGridViewTextBoxColumn
            // 
            this.cantidadStockDataGridViewTextBoxColumn.DataPropertyName = "CantidadStock";
            this.cantidadStockDataGridViewTextBoxColumn.HeaderText = "Cantidad en  stock";
            this.cantidadStockDataGridViewTextBoxColumn.Name = "cantidadStockDataGridViewTextBoxColumn";
            this.cantidadStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadStockDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_GrillaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(979, 523);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_modif);
            this.Controls.Add(this.dataGridView_GrillaProductos);
            this.Name = "Form_GrillaProductos";
            this.Text = "Form_GrillaProductos";
            this.Load += new System.EventHandler(this.Form_GrillaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GrillaProductos;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button button_modif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
    }
}