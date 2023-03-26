using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireForce;

namespace FireForce
{
    public partial class frmTelaLoading : Form
    {
        public frmTelaLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;  // desativar o timer
                frm_TelaInicial TelaInicial = new frm_TelaInicial();
                this.Visible = false;
                TelaInicial.ShowDialog();
                this.Close();
                
            }
        }
    }
}