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
    public partial class frm_TelaInicial : Form
    {
        //==== BOTAO JOGAR
        Image btn_jogar_normal;
        Image btn_jogar_high; 
        //==== BOTAO SOBRE
        Image btn_sobre_normal; 
        Image btn_sobre_high; 
        //==== BOTAO REFERENCIA
        Image btn_referencias_normal;
        Image btn_referencias_high;
        //==== BOTAO SAIR
        Image btn_sair_normal;
        Image btn_sair_high; 
        public frm_TelaInicial()
        {
            InitializeComponent();

            // ========== Botao JOGAR
            btn_jogar_normal = Properties.Resources.btn_jogar_normal;
            btn_jogar_high = Properties.Resources.btn_jogar_high;
            // ========== Botao SOBRE
            btn_sobre_normal = Properties.Resources.btn_sobre_normal;
            btn_sobre_high = Properties.Resources.btn_sobre_high;
            // ========== Botao REFERENCIA
            btn_referencias_normal = Properties.Resources.btn_referencias_normal;
            btn_referencias_high = Properties.Resources.btn_referencias_high;
            // ========= Botao SAIR
            btn_sair_normal = Properties.Resources.btn_sair_normal;
            btn_sair_high = Properties.Resources.btn_sair_high;
        }
        private void frm_TelaInicial_Load(object sender, EventArgs e)
        {
            btn_jogar.BackgroundImage = btn_jogar_normal;
            btn_sobre.BackgroundImage = btn_sobre_normal;
            btn_referencias.BackgroundImage = btn_referencias_normal;
            btn_sair.BackgroundImage = btn_sair_normal;
        }


        //==== Botao JOGAR
        private void btn_jogar_Click(object sender, EventArgs e)
        {
            frm_Menu Menu = new frm_Menu();
            this.Visible = false;
            Menu.ShowDialog();
            this.Close();
        }

        private void btn_jogar_MouseDown(object sender, MouseEventArgs e)
        {
            btn_jogar.BackgroundImage = btn_jogar_high;
        }

        private void btn_jogar_MouseEnter(object sender, EventArgs e)
        {
            btn_jogar.BackgroundImage = btn_jogar_high;
        }
        private void btn_jogar_MouseLeave(object sender, EventArgs e)
        {
            btn_jogar.BackgroundImage = btn_jogar_normal;
        }
        private void btn_jogar_MouseUp(object sender, MouseEventArgs e)
        {
            btn_jogar.BackgroundImage = btn_jogar_normal;
        }


        //==== Botao SOBRE
        private void btn_sobre_Click(object sender, EventArgs e)
        {
            frm_TelaSobre TelaSobre = new frm_TelaSobre();
            this.Visible = false;
            TelaSobre.ShowDialog();
            this.Close();
        }
        private void btn_sobre_MouseDown(object sender, MouseEventArgs e)
        {
            btn_sobre.BackgroundImage = btn_sobre_high;
        }

        private void btn_sobre_MouseEnter(object sender, EventArgs e)
        {
            btn_sobre.BackgroundImage = btn_sobre_high;
        }
        private void btn_sobre_MouseLeave(object sender, EventArgs e)
        {
            btn_sobre.BackgroundImage = btn_sobre_normal;
        }
        private void btn_sobre_MouseUp(object sender, MouseEventArgs e)
        {
            btn_sobre.BackgroundImage = btn_sobre_normal;
        }


        //==== Botao REFERENCIAS
        private void btn_referencias_Click(object sender, EventArgs e)
        {
            frm_TelaReferencias TelaReferencias = new frm_TelaReferencias();
            this.Visible = false;
            TelaReferencias.ShowDialog();
            this.Close();
        }
        private void btn_referencias_MouseDown(object sender, MouseEventArgs e)
        {
            btn_referencias.BackgroundImage = btn_referencias_high;
        }

        private void btn_referencias_MouseEnter(object sender, EventArgs e)
        {
            btn_referencias.BackgroundImage = btn_referencias_high;
        }

        private void btn_referencias_MouseLeave(object sender, EventArgs e)
        {
            btn_referencias.BackgroundImage = btn_referencias_normal;
        }
        private void btn_referencias_MouseUp(object sender, MouseEventArgs e)
        {
            btn_referencias.BackgroundImage = btn_referencias_normal;
        }


        // ==== Botao SAIR

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja sair?", "FireForce", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Obrigado por ficar!", "FireForce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
