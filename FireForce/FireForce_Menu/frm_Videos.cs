using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;




namespace FireForce_Menu
{
    public partial class frm_Videos : Form
    {
        string pasta_videos = "";
       
        public frm_Videos()
        {
            InitializeComponent();
            pasta_videos = Application.StartupPath + @"\videos\";
        }
        // VIDEO 1
        private void btn_video1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video1.mp4";
        }
        private void btn_video1_MouseClick(object sender, MouseEventArgs e)
        {
               PictureBox selecionado = (PictureBox)sender;
                             
               btn_video1.Image = Properties.Resources.btn_video1_normal;
               btn_video1.Tag = 0;
               btn_video2.Image = Properties.Resources.btn_video2_normal;
               btn_video2.Tag = 0;
               btn_video3.Image = Properties.Resources.btn_video3_normal;
               btn_video3.Tag = 0;
               btn_video4.Image = Properties.Resources.btn_video4_normal;
               btn_video4.Tag = 0;
               btn_video5.Image = Properties.Resources.btn_video5_normal;
               btn_video5.Tag = 0;
               btn_video6.Image = Properties.Resources.btn_video6_normal;
               btn_video6.Tag = 0;
               btn_video7.Image = Properties.Resources.btn_video7_normal;
               btn_video7.Tag = 0;
               btn_video8.Image = Properties.Resources.btn_video8_normal;
               btn_video8.Tag = 0;
               selecionado.Tag = 1;
               btn_video1.Image = Properties.Resources.btn_video1_click;
        }
       
        private void btn_video1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video1.Image = Properties.Resources.btn_video1_click;
        }

        private void btn_video1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video1.Image = Properties.Resources.btn_video1_hover;
        }

        private void btn_video1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video1.Image = Properties.Resources.btn_video1_normal;
        }

        // VIDEO 2
        private void btn_video2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video2.mp4";
        }

        private void btn_video2_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video2.Image = Properties.Resources.btn_video2_click;
        }
        private void btn_video2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video2.Image = Properties.Resources.btn_video2_click;
        }

        private void btn_video2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video2.Image = Properties.Resources.btn_video2_hover;
        }

        private void btn_video2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video2.Image = Properties.Resources.btn_video2_normal;
        }

        //VIDEO 3
        private void btn_video3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video3.mp4";
        }
        private void btn_video3_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video3.Image = Properties.Resources.btn_video3_click;
        }
        private void btn_video3_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video3.Image = Properties.Resources.btn_video3_click;
        }

        private void btn_video3_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video3.Image = Properties.Resources.btn_video3_hover;
        }

        private void btn_video3_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video3.Image = Properties.Resources.btn_video3_normal;
        }

        //VIDEO 4
        private void btn_video4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video4.mp4";
        }
        private void btn_video4_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video4.Image = Properties.Resources.btn_video4_click;

        }
        private void btn_video4_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video4.Image = Properties.Resources.btn_video4_click;
        }

        private void btn_video4_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video4.Image = Properties.Resources.btn_video4_hover;
        }

        private void btn_video4_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video4.Image = Properties.Resources.btn_video4_normal;
        }

        //VIDEO 5
        private void btn_video5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video5.mp4";
        }
        private void btn_video5_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video5.Image = Properties.Resources.btn_video5_click;
        }
        private void btn_video5_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video5.Image = Properties.Resources.btn_video5_click;
        }

        private void btn_video5_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video5.Image = Properties.Resources.btn_video5_hover;
        }

        private void btn_video5_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video5.Image = Properties.Resources.btn_video5_normal;
        }

        //VIDEO 6
        private void btn_video6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video6.mp4";
        }
        private void btn_video6_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video6.Image = Properties.Resources.btn_video6_click;
        }
        private void btn_video6_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video6.Image = Properties.Resources.btn_video6_click;
        }

        private void btn_video6_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video6.Image = Properties.Resources.btn_video6_hover;
        }

        private void btn_video6_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video6.Image = Properties.Resources.btn_video6_normal;
        }

        //VIDEO 7
        private void btn_video7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video7.mp4";
        }
        private void btn_video7_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video7.Image = Properties.Resources.btn_video7_click;
        }
        private void btn_video7_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video7.Image = Properties.Resources.btn_video7_click;
        }

        private void btn_video7_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video7.Image = Properties.Resources.btn_video7_hover;
        }

        private void btn_video7_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video7.Image = Properties.Resources.btn_video7_normal;
        }

        //VIDEO 8
        private void btn_video8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pasta_videos + "Video8.mp4";
        }
        private void btn_video8_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            btn_video1.Image = Properties.Resources.btn_video1_normal;
            btn_video1.Tag = 0;
            btn_video2.Image = Properties.Resources.btn_video2_normal;
            btn_video2.Tag = 0;
            btn_video3.Image = Properties.Resources.btn_video3_normal;
            btn_video3.Tag = 0;
            btn_video4.Image = Properties.Resources.btn_video4_normal;
            btn_video4.Tag = 0;
            btn_video5.Image = Properties.Resources.btn_video5_normal;
            btn_video5.Tag = 0;
            btn_video6.Image = Properties.Resources.btn_video6_normal;
            btn_video6.Tag = 0;
            btn_video7.Image = Properties.Resources.btn_video7_normal;
            btn_video7.Tag = 0;
            btn_video8.Image = Properties.Resources.btn_video8_normal;
            btn_video8.Tag = 0;
            selecionado.Tag = 1;
            btn_video8.Image = Properties.Resources.btn_video8_click;
        }
        private void btn_video8_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video8.Image = Properties.Resources.btn_video8_click;
        }

        private void btn_video8_MouseEnter(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video8.Image = Properties.Resources.btn_video8_hover;
        }

        private void btn_video8_MouseLeave(object sender, EventArgs e)
        {
            PictureBox selecionado = (PictureBox)sender;
            if (int.Parse(String.Format("{0}", selecionado.Tag)) == 0)
                btn_video8.Image = Properties.Resources.btn_video8_normal;
        }

        // BOTAO SAIR
        private void btn_sair_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            this.Visible = false;
            this.Close();
        }

        private void btn_sair_MouseDown(object sender, MouseEventArgs e)
        {
            btn_sair.Image = Properties.Resources.btn_sair_high;
        }

        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            btn_sair.Image = Properties.Resources.btn_sair_high;
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.Image = Properties.Resources.btn_sair_normal;
        }

        private void btn_sair_MouseUp(object sender, MouseEventArgs e)
        {
            btn_sair.Image = Properties.Resources.btn_sair_normal;
        }

        
        
           // System.Diagnostics.Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\labirinto\\Labirinto.html");
            
        
    }
}
