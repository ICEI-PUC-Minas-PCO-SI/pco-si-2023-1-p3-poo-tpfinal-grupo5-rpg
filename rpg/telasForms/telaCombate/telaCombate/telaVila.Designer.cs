﻿namespace telaCombate
{
    partial class telaVila
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
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnFloresta = new System.Windows.Forms.Button();
            this.btnCaverna = new System.Windows.Forms.Button();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.imgPersonagem = new System.Windows.Forms.PictureBox();
            this.imgNpc = new System.Windows.Forms.PictureBox();
            this.nomeNPC = new System.Windows.Forms.Label();
            this.itensVenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Black;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompras.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(46, 473);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(181, 38);
            this.btnCompras.TabIndex = 29;
            this.btnCompras.Text = "Comprar Itens";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnFloresta
            // 
            this.btnFloresta.BackColor = System.Drawing.Color.Black;
            this.btnFloresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFloresta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFloresta.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFloresta.ForeColor = System.Drawing.Color.White;
            this.btnFloresta.Location = new System.Drawing.Point(268, 473);
            this.btnFloresta.Name = "btnFloresta";
            this.btnFloresta.Size = new System.Drawing.Size(181, 38);
            this.btnFloresta.TabIndex = 30;
            this.btnFloresta.Text = "Ir para a floresta";
            this.btnFloresta.UseVisualStyleBackColor = false;
            // 
            // btnCaverna
            // 
            this.btnCaverna.BackColor = System.Drawing.Color.Black;
            this.btnCaverna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaverna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaverna.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCaverna.ForeColor = System.Drawing.Color.White;
            this.btnCaverna.Location = new System.Drawing.Point(491, 473);
            this.btnCaverna.Name = "btnCaverna";
            this.btnCaverna.Size = new System.Drawing.Size(181, 38);
            this.btnCaverna.TabIndex = 31;
            this.btnCaverna.Text = "Ir para a caverna";
            this.btnCaverna.UseVisualStyleBackColor = false;
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.Black;
            this.btnHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistoria.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistoria.ForeColor = System.Drawing.Color.White;
            this.btnHistoria.Location = new System.Drawing.Point(705, 473);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(193, 38);
            this.btnHistoria.TabIndex = 32;
            this.btnHistoria.Text = "Prosseguir história";
            this.btnHistoria.UseVisualStyleBackColor = false;
            // 
            // imgPersonagem
            // 
            this.imgPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.imgPersonagem.Location = new System.Drawing.Point(52, 32);
            this.imgPersonagem.Name = "imgPersonagem";
            this.imgPersonagem.Size = new System.Drawing.Size(175, 287);
            this.imgPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonagem.TabIndex = 33;
            this.imgPersonagem.TabStop = false;
            // 
            // imgNpc
            // 
            this.imgNpc.BackColor = System.Drawing.Color.Transparent;
            this.imgNpc.Location = new System.Drawing.Point(667, 32);
            this.imgNpc.Name = "imgNpc";
            this.imgNpc.Size = new System.Drawing.Size(175, 287);
            this.imgNpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNpc.TabIndex = 34;
            this.imgNpc.TabStop = false;
            // 
            // nomeNPC
            // 
            this.nomeNPC.AutoSize = true;
            this.nomeNPC.BackColor = System.Drawing.Color.Transparent;
            this.nomeNPC.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeNPC.ForeColor = System.Drawing.Color.Black;
            this.nomeNPC.Location = new System.Drawing.Point(725, 12);
            this.nomeNPC.Name = "nomeNPC";
            this.nomeNPC.Size = new System.Drawing.Size(40, 17);
            this.nomeNPC.TabIndex = 35;
            this.nomeNPC.Text = "nome";
            // 
            // itensVenda
            // 
            this.itensVenda.BackgroundColor = System.Drawing.Color.Gray;
            this.itensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensVenda.Location = new System.Drawing.Point(299, 74);
            this.itensVenda.Name = "itensVenda";
            this.itensVenda.RowTemplate.Height = 25;
            this.itensVenda.Size = new System.Drawing.Size(321, 209);
            this.itensVenda.TabIndex = 36;
            this.itensVenda.Visible = false;
            // 
            // telaVila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.vila;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.itensVenda);
            this.Controls.Add(this.nomeNPC);
            this.Controls.Add(this.imgNpc);
            this.Controls.Add(this.imgPersonagem);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.btnCaverna);
            this.Controls.Add(this.btnFloresta);
            this.Controls.Add(this.btnCompras);
            this.MaximizeBox = false;
            this.Name = "telaVila";
            this.Text = "Vila";
            this.Load += new System.EventHandler(this.telaVila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCompras;
        private Button btnFloresta;
        private Button btnCaverna;
        private Button btnHistoria;
        private PictureBox imgPersonagem;
        private PictureBox imgNpc;
        private Label nomeNPC;
        private DataGridView itensVenda;
    }
}