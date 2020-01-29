namespace Tp_WindowsForms
{
    partial class Form_CargaProductos
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
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_CantidadStock = new System.Windows.Forms.Label();
            this.label_PrecioUnitario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Nombree = new System.Windows.Forms.Label();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.textBox_CantidadStock = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.label_IDcorrelativo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_Nombre
            // 
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(12, 58);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(110, 29);
            this.label_Nombre.TabIndex = 0;
            // 
            // label_CantidadStock
            // 
            this.label_CantidadStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CantidadStock.Location = new System.Drawing.Point(12, 90);
            this.label_CantidadStock.Name = "label_CantidadStock";
            this.label_CantidadStock.Size = new System.Drawing.Size(158, 29);
            this.label_CantidadStock.TabIndex = 0;
            this.label_CantidadStock.Text = "Cantidad en stock:";
            // 
            // label_PrecioUnitario
            // 
            this.label_PrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecioUnitario.Location = new System.Drawing.Point(12, 125);
            this.label_PrecioUnitario.Name = "label_PrecioUnitario";
            this.label_PrecioUnitario.Size = new System.Drawing.Size(170, 29);
            this.label_PrecioUnitario.TabIndex = 0;
            this.label_PrecioUnitario.Text = "Precio unitario:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de producto";
            // 
            // label_ID
            // 
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(12, 191);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(110, 29);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID:";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descripcion.Location = new System.Drawing.Point(12, 225);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(110, 29);
            this.label_Descripcion.TabIndex = 0;
            this.label_Descripcion.Text = "Descripcion:";
            // 
            // label_Nombree
            // 
            this.label_Nombree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombree.Location = new System.Drawing.Point(12, 58);
            this.label_Nombree.Name = "label_Nombree";
            this.label_Nombree.Size = new System.Drawing.Size(110, 29);
            this.label_Nombree.TabIndex = 0;
            this.label_Nombree.Text = "Nombre:";
            this.label_Nombree.Click += new System.EventHandler(this.label_Click);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Descripcion.Location = new System.Drawing.Point(212, 232);
            this.textBox_Descripcion.Multiline = true;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Descripcion.Size = new System.Drawing.Size(296, 78);
            this.textBox_Descripcion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_Descripcion, "Complete el cuadro con una descripcion");
            this.textBox_Descripcion.TextChanged += new System.EventHandler(this.textBox_Descripcion_TextChanged);
            // 
            // textBox_PrecioUnitario
            // 
            this.textBox_PrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrecioUnitario.Location = new System.Drawing.Point(212, 125);
            this.textBox_PrecioUnitario.Name = "textBox_PrecioUnitario";
            this.textBox_PrecioUnitario.ShortcutsEnabled = false;
            this.textBox_PrecioUnitario.Size = new System.Drawing.Size(296, 22);
            this.textBox_PrecioUnitario.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_PrecioUnitario, "Complete el campo con un precio");
            this.textBox_PrecioUnitario.TextChanged += new System.EventHandler(this.textBox_PrecioUnitario_TextChanged);
            this.textBox_PrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PrecioUnitario_KeyPress);
            // 
            // textBox_CantidadStock
            // 
            this.textBox_CantidadStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CantidadStock.Location = new System.Drawing.Point(212, 90);
            this.textBox_CantidadStock.Name = "textBox_CantidadStock";
            this.textBox_CantidadStock.ShortcutsEnabled = false;
            this.textBox_CantidadStock.Size = new System.Drawing.Size(296, 22);
            this.textBox_CantidadStock.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_CantidadStock, "Complete el cuadro con la cantidad de stock del producto");
            this.textBox_CantidadStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CantidadStock_KeyPress);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(212, 58);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(296, 22);
            this.textBox_Nombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_Nombre, "Complete el cuadro con un nombre");
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            this.textBox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nombre_KeyPress);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(629, 358);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(142, 41);
            this.button_Guardar.TabIndex = 2;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // label_IDcorrelativo
            // 
            this.label_IDcorrelativo.BackColor = System.Drawing.SystemColors.Control;
            this.label_IDcorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDcorrelativo.Location = new System.Drawing.Point(212, 191);
            this.label_IDcorrelativo.Name = "label_IDcorrelativo";
            this.label_IDcorrelativo.Size = new System.Drawing.Size(296, 23);
            this.label_IDcorrelativo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.label_IDcorrelativo, "ID del producto que se esta cargando");
            // 
            // Form_CargaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 411);
            this.Controls.Add(this.label_IDcorrelativo);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_CantidadStock);
            this.Controls.Add(this.textBox_PrecioUnitario);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Nombree);
            this.Controls.Add(this.label_PrecioUnitario);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_CantidadStock);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Nombre);
            this.Name = "Form_CargaProductos";
            this.Text = "Form_CargaProductos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CargaProductos_FormClosed);
            this.Load += new System.EventHandler(this.Form_CargaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_CantidadStock;
        private System.Windows.Forms.Label label_PrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Nombree;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_PrecioUnitario;
        private System.Windows.Forms.TextBox textBox_CantidadStock;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label_IDcorrelativo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}