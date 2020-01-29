using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_WindowsForms
{
    public partial class Form_GrillaVenta : Form
    {
        public Form_GrillaVenta()
        {
            InitializeComponent();

        }

        private void Form_GrillaVenta_Load(object sender, EventArgs e)
        {
            var datos = this.Owner as Interface_GuardarCargas;
            

        }

        private void dataGridView_GrillaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
