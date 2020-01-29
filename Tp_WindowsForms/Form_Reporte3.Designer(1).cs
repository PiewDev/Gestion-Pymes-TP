namespace Tp_WindowsForms
{
    partial class Form_Reporte3
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label_FechaDesde = new System.Windows.Forms.Label();
            this.label_FechaHasta = new System.Windows.Forms.Label();
            this.dataGridView_GrillaReporte3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaReporte3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(844, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar fechas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_FechaDesde
            // 
            this.dateTimePicker_FechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_FechaDesde.Location = new System.Drawing.Point(197, 73);
            this.dateTimePicker_FechaDesde.Name = "dateTimePicker_FechaDesde";
            this.dateTimePicker_FechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_FechaDesde.TabIndex = 1;
            // 
            // dateTimePicker_FechaHasta
            // 
            this.dateTimePicker_FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_FechaHasta.Location = new System.Drawing.Point(536, 72);
            this.dateTimePicker_FechaHasta.Name = "dateTimePicker_FechaHasta";
            this.dateTimePicker_FechaHasta.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_FechaHasta.TabIndex = 2;
            // 
            // label_FechaDesde
            // 
            this.label_FechaDesde.AutoSize = true;
            this.label_FechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaDesde.Location = new System.Drawing.Point(74, 74);
            this.label_FechaDesde.Name = "label_FechaDesde";
            this.label_FechaDesde.Size = new System.Drawing.Size(91, 16);
            this.label_FechaDesde.TabIndex = 3;
            this.label_FechaDesde.Text = "Fecha desde:";
            // 
            // label_FechaHasta
            // 
            this.label_FechaHasta.AutoSize = true;
            this.label_FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaHasta.Location = new System.Drawing.Point(431, 75);
            this.label_FechaHasta.Name = "label_FechaHasta";
            this.label_FechaHasta.Size = new System.Drawing.Size(85, 16);
            this.label_FechaHasta.TabIndex = 3;
            this.label_FechaHasta.Text = "Fecha hasta:";
            this.label_FechaHasta.Click += new System.EventHandler(this.label_FechaHasta_Click);
            // 
            // dataGridView_GrillaReporte3
            // 
            this.dataGridView_GrillaReporte3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GrillaReporte3.Location = new System.Drawing.Point(152, 150);
            this.dataGridView_GrillaReporte3.Name = "dataGridView_GrillaReporte3";
            this.dataGridView_GrillaReporte3.Size = new System.Drawing.Size(663, 225);
            this.dataGridView_GrillaReporte3.TabIndex = 4;
            // 
            // Form_Reporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 455);
            this.Controls.Add(this.dataGridView_GrillaReporte3);
            this.Controls.Add(this.label_FechaHasta);
            this.Controls.Add(this.label_FechaDesde);
            this.Controls.Add(this.dateTimePicker_FechaHasta);
            this.Controls.Add(this.dateTimePicker_FechaDesde);
            this.Controls.Add(this.button1);
            this.Name = "Form_Reporte3";
            this.Text = "Form_Reporte3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GrillaReporte3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaDesde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaHasta;
        private System.Windows.Forms.Label label_FechaDesde;
        private System.Windows.Forms.Label label_FechaHasta;
        private System.Windows.Forms.DataGridView dataGridView_GrillaReporte3;
    }
}