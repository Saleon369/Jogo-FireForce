using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireForce_Menu;

namespace FireForce
{
    public partial class frm_Menu : Form
    {
        //==== BOTAO SAIR
        Image btn_sair_normal;
        Image btn_sair_high; 
        public frm_Menu()
        {
            InitializeComponent();

            // ========= Botao SAIR
            btn_sair_normal = Properties.Resources.btn_sair_normal;
            btn_sair_high = Properties.Resources.btn_sair_high;
            btn_labirinto.Image = Properties.Resources.btn_labirinto_normal;
            btn_quiz.Image = Properties.Resources.btn_quiz_normal;
            btn_videos.Image = Properties.Resources.btn_videos_normal;
        }
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = btn_sair_normal;
        }


        //==== Botao LABIRINTO
        private void btn_labirinto_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\labirinto\\Labirinto.html");
        }

        private void btn_labirinto_MouseDown(object sender, MouseEventArgs e)
        {
            btn_labirinto.Image = Properties.Resources.btn_labirinto_click;
        }

        private void btn_labirinto_MouseEnter(object sender, EventArgs e)
        {
            btn_labirinto.Image = Properties.Resources.btn_labirinto_hover;
        }
        private void btn_labirinto_MouseLeave(object sender, EventArgs e)
        {
            btn_labirinto.Image = Properties.Resources.btn_labirinto_normal;
        }

        //==== Botao QUIZ
        private void btn_quiz_Click(object sender, EventArgs e)
        {
            frm_Questao01 Quiz = new frm_Questao01();
            this.Visible = false;
            Quiz.ShowDialog();
            this.Close();
        }
        private void btn_quiz_MouseDown(object sender, MouseEventArgs e)
        {
            btn_quiz.Image = Properties.Resources.btn_quiz_click;
        }

        private void btn_quiz_MouseEnter(object sender, EventArgs e)
        {
            btn_quiz.Image = Properties.Resources.btn_quiz_hover;
        }
        private void btn_quiz_MouseLeave(object sender, EventArgs e)
        {
            btn_quiz.Image = Properties.Resources.btn_quiz_normal;
        }
        


        //==== Botao VIDEOS
        private void btn_videos_Click(object sender, EventArgs e)
        {
            frm_Videos Videos = new frm_Videos();
            Videos.ShowDialog();
        }
        private void btn_videos_MouseDown(object sender, MouseEventArgs e)
        {
            btn_videos.Image = Properties.Resources.btn_videos_click;
        }

        private void btn_videos_MouseEnter(object sender, EventArgs e)
        {
            btn_videos.Image = Properties.Resources.btn_videos_hover;
        }

        private void btn_videos_MouseLeave(object sender, EventArgs e)
        {
            btn_videos.Image = Properties.Resources.btn_videos_normal;
        }
        


        // ==== Botao SAIR

        private void btn_sair_Click(object sender, EventArgs e)
        {
            frm_TelaInicial TelaInicial = new frm_TelaInicial();
            this.Visible = false;
            TelaInicial.ShowDialog();
            this.Close();
        }

        private void btn_sair_MouseDown(object sender, MouseEventArgs e)
        {
            btn_sair.BackgroundImage = btn_sair_high;
        }
        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = btn_sair_high;
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.BackgroundImage = btn_sair_normal;
        }

        private void btn_sair_MouseUp(object sender, MouseEventArgs e)
        {
            btn_sair.BackgroundImage = btn_sair_normal;
        }
    }
}
