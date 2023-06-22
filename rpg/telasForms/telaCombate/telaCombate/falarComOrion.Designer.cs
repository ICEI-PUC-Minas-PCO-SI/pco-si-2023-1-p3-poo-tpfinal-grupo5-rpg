namespace telaCombate
{
    partial class falarComOrion
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
            this.btnSeguirHist = new System.Windows.Forms.Button();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.textoConversa = new System.Windows.Forms.Label();
            this.imgNpc = new System.Windows.Forms.PictureBox();
            this.imgPersonagem = new System.Windows.Forms.PictureBox();
            this.imgLuna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLuna)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeguirHist
            // 
            this.btnSeguirHist.BackColor = System.Drawing.Color.Black;
            this.btnSeguirHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeguirHist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeguirHist.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeguirHist.ForeColor = System.Drawing.Color.White;
            this.btnSeguirHist.Location = new System.Drawing.Point(717, 464);
            this.btnSeguirHist.Name = "btnSeguirHist";
            this.btnSeguirHist.Size = new System.Drawing.Size(195, 38);
            this.btnSeguirHist.TabIndex = 39;
            this.btnSeguirHist.Text = "Lutar contra Oibaf";
            this.btnSeguirHist.UseVisualStyleBackColor = false;
            this.btnSeguirHist.Visible = false;
            this.btnSeguirHist.Click += new System.EventHandler(this.btnSeguirHist_Click);
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Black;
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProsseguir.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir.Location = new System.Drawing.Point(385, 464);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(181, 38);
            this.btnProsseguir.TabIndex = 38;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // textoConversa
            // 
            this.textoConversa.BackColor = System.Drawing.Color.Black;
            this.textoConversa.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoConversa.ForeColor = System.Drawing.Color.White;
            this.textoConversa.Location = new System.Drawing.Point(12, 313);
            this.textoConversa.Name = "textoConversa";
            this.textoConversa.Size = new System.Drawing.Size(902, 147);
            this.textoConversa.TabIndex = 37;
            // 
            // imgNpc
            // 
            this.imgNpc.BackColor = System.Drawing.Color.Transparent;
            this.imgNpc.Location = new System.Drawing.Point(555, 20);
            this.imgNpc.Name = "imgNpc";
            this.imgNpc.Size = new System.Drawing.Size(175, 287);
            this.imgNpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNpc.TabIndex = 36;
            this.imgNpc.TabStop = false;
            // 
            // imgPersonagem
            // 
            this.imgPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.imgPersonagem.Location = new System.Drawing.Point(208, 20);
            this.imgPersonagem.Name = "imgPersonagem";
            this.imgPersonagem.Size = new System.Drawing.Size(175, 287);
            this.imgPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonagem.TabIndex = 35;
            this.imgPersonagem.TabStop = false;
            // 
            // imgLuna
            // 
            this.imgLuna.BackColor = System.Drawing.Color.Transparent;
            this.imgLuna.Location = new System.Drawing.Point(12, 20);
            this.imgLuna.Name = "imgLuna";
            this.imgLuna.Size = new System.Drawing.Size(175, 287);
            this.imgLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLuna.TabIndex = 40;
            this.imgLuna.TabStop = false;
            // 
            // falarComOrion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.casaVelho;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.imgLuna);
            this.Controls.Add(this.btnSeguirHist);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.textoConversa);
            this.Controls.Add(this.imgNpc);
            this.Controls.Add(this.imgPersonagem);
            this.MaximizeBox = false;
            this.Name = "falarComOrion";
            this.Text = "O Culto do Abismo";
            this.Load += new System.EventHandler(this.falarComOrion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLuna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSeguirHist;
        private Button btnProsseguir;
        private Label textoConversa;
        private PictureBox imgNpc;
        private PictureBox imgPersonagem;
        private PictureBox imgLuna;
    }
}