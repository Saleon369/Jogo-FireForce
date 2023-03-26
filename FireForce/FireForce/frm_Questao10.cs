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
    public partial class frm_Questao10 : Form
    {
        int correto = 0, alternativas =0;        

        // ==== BOTÃO VOLTAR
        Image img_btn_voltar_normal;
        Image img_btn_voltar_hover;
        Image img_btn_voltar_click;
        

        // ==== BOTAO CORRIGIR
        Image img_btn_corrigir_normal;
        Image img_btn_corrigir_hover;

        // ==== BOTAO CORRETO ( Alternativa CORRETA )
        Image img_btn_correto_normal;
        Image img_btn_correto_hover;
        Image img_btn_correto_click;

        // ==== BOTAO QUASE CORRETO ( Alternativa ERRADA ) 
        Image img_btn_quasecorreto_normal;
        Image img_btn_quasecorreto_hover;
        Image img_btn_quasecorreto_click;

        // ==== BOTAO ERRADO  ( Alternativa ERRADA )
        Image img_btn_errado_normal;
        Image img_btn_errado_hover;
        Image img_btn_errado_click; 

        // ==== BOTAO ABSURDO  ( Alternativa ERRADA )
        Image img_btn_absurdo_normal;
        Image img_btn_absurdo_hover;
        Image img_btn_absurdo_click; 

        public frm_Questao10()
        {
            InitializeComponent();
            img_btn_voltar_normal = Properties.Resources.Quiz_btnVoltar_normal;
            img_btn_voltar_hover = Properties.Resources.Quiz_btnVoltar_hover;
            img_btn_voltar_click = Properties.Resources.Quiz_btnVoltar_click; 

            img_btn_corrigir_normal = Properties.Resources.btn_corrigir_normal;
            img_btn_corrigir_hover = Properties.Resources.btn_corrigir_hover;

            img_btn_correto_normal = Properties.Resources.btn_correto10_normal; 
            img_btn_correto_hover = Properties.Resources.btn_correto10_hover;   
            img_btn_correto_click = Properties.Resources.btn_correto10_click;   
            
            img_btn_quasecorreto_normal = Properties.Resources.btn_quasecorreto10_normal;  
            img_btn_quasecorreto_hover = Properties.Resources.btn_quasecorreto10_hover;  
            img_btn_quasecorreto_click = Properties.Resources.btn_quasecorreto10_click;  
            
            
            img_btn_errado_normal = Properties.Resources.btn_errado10_normal; 
            img_btn_errado_hover = Properties.Resources.btn_errado10_hover;  
            img_btn_errado_click = Properties.Resources.btn_errado10_click;  
            
            
            img_btn_absurdo_normal = Properties.Resources.btn_absurdo10_normal;
            img_btn_absurdo_hover = Properties.Resources.btn_absurdo10_hover; 
            img_btn_absurdo_click = Properties.Resources.btn_absurdo10_click;    
        }
        private void frm_Questao10_Load(object sender, EventArgs e)
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

            // ====== ALEATORIZAÇÃO DOS BOTÕES DE ALTERNATIVA 
            Random random = new Random();
            alternativas = random.Next(1, 24);

            switch (alternativas)
            {
                case 1:
                    this.btn_correto.Location = new System.Drawing.Point(0, 0);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
                    this.btn_errado.Location = new System.Drawing.Point(0, 226);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 339);

                    break;

                case 2:
                    this.btn_correto.Location = new System.Drawing.Point(0, 0);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
                    this.btn_errado.Location = new System.Drawing.Point(0, 339);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 226);

                    break;

                case 3:
                    this.btn_correto.Location = new System.Drawing.Point(0, 0);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 226);
                    this.btn_errado.Location = new System.Drawing.Point(0, 113);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 339);

                    break;

                case 4:
                    this.btn_correto.Location = new System.Drawing.Point(0, 0);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 226);
                    this.btn_errado.Location = new System.Drawing.Point(0, 339);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 113);

                    break;

                case 5:
                    this.btn_correto.Location = new System.Drawing.Point(0, 0);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 339);
                    this.btn_errado.Location = new System.Drawing.Point(0, 113);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 226);

                    break;

                case 6:
                    this.btn_correto.Location = new System.Drawing.Point(0, 0);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 339);
                    this.btn_errado.Location = new System.Drawing.Point(0, 226);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 113);

                    break;

                case 7:
                    this.btn_correto.Location = new System.Drawing.Point(0, 113);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 0);
                    this.btn_errado.Location = new System.Drawing.Point(0, 226);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 339);

                    break;

                case 8:
                    this.btn_correto.Location = new System.Drawing.Point(0, 113);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 0);
                    this.btn_errado.Location = new System.Drawing.Point(0, 339);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 226);

                    break;

                case 9:
                    this.btn_correto.Location = new System.Drawing.Point(0, 226);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 0);
                    this.btn_errado.Location = new System.Drawing.Point(0, 113);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 339);

                    break;

                case 10:
                    this.btn_correto.Location = new System.Drawing.Point(0, 226);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 0);
                    this.btn_errado.Location = new System.Drawing.Point(0, 339);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 113);

                    break;

                case 11:
                    this.btn_correto.Location = new System.Drawing.Point(0, 339);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 0);
                    this.btn_errado.Location = new System.Drawing.Point(0, 113);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 226);

                    break;

                case 12:
                    this.btn_correto.Location = new System.Drawing.Point(0, 339);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 0);
                    this.btn_errado.Location = new System.Drawing.Point(0, 226);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 113);

                    break;

                case 13:
                    this.btn_correto.Location = new System.Drawing.Point(0, 113);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 226);
                    this.btn_errado.Location = new System.Drawing.Point(0, 0);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 339);

                    break;

                case 14:
                    this.btn_correto.Location = new System.Drawing.Point(0, 113);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 339);
                    this.btn_errado.Location = new System.Drawing.Point(0, 0);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 226);

                    break;

                case 15:
                    this.btn_correto.Location = new System.Drawing.Point(0, 226);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
                    this.btn_errado.Location = new System.Drawing.Point(0, 0);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 339);

                    break;

                case 16:
                    this.btn_correto.Location = new System.Drawing.Point(0, 226);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 339);
                    this.btn_errado.Location = new System.Drawing.Point(0, 0);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 113);

                    break;

                case 17:
                    this.btn_correto.Location = new System.Drawing.Point(0, 339);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
                    this.btn_errado.Location = new System.Drawing.Point(0, 0);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 226);

                    break;

                case 18:
                    this.btn_correto.Location = new System.Drawing.Point(0, 339);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 226);
                    this.btn_errado.Location = new System.Drawing.Point(0, 0);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 113);

                    break;

                case 19:
                    this.btn_correto.Location = new System.Drawing.Point(0, 113);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 226);
                    this.btn_errado.Location = new System.Drawing.Point(0, 339);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 0);

                    break;

                case 20:
                    this.btn_correto.Location = new System.Drawing.Point(0, 113);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 339);
                    this.btn_errado.Location = new System.Drawing.Point(0, 226);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 0);

                    break;

                case 21:
                    this.btn_correto.Location = new System.Drawing.Point(0, 226);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
                    this.btn_errado.Location = new System.Drawing.Point(0, 339);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 0);

                    break;


                case 22:
                    this.btn_correto.Location = new System.Drawing.Point(0, 226);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 339);
                    this.btn_errado.Location = new System.Drawing.Point(0, 113);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 0);

                    break;


                case 23:
                    this.btn_correto.Location = new System.Drawing.Point(0, 339);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
                    this.btn_errado.Location = new System.Drawing.Point(0, 226);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 0);

                    break;

                case 24:
                    this.btn_correto.Location = new System.Drawing.Point(0, 339);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 226);
                    this.btn_errado.Location = new System.Drawing.Point(0, 113);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 0);

                    break;
            }
        }

        // ====== BOTÃO VOLTAR

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // === CAIXA DE DIALOGO BOTAO VOLTAR
            DialogResult Resposta = MessageBox.Show("Deseja voltar ao início?", "FireForce", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (Resposta == DialogResult.Yes)
            {
                DialogResult Resposta1 = MessageBox.Show("Seu progresso será perdido!\nTem certeza?", "FireForce", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (Resposta1 == DialogResult.Yes)
                {
                    VariaveisGlobais.acertos = 0;  // contador da variavel acertos é zerada
                    VariaveisGlobais.erros = 0; // contador da variavel erros é zerada
                    VariaveisGlobais.vidas = 6; // contador de vidas é reinicializada
                    frm_TelaInicial TelaIicial = new frm_TelaInicial();
                    this.Visible = false;
                    TelaIicial.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Boa sorte!", "FireForce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Boa sorte!", "FireForce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_voltar_MouseDown(object sender, MouseEventArgs e)
        {

            btn_voltar.Image = img_btn_voltar_click;

        }

        private void btn_voltar_MouseEnter(object sender, EventArgs e)
        {
            btn_voltar.Image = img_btn_voltar_hover;
        }

        private void btn_voltar_MouseLeave(object sender, EventArgs e)
        {
            btn_voltar.Image = img_btn_voltar_normal;
        }
        private void btn_voltar_MouseUp(object sender, MouseEventArgs e)
        {
            btn_voltar.Image = img_btn_voltar_normal;
        }        


        // ===== BOTAO CORRIGIR
        private void btn_corrigir_Click(object sender, EventArgs e)
        {
            if (correto == 1)
            {
                VariaveisGlobais.acertos++;
                frm_Questao10_RespostaCorreta RespostaCorreta = new frm_Questao10_RespostaCorreta();
                this.Visible = false;
                RespostaCorreta.ShowDialog();
                this.Close();
            }
            else
            {
                VariaveisGlobais.erros++;
                frm_Questao10_RespostaErrada RespostaErrada = new frm_Questao10_RespostaErrada();
                this.Visible = false;
                RespostaErrada.ShowDialog();
                this.Close();
            }
        }
        private void btn_corrigir_MouseDown(object sender, MouseEventArgs e)
        {
            btn_corrigir.Image = img_btn_corrigir_hover;
        }
        private void btn_corrigir_MouseEnter(object sender, EventArgs e)
        {
            btn_corrigir.Image = img_btn_corrigir_hover;
        }
        private void btn_corrigir_MouseLeave(object sender, EventArgs e)
        {
            btn_corrigir.Image = img_btn_corrigir_normal;
        }
        private void btn_corrigir_MouseUp(object sender, MouseEventArgs e)
        {
            btn_corrigir.Image = img_btn_corrigir_normal;
        }       


        // BOTAO CORRETO 01
        private void btn_correto_Click(object sender, EventArgs e)
        {
            correto = 1;
            btn_corrigir.Visible = true;
        }

        private void btn_correto_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;            
            btn_correto.Image = img_btn_correto_normal;
            btn_correto.Tag = 0;
            btn_quasecorreto.Image = img_btn_quasecorreto_normal;
            btn_quasecorreto.Tag = 0;
            btn_errado.Image = img_btn_errado_normal;
            btn_errado.Tag = 0;
            btn_absurdo.Image = img_btn_absurdo_normal;
            btn_absurdo.Tag = 0;
            selecionado.Tag = 1;
            btn_correto.Image = img_btn_correto_click;
        }     

        private void btn_correto_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}",selecionado.Tag)) == 0)
                btn_correto.Image = img_btn_correto_click;
        }

        private void btn_correto_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;            
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_correto.Image = img_btn_correto_hover;
        }

        private void btn_correto_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_correto.Image = img_btn_correto_normal;
        }

        // BOTAO QUASE CORRETO 01

        private void btn_quasecorreto_Click(object sender, EventArgs e)
        {
            correto = 0;
            btn_corrigir.Visible = true;
        }
        private void btn_quasecorreto_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_correto.Image = img_btn_correto_normal;
            btn_correto.Tag = 0;
            btn_quasecorreto.Image = img_btn_quasecorreto_normal;
            btn_quasecorreto.Tag = 0;
            btn_errado.Image = img_btn_errado_normal;
            btn_errado.Tag = 0;
            btn_absurdo.Image = img_btn_absurdo_normal;
            btn_absurdo.Tag = 0;
            selecionado.Tag = 1;
            btn_quasecorreto.Image = img_btn_quasecorreto_click;
        }

        private void btn_quasecorreto_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_quasecorreto.Image = img_btn_quasecorreto_click;
        }

        private void btn_quasecorreto_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_quasecorreto.Image = img_btn_quasecorreto_hover;
        }

        private void btn_quasecorreto_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_quasecorreto.Image = img_btn_quasecorreto_normal;
        }

        //BOTAO ERRADO 01
        private void btn_errado_Click(object sender, EventArgs e)
        {
            correto = 0;
            btn_corrigir.Visible = true;
        }
        private void btn_errado_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_correto.Image = img_btn_correto_normal;
            btn_correto.Tag = 0;
            btn_quasecorreto.Image = img_btn_quasecorreto_normal;
            btn_quasecorreto.Tag = 0;
            btn_errado.Image = img_btn_errado_normal;
            btn_errado.Tag = 0;
            btn_absurdo.Image = img_btn_absurdo_normal;
            btn_absurdo.Tag = 0;
            selecionado.Tag = 1;
            btn_errado.Image = img_btn_errado_click;
        }

        private void btn_errado_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_errado.Image = img_btn_errado_click;
        }

        private void btn_errado_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_errado.Image = img_btn_errado_hover;
        }

        private void btn_errado_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_errado.Image = img_btn_errado_normal;
        }

        // BOTAO ABSURDO 01 

        private void btn_absurdo_Click(object sender, EventArgs e)
        {
            correto = 0;
            btn_corrigir.Visible = true;
        }
        private void btn_absurdo_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_correto.Image = img_btn_correto_normal;
            btn_correto.Tag = 0;
            btn_quasecorreto.Image = img_btn_quasecorreto_normal;
            btn_quasecorreto.Tag = 0;
            btn_errado.Image = img_btn_errado_normal;
            btn_errado.Tag = 0;
            btn_absurdo.Image = img_btn_absurdo_normal;
            btn_absurdo.Tag = 0;
            selecionado.Tag = 1;
            btn_absurdo.Image = img_btn_absurdo_click;
        }

        private void btn_absurdo_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_absurdo.Image = img_btn_absurdo_click;
        }

        private void btn_absurdo_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_absurdo.Image = img_btn_absurdo_hover;
        }

        

        private void btn_absurdo_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_absurdo.Image = img_btn_absurdo_normal;
        }

       
    }
}
