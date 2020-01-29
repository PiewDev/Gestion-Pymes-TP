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
    public partial class Form_Inicio :Form
    {
        public Form_Inicio()
        {
            InitializeComponent();            
        }

        int cont = 0;
        private void Form_Inicio_Load(object sender, EventArgs e)
        {
            
        }
        Form Principal = new Form_MenuPrincipal();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont <100)
            {
                progressBar1.Value=cont;
                cont = cont + 1;
                label_porcentaje.Text = " % " + cont.ToString();
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                this.Principal.Owner = this;
                this.Principal.Show();
            }

           
        }    

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            timer1.Interval = 40;
            timer1.Enabled = true;
        }

        private void label_Version_Click(object sender, EventArgs e)
        {

        }
    }
}
