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
    public partial class frm_TelaFinal : Form
    {
        public frm_TelaFinal()
        {
            InitializeComponent();
        }

        private void frm_TelaFinal_Load(object sender, EventArgs e)
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
            else if (VariaveisGlobais.erros == 5)
                vidas.Image = Properties.Resources.Vida_Um;
            else if (VariaveisGlobais.erros == 6)
                vidas.Image = Properties.Resources.Vida_Zero;

            if(VariaveisGlobais.erros == 6 )
            {
                pctbox_titulo.Image = Properties.Resources.GameOver;
                pctbox_Mascote.Image = Properties.Resources.Mascote_GameOver;
            }
            else if(VariaveisGlobais.erros >= 1 && VariaveisGlobais.erros <= 5)
            {
                pctbox_titulo.Image = Properties.Resources.ParabensC;
                pctbox_titulo.Location = new System.Drawing.Point(0, 112);
                pctbox_Mascote.Image = Properties.Resources.Mascote_ParabensC;
            }
            else if (VariaveisGlobais.erros == 0)
            {
                pctbox_titulo.Image = Properties.Resources.ParabensE;
                pctbox_titulo.Location = new System.Drawing.Point(0, 112);
                pctbox_Mascote.Image = Properties.Resources.Mascote_ParabensE;
            }

            if(VariaveisGlobais.acertos == 10)
                {
                lbl_pontos.Location = new System.Drawing.Point(724, 645);
                lbl_pontos.Text = "Pontos: " + Convert.ToString(VariaveisGlobais.acertos);
                }
            else lbl_pontos.Text = "Pontos: " + Convert.ToString(VariaveisGlobais.acertos);
        }

        //BOTÃO SIM
        private void btn_sim_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.erros = 0;
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.vidas = 6;

            frm_Questao01 Questao01 = new frm_Questao01();
            this.Visible = false;
            Questao01.ShowDialog();
            this.Close();
        }

        private void btn_sim_MouseDown(object sender, MouseEventArgs e)
        {
            btn_sim.Image = Properties.Resources.btn_sim_click;
        }

        private void btn_sim_MouseEnter(object sender, EventArgs e)
        {
            btn_sim.Image = Properties.Resources.btn_sim_hover;
        }

        private void btn_sim_MouseLeave(object sender, EventArgs e)
        {
            btn_sim.Image = Properties.Resources.btn_sim_normal;   
        }

        // BOTÃO NÃO
        private void btn_nao_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.erros = 0;
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.vidas = 6;

            frm_TelaInicial TelaIicial = new frm_TelaInicial();
            this.Visible = false;
            TelaIicial.ShowDialog();
            this.Close();
        }

        private void btn_nao_MouseDown(object sender, MouseEventArgs e)
        {
            btn_nao.Image = Properties.Resources.btn_nao_click;
        }

        private void btn_nao_MouseEnter(object sender, EventArgs e)
        {
            btn_nao.Image = Properties.Resources.btn_nao_hover;
        }

        private void btn_nao_MouseLeave(object sender, EventArgs e)
        {
            btn_nao.Image = Properties.Resources.btn_nao_normal;
        }
    }
}
