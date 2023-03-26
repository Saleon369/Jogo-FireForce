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
    public partial class frm_Questao01_RespostaCorreta : Form
    {
        // ==== BOTÃO PROXIMO
        Image img_btn_proximo_normal;
        Image img_btn_proximo_hover;
        Image img_btn_proximo_click;

        public frm_Questao01_RespostaCorreta()
        {
            InitializeComponent();
            img_btn_proximo_normal = Properties.Resources.Quiz_btnProximo_normal;
            img_btn_proximo_hover = Properties.Resources.Quiz_btnProximo_hover;
            img_btn_proximo_click = Properties.Resources.Quiz_btnProximo_click;
        }
        private void frm_Questao01_RespostaCorreta_Load(object sender, EventArgs e)
        {
            vidas.Image = Properties.Resources.Vida_Full;
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            frm_Questao02 Questao02 = new frm_Questao02();
            this.Visible = false;
            Questao02.ShowDialog();
            this.Close();
        }

        private void btn_proximo_MouseDown(object sender, MouseEventArgs e)
        {
            btn_proximo.Image = img_btn_proximo_click;
        }
        private void btn_proximo_MouseEnter(object sender, EventArgs e)
        {
            btn_proximo.Image = img_btn_proximo_hover;
        }

        private void btn_proximo_MouseLeave(object sender, EventArgs e)
        {
            btn_proximo.Image = img_btn_proximo_normal;
        }
        private void btn_proximo_MouseUp(object sender, MouseEventArgs e)
        {
            btn_proximo.Image = img_btn_proximo_normal;
        }

        
    }
}
