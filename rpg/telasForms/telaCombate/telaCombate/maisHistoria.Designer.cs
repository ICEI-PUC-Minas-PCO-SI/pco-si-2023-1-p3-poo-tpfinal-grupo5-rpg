namespace telaCombate
{
    partial class maisHistoria
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
            this.imgNpc = new System.Windows.Forms.PictureBox();
            this.imgPersonagem = new System.Windows.Forms.PictureBox();
            this.btnProsseguir2 = new System.Windows.Forms.Button();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.textoConversa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNpc
            // 
            this.imgNpc.BackColor = System.Drawing.Color.Transparent;
            this.imgNpc.Location = new System.Drawing.Point(430, 62);
            this.imgNpc.Name = "imgNpc";
            this.imgNpc.Size = new System.Drawing.Size(175, 287);
            this.imgNpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNpc.TabIndex = 26;
            this.imgNpc.TabStop = false;
            // 
            // imgPersonagem
            // 
            this.imgPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.imgPersonagem.Location = new System.Drawing.Point(163, 62);
            this.imgPersonagem.Name = "imgPersonagem";
            this.imgPersonagem.Size = new System.Drawing.Size(175, 287);
            this.imgPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonagem.TabIndex = 25;
            this.imgPersonagem.TabStop = false;
            // 
            // btnProsseguir2
            // 
            this.btnProsseguir2.BackColor = System.Drawing.Color.Black;
            this.btnProsseguir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProsseguir2.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir2.Location = new System.Drawing.Point(392, 505);
            this.btnProsseguir2.Name = "btnProsseguir2";
            this.btnProsseguir2.Size = new System.Drawing.Size(181, 38);
            this.btnProsseguir2.TabIndex = 29;
            this.btnProsseguir2.Text = "Prosseguir";
            this.btnProsseguir2.UseVisualStyleBackColor = false;
            this.btnProsseguir2.Visible = false;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Black;
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProsseguir.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir.Location = new System.Drawing.Point(392, 505);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(181, 38);
            this.btnProsseguir.TabIndex = 28;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            // 
            // textoConversa
            // 
            this.textoConversa.BackColor = System.Drawing.Color.Black;
            this.textoConversa.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoConversa.ForeColor = System.Drawing.Color.White;
            this.textoConversa.Location = new System.Drawing.Point(12, 352);
            this.textoConversa.Name = "textoConversa";
            this.textoConversa.Size = new System.Drawing.Size(902, 147);
            this.textoConversa.TabIndex = 27;
            // 
            // maisHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.casaVelho;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.btnProsseguir2);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.textoConversa);
            this.Controls.Add(this.imgNpc);
            this.Controls.Add(this.imgPersonagem);
            this.Name = "maisHistoria";
            this.Text = "O Culto do Abismo";
            this.Load += new System.EventHandler(this.maisHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgNpc;
        private PictureBox imgPersonagem;
        private Button btnProsseguir2;
        private Button btnProsseguir;
        private Label textoConversa;
    }
}