namespace telaCombate
{
    partial class telaNPCs
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
            this.imgPersonagem = new System.Windows.Forms.PictureBox();
            this.imgNpc = new System.Windows.Forms.PictureBox();
            this.textoConversa = new System.Windows.Forms.Label();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.btnIrParaFloresta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPersonagem
            // 
            this.imgPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.imgPersonagem.Location = new System.Drawing.Point(75, 24);
            this.imgPersonagem.Name = "imgPersonagem";
            this.imgPersonagem.Size = new System.Drawing.Size(175, 287);
            this.imgPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonagem.TabIndex = 0;
            this.imgPersonagem.TabStop = false;
            // 
            // imgNpc
            // 
            this.imgNpc.BackColor = System.Drawing.Color.Transparent;
            this.imgNpc.Image = global::telaCombate.Properties.Resources.npc03;
            this.imgNpc.Location = new System.Drawing.Point(634, 24);
            this.imgNpc.Name = "imgNpc";
            this.imgNpc.Size = new System.Drawing.Size(175, 287);
            this.imgNpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNpc.TabIndex = 1;
            this.imgNpc.TabStop = false;
            // 
            // textoConversa
            // 
            this.textoConversa.BackColor = System.Drawing.Color.Black;
            this.textoConversa.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoConversa.ForeColor = System.Drawing.Color.White;
            this.textoConversa.Location = new System.Drawing.Point(12, 328);
            this.textoConversa.Name = "textoConversa";
            this.textoConversa.Size = new System.Drawing.Size(902, 147);
            this.textoConversa.TabIndex = 2;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Black;
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProsseguir.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir.Location = new System.Drawing.Point(387, 478);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(181, 38);
            this.btnProsseguir.TabIndex = 20;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // btnIrParaFloresta
            // 
            this.btnIrParaFloresta.BackColor = System.Drawing.Color.Black;
            this.btnIrParaFloresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrParaFloresta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIrParaFloresta.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIrParaFloresta.ForeColor = System.Drawing.Color.White;
            this.btnIrParaFloresta.Location = new System.Drawing.Point(728, 478);
            this.btnIrParaFloresta.Name = "btnIrParaFloresta";
            this.btnIrParaFloresta.Size = new System.Drawing.Size(181, 38);
            this.btnIrParaFloresta.TabIndex = 21;
            this.btnIrParaFloresta.Text = "Ir para a floresta";
            this.btnIrParaFloresta.UseVisualStyleBackColor = false;
            this.btnIrParaFloresta.Visible = false;
            this.btnIrParaFloresta.Click += new System.EventHandler(this.btnIrParaFloresta_Click);
            // 
            // telaNPCs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.vila;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.btnIrParaFloresta);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.textoConversa);
            this.Controls.Add(this.imgNpc);
            this.Controls.Add(this.imgPersonagem);
            this.MaximizeBox = false;
            this.Name = "telaNPCs";
            this.Text = "Procurar pistas";
            this.Load += new System.EventHandler(this.telaNPCs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNpc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgPersonagem;
        private PictureBox imgNpc;
        private Label textoConversa;
        private Button btnProsseguir;
        private Button btnIrParaFloresta;
    }
}