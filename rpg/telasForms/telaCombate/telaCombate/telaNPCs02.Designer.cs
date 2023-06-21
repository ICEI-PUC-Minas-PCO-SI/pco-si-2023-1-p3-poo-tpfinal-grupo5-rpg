namespace telaCombate
{
    partial class telaNPCs02
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
            this.textoConversa = new System.Windows.Forms.Label();
            this.imgPersonagem = new System.Windows.Forms.PictureBox();
            this.imgNpc = new System.Windows.Forms.PictureBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.btnIrPraCasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).BeginInit();
            this.SuspendLayout();
            // 
            // textoConversa
            // 
            this.textoConversa.BackColor = System.Drawing.Color.Black;
            this.textoConversa.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoConversa.ForeColor = System.Drawing.Color.White;
            this.textoConversa.Location = new System.Drawing.Point(12, 321);
            this.textoConversa.Name = "textoConversa";
            this.textoConversa.Size = new System.Drawing.Size(902, 147);
            this.textoConversa.TabIndex = 3;
            this.textoConversa.Click += new System.EventHandler(this.textoConversa_Click);
            // 
            // imgPersonagem
            // 
            this.imgPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.imgPersonagem.Location = new System.Drawing.Point(111, 25);
            this.imgPersonagem.Name = "imgPersonagem";
            this.imgPersonagem.Size = new System.Drawing.Size(175, 287);
            this.imgPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonagem.TabIndex = 5;
            this.imgPersonagem.TabStop = false;
            // 
            // imgNpc
            // 
            this.imgNpc.BackColor = System.Drawing.Color.Transparent;
            this.imgNpc.Image = global::telaCombate.Properties.Resources.npc04;
            this.imgNpc.Location = new System.Drawing.Point(629, 27);
            this.imgNpc.Name = "imgNpc";
            this.imgNpc.Size = new System.Drawing.Size(175, 287);
            this.imgNpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNpc.TabIndex = 6;
            this.imgNpc.TabStop = false;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Black;
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProsseguir.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir.Location = new System.Drawing.Point(386, 477);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(181, 38);
            this.btnProsseguir.TabIndex = 21;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // btnIrPraCasa
            // 
            this.btnIrPraCasa.BackColor = System.Drawing.Color.Black;
            this.btnIrPraCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrPraCasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrPraCasa.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIrPraCasa.ForeColor = System.Drawing.Color.White;
            this.btnIrPraCasa.Location = new System.Drawing.Point(721, 475);
            this.btnIrPraCasa.Name = "btnIrPraCasa";
            this.btnIrPraCasa.Size = new System.Drawing.Size(181, 38);
            this.btnIrPraCasa.TabIndex = 22;
            this.btnIrPraCasa.Text = "Ir para casa";
            this.btnIrPraCasa.UseVisualStyleBackColor = false;
            this.btnIrPraCasa.Visible = false;
            this.btnIrPraCasa.Click += new System.EventHandler(this.btnIrPraCasa_Click);
            // 
            // telaNPCs02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.vila;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.btnIrPraCasa);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.imgNpc);
            this.Controls.Add(this.imgPersonagem);
            this.Controls.Add(this.textoConversa);
            this.MaximizeBox = false;
            this.Name = "telaNPCs02";
            this.Text = "telaNPCs02";
            this.Load += new System.EventHandler(this.telaNPCs02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label textoConversa;
        private PictureBox imgPersonagem;
        private PictureBox imgNpc;
        private Button btnProsseguir;
        private Button btnIrPraCasa;
    }
}