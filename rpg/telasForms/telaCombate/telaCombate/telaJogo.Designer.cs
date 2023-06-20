namespace telaCombate
{
    partial class telaJogo
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
            this.textoIntro = new System.Windows.Forms.Label();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoIntro
            // 
            this.textoIntro.BackColor = System.Drawing.Color.Black;
            this.textoIntro.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoIntro.ForeColor = System.Drawing.Color.White;
            this.textoIntro.Location = new System.Drawing.Point(214, 195);
            this.textoIntro.MaximumSize = new System.Drawing.Size(500, 300);
            this.textoIntro.MinimumSize = new System.Drawing.Size(20, 20);
            this.textoIntro.Name = "textoIntro";
            this.textoIntro.Size = new System.Drawing.Size(490, 230);
            this.textoIntro.TabIndex = 0;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Black;
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProsseguir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProsseguir.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir.Location = new System.Drawing.Point(375, 433);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(170, 38);
            this.btnProsseguir.TabIndex = 19;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // telaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.vila;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.textoIntro);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(20, 20);
            this.Name = "telaJogo";
            this.Text = "O Culto do Abismo";
            this.Load += new System.EventHandler(this.telaJogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label textoIntro;
        private Button btnProsseguir;
    }
}