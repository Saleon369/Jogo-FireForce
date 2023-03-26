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
    public partial class frm_TelaReferencias : Form
    {
        Image btn_voltar_normal;   
        Image btn_voltar_high;     
        public frm_TelaReferencias()
        {
            btn_voltar_normal = Properties.Resources.btn_voltar_normal;
            btn_voltar_high = Properties.Resources.btn_voltar_high;
            InitializeComponent();
        }

        private void frm_TelaReferencias_Load(object sender, EventArgs e)
        {
            btn_voltar.BackgroundImage = btn_voltar_normal;            
        }

        /// ========= Botão Voltar 
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_TelaInicial TelaInicial = new frm_TelaInicial();
            this.Visible = false;
            TelaInicial.ShowDialog();
            this.Close();
        }

        private void btn_voltar_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_voltar.BackgroundImage = btn_voltar_high;   // atribuição da imagem na PictureBox ( btn_voltar )
        }

        private void btn_voltar_MouseLeave(object sender, EventArgs e)
        {   // altera a imagem para normal ( quando mouse sai da foto )
            btn_voltar.BackgroundImage = btn_voltar_normal;
        }
        private void ll_ref01_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.ccb.policiamilitar.sp.gov.br/portalcb/_educacao-publica/midias-edpub/folders/pdf/ACIDENTES-DOMESTICOS.pdf");

        }

        private void ll_ref02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://bvsms.saude.gov.br/queimaduras/");

        }

        private void ll_ref03_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.einstein.br/doencas-sintomas/queimaduras");

        }

        private void ll_ref04_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.ccb.policiamilitar.sp.gov.br/portalcb/_educacao-publica/midias-edpub/folders/pdf/INCENDIOS.pdf");

        }

        private void ll_ref05_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.sbqueimaduras.org.br/material/1331");

        }

        private void ll_ref06_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.fepecs.edu.br/wp-content/uploads/2021/11/Manual-de-Queimaduras-para-Estudantes-2.pdf");
        }

        private void ll_ref07_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.ccb.policiamilitar.sp.gov.br/portalcb/_educacao-publica/midias-edpub/folders/pdf/PRIMEIROS-SOCORROS.pdf");
        }
    }
}
