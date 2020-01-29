using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.cs;

namespace Tp_WindowsForms
{
    public partial class Form_Reporte3 : Form
    {
        public Form_Reporte3()
        {
            InitializeComponent();
        }

        private void label_FechaHasta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ReporteVendidoPorMes> ListaMes = new List<ReporteVendidoPorMes>();
            Interface_Reportes Form_MenuPrincipal = this.Owner as Interface_Reportes;
            if (Form_MenuPrincipal!=null)
            {
                ListaMes = Form_MenuPrincipal.Reporte3(DateTime.Parse(dateTimePicker_FechaDesde.Text),DateTime.Parse(dateTimePicker_FechaHasta.Text));
            }

            dataGridView_GrillaReporte3.AutoGenerateColumns = true;
            dataGridView_GrillaReporte3.DataSource = ListaMes;
        }
    }
}
