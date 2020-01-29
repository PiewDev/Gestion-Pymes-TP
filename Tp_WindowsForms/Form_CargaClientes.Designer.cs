namespace Tp_WindowsForms
{
    partial class Form_CargaClientes
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
            this.label_CodigoCliente = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label_FechaNacimiento = new System.Windows.Forms.Label();
            this.label_Localidad = new System.Windows.Forms.Label();
            this.label_Provincia = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_Telefono = new System.Windows.Forms.Label();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.label_TipoCliente = new System.Windows.Forms.Label();
            this.comboBox_TipoCliente = new System.Windows.Forms.ComboBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Provincia = new System.Windows.Forms.ComboBox();
            this.listaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listaProvinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Localidad = new System.Windows.Forms.ComboBox();
            this.listaLocalidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaLocalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProvinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLocalidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLocalidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CodigoCliente
            // 
            this.label_CodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CodigoCliente.Location = new System.Drawing.Point(38, 68);
            this.label_CodigoCliente.Name = "label_CodigoCliente";
            this.label_CodigoCliente.Size = new System.Drawing.Size(180, 23);
            this.label_CodigoCliente.TabIndex = 0;
            this.label_CodigoCliente.Text = "Codigo:";
            // 
            // label_Nombre
            // 
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(38, 101);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(180, 23);
            this.label_Nombre.TabIndex = 0;
            this.label_Nombre.Text = "Nombre:";
            // 
            // label_Apellido
            // 
            this.label_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apellido.Location = new System.Drawing.Point(38, 130);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(180, 23);
            this.label_Apellido.TabIndex = 0;
            this.label_Apellido.Text = "Apellido:";
            // 
            // label_FechaNacimiento
            // 
            this.label_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaNacimiento.Location = new System.Drawing.Point(38, 160);
            this.label_FechaNacimiento.Name = "label_FechaNacimiento";
            this.label_FechaNacimiento.Size = new System.Drawing.Size(180, 23);
            this.label_FechaNacimiento.TabIndex = 0;
            this.label_FechaNacimiento.Text = "Fecha de nacimineto:";
            // 
            // label_Localidad
            // 
            this.label_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Localidad.Location = new System.Drawing.Point(38, 215);
            this.label_Localidad.Name = "label_Localidad";
            this.label_Localidad.Size = new System.Drawing.Size(180, 23);
            this.label_Localidad.TabIndex = 0;
            this.label_Localidad.Text = "Localidad:";
            // 
            // label_Provincia
            // 
            this.label_Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Provincia.Location = new System.Drawing.Point(38, 187);
            this.label_Provincia.Name = "label_Provincia";
            this.label_Provincia.Size = new System.Drawing.Size(180, 23);
            this.label_Provincia.TabIndex = 0;
            this.label_Provincia.Text = "Provincia:";
            // 
            // label_Mail
            // 
            this.label_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mail.Location = new System.Drawing.Point(38, 272);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(160, 23);
            this.label_Mail.TabIndex = 1;
            this.label_Mail.Text = "Correo electronico:";
            // 
            // label_Telefono
            // 
            this.label_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telefono.Location = new System.Drawing.Point(38, 245);
            this.label_Telefono.Name = "label_Telefono";
            this.label_Telefono.Size = new System.Drawing.Size(100, 23);
            this.label_Telefono.TabIndex = 1;
            this.label_Telefono.Text = "Telefono:";
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Correo.Location = new System.Drawing.Point(273, 271);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.ShortcutsEnabled = false;
            this.textBox_Correo.Size = new System.Drawing.Size(261, 22);
            this.textBox_Correo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_Correo, "Complete el cuadro con un correo electronico");
            this.textBox_Correo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Correo_KeyPress);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Telefono.Location = new System.Drawing.Point(273, 244);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.ShortcutsEnabled = false;
            this.textBox_Telefono.Size = new System.Drawing.Size(261, 22);
            this.textBox_Telefono.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_Telefono, "Complete el cuadro con un numero de telefono");
            this.textBox_Telefono.TextChanged += new System.EventHandler(this.textBox_Telefono_TextChanged);
            this.textBox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefono_KeyPress);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Apellido.Location = new System.Drawing.Point(273, 129);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(261, 22);
            this.textBox_Apellido.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_Apellido, "Complete el cuadro con un apellido");
            this.textBox_Apellido.TextChanged += new System.EventHandler(this.textBox_Apellido_TextChanged);
            this.textBox_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Apellido_KeyPress);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(273, 100);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(261, 22);
            this.textBox_Nombre.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_Nombre, "Complete el cuadro con un nombre");
            this.textBox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nombre_KeyPress);
            // 
            // label_Codigo
            // 
            this.label_Codigo.BackColor = System.Drawing.Color.White;
            this.label_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Codigo.Location = new System.Drawing.Point(273, 73);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(261, 18);
            this.label_Codigo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.label_Codigo, "Codigo del cliente que se esta cargando");
            this.label_Codigo.Click += new System.EventHandler(this.label_Codigo_Click);
            // 
            // label_TipoCliente
            // 
            this.label_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TipoCliente.Location = new System.Drawing.Point(38, 299);
            this.label_TipoCliente.Name = "label_TipoCliente";
            this.label_TipoCliente.Size = new System.Drawing.Size(160, 23);
            this.label_TipoCliente.TabIndex = 1;
            this.label_TipoCliente.Text = "Tipo de cliente:";
            // 
            // comboBox_TipoCliente
            // 
            this.comboBox_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TipoCliente.FormattingEnabled = true;
            this.comboBox_TipoCliente.Items.AddRange(new object[] {
            "Regular",
            "Vip"});
            this.comboBox_TipoCliente.Location = new System.Drawing.Point(273, 298);
            this.comboBox_TipoCliente.Name = "comboBox_TipoCliente";
            this.comboBox_TipoCliente.Size = new System.Drawing.Size(261, 24);
            this.comboBox_TipoCliente.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBox_TipoCliente, "Seleccione tipo de cliente");
            this.comboBox_TipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoCliente_SelectedIndexChanged);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(671, 331);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(155, 46);
            this.button_Guardar.TabIndex = 7;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // dateTimePicker_Fecha
            // 
            this.dateTimePicker_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Fecha.Location = new System.Drawing.Point(273, 159);
            this.dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            this.dateTimePicker_Fecha.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker_Fecha.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dateTimePicker_Fecha, "Seleccione fecha de nacimineto");
            // 
            // comboBox_Provincia
            // 
            this.comboBox_Provincia.DataSource = this.listaBindingSource2;
            this.comboBox_Provincia.DisplayMember = "Nombre";
            this.comboBox_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Provincia.FormattingEnabled = true;
            this.comboBox_Provincia.Location = new System.Drawing.Point(273, 187);
            this.comboBox_Provincia.Name = "comboBox_Provincia";
            this.comboBox_Provincia.Size = new System.Drawing.Size(261, 24);
            this.comboBox_Provincia.TabIndex = 9;
            this.toolTip1.SetToolTip(this.comboBox_Provincia, "Seleccione provincia");
            this.comboBox_Provincia.ValueMember = "Nombre";
            this.comboBox_Provincia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox_Provincia.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox_Provincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // listaBindingSource2
            // 
            this.listaBindingSource2.DataMember = "Lista";
            this.listaBindingSource2.DataSource = this.listaProvinciasBindingSource;
            // 
            // listaProvinciasBindingSource
            // 
            this.listaProvinciasBindingSource.DataSource = typeof(Logica.cs.ListaProvincias);
            // 
            // listaBindingSource
            // 
            this.listaBindingSource.DataMember = "Lista";
            this.listaBindingSource.DataSource = this.listaProvinciasBindingSource;
            // 
            // comboBox_Localidad
            // 
            this.comboBox_Localidad.DataSource = this.listaLocalidadesBindingSource1;
            this.comboBox_Localidad.DisplayMember = "Nombre";
            this.comboBox_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Localidad.FormattingEnabled = true;
            this.comboBox_Localidad.Location = new System.Drawing.Point(273, 215);
            this.comboBox_Localidad.Name = "comboBox_Localidad";
            this.comboBox_Localidad.Size = new System.Drawing.Size(261, 24);
            this.comboBox_Localidad.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBox_Localidad, "Seleccione localidad");
            this.comboBox_Localidad.ValueMember = "Nombre";
            this.comboBox_Localidad.SelectedIndexChanged += new System.EventHandler(this.comboBox_Localidad_SelectedIndexChanged);
            // 
            // listaLocalidadesBindingSource1
            // 
            this.listaLocalidadesBindingSource1.DataMember = "Lista_Localidades";
            this.listaLocalidadesBindingSource1.DataSource = this.listaBindingSource2;
            // 
            // listaBindingSource1
            // 
            this.listaBindingSource1.DataMember = "Lista";
            this.listaBindingSource1.DataSource = this.listaProvinciasBindingSource;
            // 
            // listaLocalidadesBindingSource
            // 
            this.listaLocalidadesBindingSource.DataMember = "Lista_Localidades";
            this.listaLocalidadesBindingSource.DataSource = this.listaBindingSource1;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form_CargaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 389);
            this.Controls.Add(this.comboBox_Localidad);
            this.Controls.Add(this.comboBox_Provincia);
            this.Controls.Add(this.dateTimePicker_Fecha);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.comboBox_TipoCliente);
            this.Controls.Add(this.label_Codigo);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_Correo);
            this.Controls.Add(this.label_Telefono);
            this.Controls.Add(this.label_TipoCliente);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.label_Provincia);
            this.Controls.Add(this.label_FechaNacimiento);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Localidad);
            this.Controls.Add(this.label_Apellido);
            this.Controls.Add(this.label_CodigoCliente);
            this.Name = "Form_CargaClientes";
            this.Text = "Form_CargaClientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CargaClientes_FormClosed);
            this.Load += new System.EventHandler(this.Form_CargaClientes_Load);
            this.Shown += new System.EventHandler(this.Form_CargaClientes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProvinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLocalidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLocalidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CodigoCliente;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label_FechaNacimiento;
        private System.Windows.Forms.Label label_Localidad;
        private System.Windows.Forms.Label label_Provincia;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_Telefono;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Codigo;
        private System.Windows.Forms.Label label_TipoCliente;
        private System.Windows.Forms.ComboBox comboBox_TipoCliente;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.ComboBox comboBox_Provincia;
        private System.Windows.Forms.ComboBox comboBox_Localidad;
        private System.Windows.Forms.BindingSource listaBindingSource;
        private System.Windows.Forms.BindingSource listaProvinciasBindingSource;
        private System.Windows.Forms.BindingSource listaLocalidadesBindingSource;
        private System.Windows.Forms.BindingSource listaBindingSource1;
        private System.Windows.Forms.BindingSource listaBindingSource2;
        private System.Windows.Forms.BindingSource listaLocalidadesBindingSource1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}