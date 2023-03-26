namespace FireForce
{
    partial class frm_TelaFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaFinal));
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.vidas = new System.Windows.Forms.PictureBox();
            this.pctbox_jogar = new System.Windows.Forms.PictureBox();
            this.pctbox_titulo = new System.Windows.Forms.PictureBox();
            this.btn_sim = new System.Windows.Forms.PictureBox();
            this.btn_nao = new System.Windows.Forms.PictureBox();
            this.pctbox_Mascote = new System.Windows.Forms.PictureBox();
            this.pnl_fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_jogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_Mascote)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.BackgroundImage = global::FireForce.Properties.Resources.Fundo_Perguntas;
            this.pnl_fundo.Controls.Add(this.lbl_pontos);
            this.pnl_fundo.Controls.Add(this.vidas);
            this.pnl_fundo.Controls.Add(this.pctbox_jogar);
            this.pnl_fundo.Controls.Add(this.pctbox_titulo);
            this.pnl_fundo.Controls.Add(this.btn_sim);
            this.pnl_fundo.Controls.Add(this.btn_nao);
            this.pnl_fundo.Controls.Add(this.pctbox_Mascote);
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fundo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(1008, 729);
            this.pnl_fundo.TabIndex = 0;
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontos.Font = new System.Drawing.Font("VT323", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pontos.ForeColor = System.Drawing.Color.White;
            this.lbl_pontos.Location = new System.Drawing.Point(748, 645);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(248, 75);
            this.lbl_pontos.TabIndex = 25;
            this.lbl_pontos.Text = "Pontos: 3";
            // 
            // vidas
            // 
            this.vidas.BackColor = System.Drawing.Color.Transparent;
            this.vidas.Image = global::FireForce.Properties.Resources.Vida_Full;
            this.vidas.Location = new System.Drawing.Point(361, 45);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(285, 45);
            this.vidas.TabIndex = 24;
            this.vidas.TabStop = false;
            // 
            // pctbox_jogar
            // 
            this.pctbox_jogar.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_jogar.Image = global::FireForce.Properties.Resources.JogardeNovo;
            this.pctbox_jogar.Location = new System.Drawing.Point(0, 256);
            this.pctbox_jogar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbox_jogar.Name = "pctbox_jogar";
            this.pctbox_jogar.Size = new System.Drawing.Size(1008, 59);
            this.pctbox_jogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctbox_jogar.TabIndex = 4;
            this.pctbox_jogar.TabStop = false;
            // 
            // pctbox_titulo
            // 
            this.pctbox_titulo.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_titulo.Image = global::FireForce.Properties.Resources.GameOver;
            this.pctbox_titulo.Location = new System.Drawing.Point(0, 105);
            this.pctbox_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbox_titulo.Name = "pctbox_titulo";
            this.pctbox_titulo.Size = new System.Drawing.Size(1008, 144);
            this.pctbox_titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctbox_titulo.TabIndex = 3;
            this.pctbox_titulo.TabStop = false;
            // 
            // btn_sim
            // 
            this.btn_sim.BackColor = System.Drawing.Color.Transparent;
            this.btn_sim.Image = global::FireForce.Properties.Resources.btn_sim_normal;
            this.btn_sim.Location = new System.Drawing.Point(385, 332);
            this.btn_sim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(71, 59);
            this.btn_sim.TabIndex = 2;
            this.btn_sim.TabStop = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            this.btn_sim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_sim_MouseDown);
            this.btn_sim.MouseEnter += new System.EventHandler(this.btn_sim_MouseEnter);
            this.btn_sim.MouseLeave += new System.EventHandler(this.btn_sim_MouseLeave);
            // 
            // btn_nao
            // 
            this.btn_nao.BackColor = System.Drawing.Color.Transparent;
            this.btn_nao.Image = global::FireForce.Properties.Resources.btn_nao_normal;
            this.btn_nao.Location = new System.Drawing.Point(551, 332);
            this.btn_nao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nao.Name = "btn_nao";
            this.btn_nao.Size = new System.Drawing.Size(71, 59);
            this.btn_nao.TabIndex = 1;
            this.btn_nao.TabStop = false;
            this.btn_nao.Click += new System.EventHandler(this.btn_nao_Click);
            this.btn_nao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_nao_MouseDown);
            this.btn_nao.MouseEnter += new System.EventHandler(this.btn_nao_MouseEnter);
            this.btn_nao.MouseLeave += new System.EventHandler(this.btn_nao_MouseLeave);
            // 
            // pctbox_Mascote
            // 
            this.pctbox_Mascote.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_Mascote.Image = global::FireForce.Properties.Resources.Mascote_GameOver;
            this.pctbox_Mascote.Location = new System.Drawing.Point(354, 395);
            this.pctbox_Mascote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbox_Mascote.Name = "pctbox_Mascote";
            this.pctbox_Mascote.Size = new System.Drawing.Size(300, 302);
            this.pctbox_Mascote.TabIndex = 0;
            this.pctbox_Mascote.TabStop = false;
            // 
            // frm_TelaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnl_fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_TelaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.frm_TelaFinal_Load);
            this.pnl_fundo.ResumeLayout(false);
            this.pnl_fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_jogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_Mascote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_fundo;
        private PictureBox pctbox_jogar;
        private PictureBox pctbox_titulo;
        private PictureBox btn_sim;
        private PictureBox btn_nao;
        private PictureBox pctbox_Mascote;
        private PictureBox vidas;
        private Label lbl_pontos;
    }
}