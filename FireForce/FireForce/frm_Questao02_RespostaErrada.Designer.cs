namespace FireForce
{
    partial class frm_Questao02_RespostaErrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Questao02_RespostaErrada));
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.btn_resposta = new System.Windows.Forms.PictureBox();
            this.pctbox_pergunta = new System.Windows.Forms.PictureBox();
            this.vidas = new System.Windows.Forms.PictureBox();
            this.btn_VoltaDica = new System.Windows.Forms.PictureBox();
            this.picbox_Errado = new System.Windows.Forms.PictureBox();
            this.btn_proximo = new System.Windows.Forms.PictureBox();
            this.lbl_npergunta = new System.Windows.Forms.Label();
            this.pnl_fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VoltaDica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Errado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proximo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.BackgroundImage = global::FireForce.Properties.Resources.Fundo_Perguntas;
            this.pnl_fundo.Controls.Add(this.btn_resposta);
            this.pnl_fundo.Controls.Add(this.pctbox_pergunta);
            this.pnl_fundo.Controls.Add(this.vidas);
            this.pnl_fundo.Controls.Add(this.btn_VoltaDica);
            this.pnl_fundo.Controls.Add(this.picbox_Errado);
            this.pnl_fundo.Controls.Add(this.btn_proximo);
            this.pnl_fundo.Controls.Add(this.lbl_npergunta);
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(1008, 729);
            this.pnl_fundo.TabIndex = 0;
            // 
            // btn_resposta
            // 
            this.btn_resposta.BackColor = System.Drawing.Color.Transparent;
            this.btn_resposta.Image = global::FireForce.Properties.Resources.btn_Resposta_normal;
            this.btn_resposta.Location = new System.Drawing.Point(595, 603);
            this.btn_resposta.Name = "btn_resposta";
            this.btn_resposta.Size = new System.Drawing.Size(319, 70);
            this.btn_resposta.TabIndex = 29;
            this.btn_resposta.TabStop = false;
            this.btn_resposta.Tag = "0";
            this.btn_resposta.Click += new System.EventHandler(this.btn_resposta_Click);
            this.btn_resposta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_resposta_MouseDown);
            this.btn_resposta.MouseEnter += new System.EventHandler(this.btn_resposta_MouseEnter);
            this.btn_resposta.MouseLeave += new System.EventHandler(this.btn_resposta_MouseLeave);
            this.btn_resposta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_resposta_MouseUp);
            // 
            // pctbox_pergunta
            // 
            this.pctbox_pergunta.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_pergunta.Image = global::FireForce.Properties.Resources.imgPgta2;
            this.pctbox_pergunta.Location = new System.Drawing.Point(76, 79);
            this.pctbox_pergunta.Name = "pctbox_pergunta";
            this.pctbox_pergunta.Size = new System.Drawing.Size(877, 26);
            this.pctbox_pergunta.TabIndex = 32;
            this.pctbox_pergunta.TabStop = false;
            // 
            // vidas
            // 
            this.vidas.BackColor = System.Drawing.Color.Transparent;
            this.vidas.Image = global::FireForce.Properties.Resources.Vida_Full;
            this.vidas.Location = new System.Drawing.Point(636, 12);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(285, 45);
            this.vidas.TabIndex = 31;
            this.vidas.TabStop = false;
            // 
            // btn_VoltaDica
            // 
            this.btn_VoltaDica.BackColor = System.Drawing.Color.Transparent;
            this.btn_VoltaDica.Image = global::FireForce.Properties.Resources.btn_VoltaDica_normal;
            this.btn_VoltaDica.Location = new System.Drawing.Point(595, 603);
            this.btn_VoltaDica.Name = "btn_VoltaDica";
            this.btn_VoltaDica.Size = new System.Drawing.Size(319, 70);
            this.btn_VoltaDica.TabIndex = 30;
            this.btn_VoltaDica.TabStop = false;
            this.btn_VoltaDica.Tag = "0";
            this.btn_VoltaDica.Visible = false;
            this.btn_VoltaDica.Click += new System.EventHandler(this.btn_VoltaDica_Click);
            this.btn_VoltaDica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_VoltaDica_MouseDown);
            this.btn_VoltaDica.MouseEnter += new System.EventHandler(this.btn_VoltaDica_MouseEnter);
            this.btn_VoltaDica.MouseLeave += new System.EventHandler(this.btn_VoltaDica_MouseLeave);
            this.btn_VoltaDica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_VoltaDica_MouseUp);
            // 
            // picbox_Errado
            // 
            this.picbox_Errado.BackColor = System.Drawing.Color.Transparent;
            this.picbox_Errado.Image = global::FireForce.Properties.Resources.Quiz_Questao02_Errado;
            this.picbox_Errado.Location = new System.Drawing.Point(-21, 157);
            this.picbox_Errado.Name = "picbox_Errado";
            this.picbox_Errado.Size = new System.Drawing.Size(935, 545);
            this.picbox_Errado.TabIndex = 28;
            this.picbox_Errado.TabStop = false;
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.Color.Transparent;
            this.btn_proximo.Image = global::FireForce.Properties.Resources.Quiz_btnProximo_normal;
            this.btn_proximo.Location = new System.Drawing.Point(957, 0);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(51, 729);
            this.btn_proximo.TabIndex = 27;
            this.btn_proximo.TabStop = false;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            this.btn_proximo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_proximo_MouseDown);
            this.btn_proximo.MouseEnter += new System.EventHandler(this.btn_proximo_MouseEnter);
            this.btn_proximo.MouseLeave += new System.EventHandler(this.btn_proximo_MouseLeave);
            this.btn_proximo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_proximo_MouseUp);
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
            this.lbl_npergunta.TabIndex = 25;
            this.lbl_npergunta.Text = "Pergunta 2";
            // 
            // frm_Questao02_RespostaErrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnl_fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Questao02_RespostaErrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FireForce";
            this.Load += new System.EventHandler(this.frm_Questao02_RespostaErrada_Load);
            this.pnl_fundo.ResumeLayout(false);
            this.pnl_fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VoltaDica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Errado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proximo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_fundo;
        private Label lbl_npergunta;
        private PictureBox btn_proximo;
        private PictureBox picbox_Errado;
        private PictureBox btn_resposta;
        private PictureBox btn_VoltaDica;
        private PictureBox vidas;
        private PictureBox pctbox_pergunta;
    }
}