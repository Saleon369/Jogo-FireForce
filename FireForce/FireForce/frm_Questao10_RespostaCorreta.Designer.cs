﻿namespace FireForce
{
    partial class frm_Questao10_RespostaCorreta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Questao10_RespostaCorreta));
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.pctbox_pergunta = new System.Windows.Forms.PictureBox();
            this.vidas = new System.Windows.Forms.PictureBox();
            this.picbox_Parabens = new System.Windows.Forms.PictureBox();
            this.btn_proximo = new System.Windows.Forms.PictureBox();
            this.lbl_npergunta = new System.Windows.Forms.Label();
            this.pnl_fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Parabens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proximo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.BackgroundImage = global::FireForce.Properties.Resources.Fundo_Perguntas;
            this.pnl_fundo.Controls.Add(this.pctbox_pergunta);
            this.pnl_fundo.Controls.Add(this.vidas);
            this.pnl_fundo.Controls.Add(this.picbox_Parabens);
            this.pnl_fundo.Controls.Add(this.btn_proximo);
            this.pnl_fundo.Controls.Add(this.lbl_npergunta);
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fundo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(1008, 729);
            this.pnl_fundo.TabIndex = 0;
            // 
            // pctbox_pergunta
            // 
            this.pctbox_pergunta.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_pergunta.Image = global::FireForce.Properties.Resources.imgPgta10;
            this.pctbox_pergunta.Location = new System.Drawing.Point(76, 79);
            this.pctbox_pergunta.Name = "pctbox_pergunta";
            this.pctbox_pergunta.Size = new System.Drawing.Size(877, 57);
            this.pctbox_pergunta.TabIndex = 31;
            this.pctbox_pergunta.TabStop = false;
            // 
            // vidas
            // 
            this.vidas.BackColor = System.Drawing.Color.Transparent;
            this.vidas.Image = global::FireForce.Properties.Resources.Vida_Full;
            this.vidas.Location = new System.Drawing.Point(636, 12);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(285, 45);
            this.vidas.TabIndex = 30;
            this.vidas.TabStop = false;
            // 
            // picbox_Parabens
            // 
            this.picbox_Parabens.BackColor = System.Drawing.Color.Transparent;
            this.picbox_Parabens.Image = global::FireForce.Properties.Resources.Quiz_Questao10_Parabens;
            this.picbox_Parabens.Location = new System.Drawing.Point(43, 157);
            this.picbox_Parabens.Name = "picbox_Parabens";
            this.picbox_Parabens.Size = new System.Drawing.Size(871, 486);
            this.picbox_Parabens.TabIndex = 28;
            this.picbox_Parabens.TabStop = false;
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
            this.lbl_npergunta.Size = new System.Drawing.Size(223, 61);
            this.lbl_npergunta.TabIndex = 25;
            this.lbl_npergunta.Text = "Pergunta 10";
            // 
            // frm_Questao10_RespostaCorreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnl_fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Questao10_RespostaCorreta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FireForce";
            this.Load += new System.EventHandler(this.frm_Questao10_RespostaCorreta_Load);
            this.pnl_fundo.ResumeLayout(false);
            this.pnl_fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Parabens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proximo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_fundo;
        private Label lbl_npergunta;
        private PictureBox btn_proximo;
        private PictureBox picbox_Parabens;
        private PictureBox vidas;
        private PictureBox pctbox_pergunta;
    }
}