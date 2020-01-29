namespace Tp_WindowsForms
{
    partial class Form_Reporte2
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
            this.label1_Nombre = new System.Windows.Forms.Label();
            this.comboBox_Nombre = new System.Windows.Forms.ComboBox();
            this.label_CantidadDefectuosos = new System.Windows.Forms.Label();
            this.label_DefsonbraVen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_MostrarNombreProducto = new System.Windows.Forms.Label();
            this.label_CantidadVendidos = new System.Windows.Forms.Label();
            this.label_MostrarCantidadVendidos = new System.Windows.Forms.Label();
            this.label_MostrarCantidadDefectuosos = new System.Windows.Forms.Label();
            this.label_MostrarDefsobreVen = new System.Windows.Forms.Label();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Nombre
            // 
            this.label1_Nombre.AutoSize = true;
            this.label1_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Nombre.Location = new System.Drawing.Point(63, 56);
            this.label1_Nombre.Name = "label1_Nombre";
            this.label1_Nombre.Size = new System.Drawing.Size(116, 16);
            this.label1_Nombre.TabIndex = 1;
            this.label1_Nombre.Text = "Nombre producto:";
            // 
            // comboBox_Nombre
            // 
            this.comboBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Nombre.FormattingEnabled = true;
            this.comboBox_Nombre.Location = new System.Drawing.Point(185, 54);
            this.comboBox_Nombre.Name = "comboBox_Nombre";
            this.comboBox_Nombre.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Nombre.TabIndex = 2;
            // 
            // label_CantidadDefectuosos
            // 
            this.label_CantidadDefectuosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CantidadDefectuosos.Location = new System.Drawing.Point(564, 164);
            this.label_CantidadDefectuosos.Name = "label_CantidadDefectuosos";
            this.label_CantidadDefectuosos.Size = new System.Drawing.Size(116, 34);
            this.label_CantidadDefectuosos.TabIndex = 1;
            this.label_CantidadDefectuosos.Text = "   Cantidad    defectuosos:";
            this.label_CantidadDefectuosos.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_DefsonbraVen
            // 
            this.label_DefsonbraVen.AutoSize = true;
            this.label_DefsonbraVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DefsonbraVen.Location = new System.Drawing.Point(794, 170);
            this.label_DefsonbraVen.Name = "label_DefsonbraVen";
            this.label_DefsonbraVen.Size = new System.Drawing.Size(163, 16);
            this.label_DefsonbraVen.TabIndex = 1;
            this.label_DefsonbraVen.Text = "% defectuosos / vendidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre producto:";
            // 
            // label_MostrarNombreProducto
            // 
            this.label_MostrarNombreProducto.BackColor = System.Drawing.Color.White;
            this.label_MostrarNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarNombreProducto.Location = new System.Drawing.Point(143, 170);
            this.label_MostrarNombreProducto.Name = "label_MostrarNombreProducto";
            this.label_MostrarNombreProducto.Size = new System.Drawing.Size(110, 23);
            this.label_MostrarNombreProducto.TabIndex = 1;
            // 
            // label_CantidadVendidos
            // 
            this.label_CantidadVendidos.AutoSize = true;
            this.label_CantidadVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CantidadVendidos.Location = new System.Drawing.Point(282, 170);
            this.label_CantidadVendidos.Name = "label_CantidadVendidos";
            this.label_CantidadVendidos.Size = new System.Drawing.Size(124, 16);
            this.label_CantidadVendidos.TabIndex = 1;
            this.label_CantidadVendidos.Text = "Cantidad vendidos:";
            // 
            // label_MostrarCantidadVendidos
            // 
            this.label_MostrarCantidadVendidos.BackColor = System.Drawing.Color.White;
            this.label_MostrarCantidadVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarCantidadVendidos.Location = new System.Drawing.Point(415, 170);
            this.label_MostrarCantidadVendidos.Name = "label_MostrarCantidadVendidos";
            this.label_MostrarCantidadVendidos.Size = new System.Drawing.Size(110, 23);
            this.label_MostrarCantidadVendidos.TabIndex = 1;
            this.label_MostrarCantidadVendidos.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_MostrarCantidadDefectuosos
            // 
            this.label_MostrarCantidadDefectuosos.BackColor = System.Drawing.Color.White;
            this.label_MostrarCantidadDefectuosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarCantidadDefectuosos.Location = new System.Drawing.Point(669, 170);
            this.label_MostrarCantidadDefectuosos.Name = "label_MostrarCantidadDefectuosos";
            this.label_MostrarCantidadDefectuosos.Size = new System.Drawing.Size(110, 23);
            this.label_MostrarCantidadDefectuosos.TabIndex = 1;
            // 
            // label_MostrarDefsobreVen
            // 
            this.label_MostrarDefsobreVen.BackColor = System.Drawing.Color.White;
            this.label_MostrarDefsobreVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarDefsobreVen.Location = new System.Drawing.Point(969, 170);
            this.label_MostrarDefsobreVen.Name = "label_MostrarDefsobreVen";
            this.label_MostrarDefsobreVen.Size = new System.Drawing.Size(110, 23);
            this.label_MostrarDefsobreVen.TabIndex = 1;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirmar.Location = new System.Drawing.Point(461, 44);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(132, 42);
            this.button_Confirmar.TabIndex = 3;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // Form_Reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 503);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.comboBox_Nombre);
            this.Controls.Add(this.label_CantidadVendidos);
            this.Controls.Add(this.label_MostrarDefsobreVen);
            this.Controls.Add(this.label_MostrarCantidadDefectuosos);
            this.Controls.Add(this.label_MostrarCantidadVendidos);
            this.Controls.Add(this.label_DefsonbraVen);
            this.Controls.Add(this.label_MostrarNombreProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_CantidadDefectuosos);
            this.Controls.Add(this.label1_Nombre);
            this.Name = "Form_Reporte2";
            this.Text = "Form_Reporte2";
            this.Load += new System.EventHandler(this.Form_Reporte2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Nombre;
        private System.Windows.Forms.ComboBox comboBox_Nombre;
        private System.Windows.Forms.Label label_CantidadDefectuosos;
        private System.Windows.Forms.Label label_DefsonbraVen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_MostrarNombreProducto;
        private System.Windows.Forms.Label label_CantidadVendidos;
        private System.Windows.Forms.Label label_MostrarCantidadVendidos;
        private System.Windows.Forms.Label label_MostrarCantidadDefectuosos;
        private System.Windows.Forms.Label label_MostrarDefsobreVen;
        private System.Windows.Forms.Button button_Confirmar;
    }
}