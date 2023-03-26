using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireForce
{
    public partial class frm_TelaSobre : Form
    {
        Image btn_voltar_normal;   // botão normal
        Image btn_voltar_high;     // quando o mouse passa por cima do botão

        public frm_TelaSobre()
        {
            btn_voltar_normal = Properties.Resources.btn_voltar_normal;
            btn_voltar_high = Properties.Resources.btn_voltar_high;

            InitializeComponent();
        }

        private void frm_TelaSobre_Load(object sender, EventArgs e)
        {
            btn_voltar_sobre.BackgroundImage = btn_voltar_normal;  // atribuição da imagem na picturebox ( btn_voltar )
        }

        // ====== BOTAO  VOLTAR
        private void btn_voltar_sobre_Click(object sender, EventArgs e)
        {
            frm_TelaInicial TelaInicial = new frm_TelaInicial();
            this.Visible = false;
            TelaInicial.ShowDialog();
            this.Close();
        }
        private void btn_voltar_sobre_MouseEnter(object sender, EventArgs e)
        {
            btn_voltar_sobre.BackgroundImage = btn_voltar_high; // atribuição da imagem na picturebox ( btn_voltar )
        }
        private void btn_voltar_sobre_MouseLeave(object sender, EventArgs e)
        {
            btn_voltar_sobre.BackgroundImage = btn_voltar_normal; // atribuição da imagem na picturebox ( btn_voltar )
        }
    }
}
