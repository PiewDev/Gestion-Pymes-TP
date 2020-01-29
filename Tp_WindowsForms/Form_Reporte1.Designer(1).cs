namespace Tp_WindowsForms
{
    partial class Form_Reporte1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_FechaDeste = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label_FechaDesde = new System.Windows.Forms.Label();
            this.label_FechaHasta = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.comboBox_Nombre = new System.Windows.Forms.ComboBox();
            this.comboBox_Apellido = new System.Windows.Forms.ComboBox();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker_FechaDeste
            // 
            this.dateTimePicker_FechaDeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_FechaDeste.Location = new System.Drawing.Point(245, 108);
            this.dateTimePicker_FechaDeste.Name = "dateTimePicker_FechaDeste";
            this.dateTimePicker_FechaDeste.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker_FechaDeste.TabIndex = 1;
            // 
            // dateTimePicker_FechaHasta
            // 
            this.dateTimePicker_FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_FechaHasta.Location = new System.Drawing.Point(595, 107);
            this.dateTimePicker_FechaHasta.Name = "dateTimePicker_FechaHasta";
            this.dateTimePicker_FechaHasta.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker_FechaHasta.TabIndex = 1;
            // 
            // label_FechaDesde
            // 
            this.label_FechaDesde.AutoSize = true;
            this.label_FechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaDesde.Location = new System.Drawing.Point(148, 109);
            this.label_FechaDesde.Name = "label_FechaDesde";
            this.label_FechaDesde.Size = new System.Drawing.Size(91, 16);
            this.label_FechaDesde.TabIndex = 2;
            this.label_FechaDesde.Text = "Fecha desde:";
            // 
            // label_FechaHasta
            // 
            this.label_FechaHasta.AutoSize = true;
            this.label_FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaHasta.Location = new System.Drawing.Point(500, 110);
            this.label_FechaHasta.Name = "label_FechaHasta";
            this.label_FechaHasta.Size = new System.Drawing.Size(85, 16);
            this.label_FechaHasta.TabIndex = 2;
            this.label_FechaHasta.Text = "Fecha hasta:";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(67, 50);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(60, 16);
            this.label_Nombre.TabIndex = 2;
            this.label_Nombre.Text = "Nombre:";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apellido.Location = new System.Drawing.Point(289, 51);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(61, 16);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido:";
            // 
            // comboBox_Nombre
            // 
            this.comboBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Nombre.FormattingEnabled = true;
            this.comboBox_Nombre.Location = new System.Drawing.Point(145, 47);
            this.comboBox_Nombre.Name = "comboBox_Nombre";
            this.comboBox_Nombre.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Nombre.TabIndex = 3;
            // 
            // comboBox_Apellido
            // 
            this.comboBox_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Apellido.FormattingEnabled = true;
            this.comboBox_Apellido.Location = new System.Drawing.Point(356, 48);
            this.comboBox_Apellido.Name = "comboBox_Apellido";
            this.comboBox_Apellido.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Apellido.TabIndex = 3;
            this.comboBox_Apellido.SelectedIndexChanged += new System.EventHandler(this.comboBox_Apellido_SelectedIndexChanged);
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cliente.Location = new System.Drawing.Point(31, 9);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(58, 20);
            this.label_Cliente.TabIndex = 2;
            this.label_Cliente.Text = "Cliente";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Buscar.Location = new System.Drawing.Point(877, 96);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(119, 51);
            this.button_Buscar.TabIndex = 4;
            this.button_Buscar.Text = "Buscar ventas";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // Form_Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 507);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.comboBox_Apellido);
            this.Controls.Add(this.comboBox_Nombre);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.label_Apellido);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_FechaHasta);
            this.Controls.Add(this.label_FechaDesde);
            this.Controls.Add(this.dateTimePicker_FechaHasta);
            this.Controls.Add(this.dateTimePicker_FechaDeste);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Reporte1";
            this.Text = "Form_Reporte1";
            this.Load += new System.EventHandler(this.Form_Reporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaDeste;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaHasta;
        private System.Windows.Forms.Label label_FechaDesde;
        private System.Windows.Forms.Label label_FechaHasta;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.ComboBox comboBox_Nombre;
        private System.Windows.Forms.ComboBox comboBox_Apellido;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Button button_Buscar;
    }
}