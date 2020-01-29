namespace Tp_WindowsForms
{
    partial class Form_GrillaClientes
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
            this.dataGridView_GrillaClientes = new System.Windows.Forms.DataGridView();
            this.listaClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formMenuPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMenuPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GrillaClientes
            // 
            this.dataGridView_GrillaClientes.AllowUserToAddRows = false;
            this.dataGridView_GrillaClientes.AutoGenerateColumns = false;
            this.dataGridView_GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Email,
            this.localidadDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.Tipo});
            this.dataGridView_GrillaClientes.DataSource = this.listaClientesBindingSource1;
            this.dataGridView_GrillaClientes.Location = new System.Drawing.Point(180, 29);
            this.dataGridView_GrillaClientes.Name = "dataGridView_GrillaClientes";
            this.dataGridView_GrillaClientes.ReadOnly = true;
            this.dataGridView_GrillaClientes.Size = new System.Drawing.Size(786, 451);
            this.dataGridView_GrillaClientes.TabIndex = 0;
            this.dataGridView_GrillaClientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GrillaClientes_RowEnter);
            this.dataGridView_GrillaClientes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_GrillaClientes_RowStateChanged);
            // 
            // listaClientesBindingSource1
            // 
            this.listaClientesBindingSource1.DataMember = "ListaClientes";
            this.listaClientesBindingSource1.DataSource = this.empresaBindingSource;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Logica.cs.Empresa);
            // 
            // button_Modificar
            // 
            this.button_Modificar.Location = new System.Drawing.Point(11, 119);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(141, 33);
            this.button_Modificar.TabIndex = 1;
            this.button_Modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.button_Modificar, "Modifica un cliente seleccionado");
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.button1, "Elimina un cliente seleccionado");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataMember = "ListaClientes";
            this.listaClientesBindingSource.DataSource = this.empresaBindingSource;
            // 
            // formMenuPrincipalBindingSource
            // 
            this.formMenuPrincipalBindingSource.DataSource = typeof(Tp_WindowsForms.Form_MenuPrincipal);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(12, 55);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(140, 33);
            this.Nuevo.TabIndex = 3;
            this.Nuevo.Text = "Nuevo";
            this.toolTip1.SetToolTip(this.Nuevo, "Carga un nuevo cliente");
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 140;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 50;
            // 
            // Form_GrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(991, 504);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.dataGridView_GrillaClientes);
            this.Name = "Form_GrillaClientes";
            this.Text = "Form_GrillaClientes";
            this.Load += new System.EventHandler(this.Form_GrillaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMenuPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GrillaClientes;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingSource listaClientesBindingSource1;
        private System.Windows.Forms.BindingSource formMenuPrincipalBindingSource;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}