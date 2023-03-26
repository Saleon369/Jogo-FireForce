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
    public partial class frm_Questao04_RespostaErrada : Form
    {
        // ==== BOTÃO PROXIMO
        Image img_btn_proximo_normal;
        Image img_btn_proximo_hover;
        Image img_btn_proximo_click;

        // ==== BOTAO RESPOSTA
        Image img_btn_Resposta_normal;
        Image img_btn_Resposta_hover;

        // ==== BOTAO VOLTAR DICA
        Image img_btn_VoltaDica_normal;
        Image img_btn_VoltaDica_hover;

        public frm_Questao04_RespostaErrada()
        {
            InitializeComponent();
            img_btn_proximo_normal = Properties.Resources.Quiz_btnProximo_normal;
            img_btn_proximo_hover = Properties.Resources.Quiz_btnProximo_hover;
            img_btn_proximo_click = Properties.Resources.Quiz_btnProximo_click;

            img_btn_Resposta_normal = Properties.Resources.btn_Resposta_normal;
            img_btn_Resposta_hover = Properties.Resources.btn_Resposta_hover;

            img_btn_VoltaDica_normal = Properties.Resources.btn_VoltaDica_normal;
            img_btn_VoltaDica_hover = Properties.Resources.btn_VoltaDica_hover;
        }
        private void frm_Questao04_RespostaErrada_Load(object sender, EventArgs e)
        {
            if (VariaveisGlobais.erros == 0)
                vidas.Image = Properties.Resources.Vida_Full;
            else if (VariaveisGlobais.erros == 1)
                vidas.Image = Properties.Resources.Vida_Cinco;
            else if (VariaveisGlobais.erros == 2)
                vidas.Image = Properties.Resources.Vida_Quatro;
            else if (VariaveisGlobais.erros == 3)
                vidas.Image = Properties.Resources.Vida_Tres;
            else if (VariaveisGlobais.erros == 4)
                vidas.Image = Properties.Resources.Vida_Dois;
        }

        // BOTAO PROXIMO
        private void btn_proximo_Click(object sender, EventArgs e)
        { 
            frm_Questao05 Questao05 = new frm_Questao05();
            this.Visible = false;
            Questao05.ShowDialog();
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

        // BOTAO RESPOSTA CORRETA
        private void btn_resposta_Click(object sender, EventArgs e)
        {
            picbox_Errado.Image = Properties.Resources.Quiz_Questao04_ErradoCorrecao;
            btn_resposta.Visible = false;
            btn_VoltaDica.Visible = true;
        }
        private void btn_resposta_MouseDown(object sender, MouseEventArgs e)
        {
            btn_resposta.Image = img_btn_Resposta_hover;
        }
        private void btn_resposta_MouseEnter(object sender, EventArgs e)
        {
            btn_resposta.Image = img_btn_Resposta_hover;
        }

        private void btn_resposta_MouseLeave(object sender, EventArgs e)
        {
            btn_resposta.Image = img_btn_Resposta_normal;
        }
        private void btn_resposta_MouseUp(object sender, MouseEventArgs e)
        {
            btn_resposta.Image = img_btn_Resposta_normal;
        }

        // BOTAO VOLTAR DICA
        private void btn_VoltaDica_Click(object sender, EventArgs e)
        {
            picbox_Errado.Image = Properties.Resources.Quiz_Questao04_Errado;
            btn_VoltaDica.Visible = false;
            btn_resposta.Visible = true;
        }

        private void btn_VoltaDica_MouseDown(object sender, MouseEventArgs e)
        {
            btn_VoltaDica.Image = img_btn_VoltaDica_hover;
        }

        private void btn_VoltaDica_MouseEnter(object sender, EventArgs e)
        {
            btn_VoltaDica.Image = img_btn_VoltaDica_hover;
        }

        private void btn_VoltaDica_MouseLeave(object sender, EventArgs e)
        {
            btn_VoltaDica.Image = img_btn_VoltaDica_normal;
        }

        private void btn_VoltaDica_MouseUp(object sender, MouseEventArgs e)
        {
            btn_VoltaDica.Image = img_btn_VoltaDica_normal;
        }
    }
}
