namespace FireForce
{
    partial class frm_Questao02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Questao02));
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.pctbox_pergunta = new System.Windows.Forms.PictureBox();
            this.pnl_perguntas = new System.Windows.Forms.Panel();
            this.btn_corrigir = new System.Windows.Forms.PictureBox();
            this.btn_absurdo = new System.Windows.Forms.PictureBox();
            this.btn_errado = new System.Windows.Forms.PictureBox();
            this.btn_quasecorreto = new System.Windows.Forms.PictureBox();
            this.btn_correto = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.PictureBox();
            this.lbl_npergunta = new System.Windows.Forms.Label();
            this.vidas = new System.Windows.Forms.PictureBox();
            this.pnl_fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pergunta)).BeginInit();
            this.pnl_perguntas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_corrigir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_absurdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_errado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quasecorreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_correto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.BackgroundImage = global::FireForce.Properties.Resources.Fundo_Perguntas;
            this.pnl_fundo.Controls.Add(this.pctbox_pergunta);
            this.pnl_fundo.Controls.Add(this.pnl_perguntas);
            this.pnl_fundo.Controls.Add(this.btn_voltar);
            this.pnl_fundo.Controls.Add(this.lbl_npergunta);
            this.pnl_fundo.Controls.Add(this.vidas);
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(1008, 729);
            this.pnl_fundo.TabIndex = 0;
            // 
            // pctbox_pergunta
            // 
            this.pctbox_pergunta.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_pergunta.Image = global::FireForce.Properties.Resources.imgPgta2;
            this.pctbox_pergunta.Location = new System.Drawing.Point(76, 79);
            this.pctbox_pergunta.Name = "pctbox_pergunta";
            this.pctbox_pergunta.Size = new System.Drawing.Size(877, 26);
            this.pctbox_pergunta.TabIndex = 29;
            this.pctbox_pergunta.TabStop = false;
            // 
            // pnl_perguntas
            // 
            this.pnl_perguntas.BackColor = System.Drawing.Color.Transparent;
            this.pnl_perguntas.Controls.Add(this.btn_corrigir);
            this.pnl_perguntas.Controls.Add(this.btn_absurdo);
            this.pnl_perguntas.Controls.Add(this.btn_errado);
            this.pnl_perguntas.Controls.Add(this.btn_quasecorreto);
            this.pnl_perguntas.Controls.Add(this.btn_correto);
            this.pnl_perguntas.Location = new System.Drawing.Point(86, 161);
            this.pnl_perguntas.Name = "pnl_perguntas";
            this.pnl_perguntas.Size = new System.Drawing.Size(910, 556);
            this.pnl_perguntas.TabIndex = 27;
            // 
            // btn_corrigir
            // 
            this.btn_corrigir.Image = global::FireForce.Properties.Resources.btn_corrigir_normal;
            this.btn_corrigir.Location = new System.Drawing.Point(656, 461);
            this.btn_corrigir.Name = "btn_corrigir";
            this.btn_corrigir.Size = new System.Drawing.Size(242, 70);
            this.btn_corrigir.TabIndex = 28;
            this.btn_corrigir.TabStop = false;
            this.btn_corrigir.Tag = "0";
            this.btn_corrigir.Visible = false;
            this.btn_corrigir.Click += new System.EventHandler(this.btn_corrigir_Click);
            this.btn_corrigir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_corrigir_MouseDown);
            this.btn_corrigir.MouseEnter += new System.EventHandler(this.btn_corrigir_MouseEnter);
            this.btn_corrigir.MouseLeave += new System.EventHandler(this.btn_corrigir_MouseLeave);
            this.btn_corrigir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_corrigir_MouseUp);
            // 
            // btn_absurdo
            // 
            this.btn_absurdo.Image = global::FireForce.Properties.Resources.btn_absurdo02_normal;
            this.btn_absurdo.Location = new System.Drawing.Point(0, 339);
            this.btn_absurdo.Name = "btn_absurdo";
            this.btn_absurdo.Size = new System.Drawing.Size(908, 107);
            this.btn_absurdo.TabIndex = 3;
            this.btn_absurdo.TabStop = false;
            this.btn_absurdo.Tag = "0";
            this.btn_absurdo.Click += new System.EventHandler(this.btn_absurdo_Click);
            this.btn_absurdo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_absurdo_MouseClick);
            this.btn_absurdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_absurdo_MouseDown);
            this.btn_absurdo.MouseEnter += new System.EventHandler(this.btn_absurdo_MouseEnter);
            this.btn_absurdo.MouseLeave += new System.EventHandler(this.btn_absurdo_MouseLeave);
            // 
            // btn_errado
            // 
            this.btn_errado.Image = global::FireForce.Properties.Resources.btn_errado02_normal;
            this.btn_errado.Location = new System.Drawing.Point(0, 226);
            this.btn_errado.Name = "btn_errado";
            this.btn_errado.Size = new System.Drawing.Size(908, 107);
            this.btn_errado.TabIndex = 2;
            this.btn_errado.TabStop = false;
            this.btn_errado.Tag = "0";
            this.btn_errado.Click += new System.EventHandler(this.btn_errado_Click);
            this.btn_errado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_errado_MouseClick);
            this.btn_errado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_errado_MouseDown);
            this.btn_errado.MouseEnter += new System.EventHandler(this.btn_errado_MouseEnter);
            this.btn_errado.MouseLeave += new System.EventHandler(this.btn_errado_MouseLeave);
            // 
            // btn_quasecorreto
            // 
            this.btn_quasecorreto.Image = global::FireForce.Properties.Resources.btn_quasecorreto02_normal;
            this.btn_quasecorreto.Location = new System.Drawing.Point(0, 113);
            this.btn_quasecorreto.Name = "btn_quasecorreto";
            this.btn_quasecorreto.Size = new System.Drawing.Size(908, 107);
            this.btn_quasecorreto.TabIndex = 1;
            this.btn_quasecorreto.TabStop = false;
            this.btn_quasecorreto.Tag = "0";
            this.btn_quasecorreto.Click += new System.EventHandler(this.btn_quasecorreto_Click);
            this.btn_quasecorreto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_quasecorreto_MouseClick);
            this.btn_quasecorreto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_quasecorreto_MouseDown);
            this.btn_quasecorreto.MouseEnter += new System.EventHandler(this.btn_quasecorreto_MouseEnter);
            this.btn_quasecorreto.MouseLeave += new System.EventHandler(this.btn_quasecorreto_MouseLeave);
            // 
            // btn_correto
            // 
            this.btn_correto.Image = global::FireForce.Properties.Resources.btn_correto02_normal;
            this.btn_correto.Location = new System.Drawing.Point(0, 0);
            this.btn_correto.Name = "btn_correto";
            this.btn_correto.Size = new System.Drawing.Size(908, 107);
            this.btn_correto.TabIndex = 0;
            this.btn_correto.TabStop = false;
            this.btn_correto.Tag = "0";
            this.btn_correto.Click += new System.EventHandler(this.btn_correto_Click);
            this.btn_correto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_correto_MouseClick);
            this.btn_correto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_correto_MouseDown);
            this.btn_correto.MouseEnter += new System.EventHandler(this.btn_correto_MouseEnter);
            this.btn_correto.MouseLeave += new System.EventHandler(this.btn_correto_MouseLeave);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.Image = global::FireForce.Properties.Resources.Quiz_btnVoltar_normal;
            this.btn_voltar.Location = new System.Drawing.Point(0, 0);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(51, 729);
            this.btn_voltar.TabIndex = 26;
            this.btn_voltar.TabStop = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            this.btn_voltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_voltar_MouseDown);
            this.btn_voltar.MouseEnter += new System.EventHandler(this.btn_voltar_MouseEnter);
            this.btn_voltar.MouseLeave += new System.EventHandler(this.btn_voltar_MouseLeave);
            this.btn_voltar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_voltar_MouseUp);
            // 
            // lbl_npergunta
            // 
            this.lbl_npergunta.AutoSize = true;
            this.lbl_npergunta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npergunta.Font = new System.Drawing.Font("Caveat", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_npergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(113)))), ((int)(((byte)(252)))));
            this.lbl_npergunta.Location = new System.Drawing.Point(65, 12);
            this.lbl_npergunta.Name = "lbl_npergunta";
            this.lbl_npergunta.Size = new System.Drawing.Size(202, 61);
            this.lbl_npergunta.TabIndex = 24;
            this.lbl_npergunta.Text = "Pergunta 2";
            // 
            // vidas
            // 
            this.vidas.BackColor = System.Drawing.Color.Transparent;
            this.vidas.Image = global::FireForce.Properties.Resources.Vida_Full;
            this.vidas.Location = new System.Drawing.Point(711, 12);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(285, 45);
            this.vidas.TabIndex = 23;
            this.vidas.TabStop = false;
            // 
            // frm_Questao02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnl_fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Questao02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FireForce";
            this.Load += new System.EventHandler(this.frm_Questao02_Load);
            this.pnl_fundo.ResumeLayout(false);
            this.pnl_fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pergunta)).EndInit();
            this.pnl_perguntas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_corrigir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_absurdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_errado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quasecorreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_correto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_fundo;
        private Label lbl_npergunta;
        private PictureBox vidas;
        private PictureBox btn_voltar;
        private Panel pnl_perguntas;
        private PictureBox btn_absurdo;
        private PictureBox btn_errado;
        private PictureBox btn_quasecorreto;
        private PictureBox btn_correto;
        private PictureBox btn_corrigir;
        private PictureBox pctbox_pergunta;
    }
}