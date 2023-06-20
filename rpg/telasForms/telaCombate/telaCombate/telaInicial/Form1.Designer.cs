namespace telaInicial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnIniciarJogo = new Button();
            btnJogo = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(280, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 145);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarJogo
            // 
            btnIniciarJogo.BackColor = Color.FromArgb(23, 26, 33);
            btnIniciarJogo.Cursor = Cursors.Hand;
            btnIniciarJogo.FlatStyle = FlatStyle.Flat;
            btnIniciarJogo.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarJogo.ForeColor = Color.White;
            btnIniciarJogo.Location = new Point(334, 300);
            btnIniciarJogo.Name = "btnIniciarJogo";
            btnIniciarJogo.Size = new Size(198, 41);
            btnIniciarJogo.TabIndex = 3;
            btnIniciarJogo.Text = "INICIAR JOGO";
            btnIniciarJogo.UseVisualStyleBackColor = false;
            // 
            // btnJogo
            // 
            btnJogo.BackColor = Color.FromArgb(23, 26, 33);
            btnJogo.Cursor = Cursors.Hand;
            btnJogo.FlatStyle = FlatStyle.Flat;
            btnJogo.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogo.ForeColor = Color.White;
            btnJogo.Location = new Point(334, 357);
            btnJogo.Name = "btnJogo";
            btnJogo.Size = new Size(198, 41);
            btnJogo.TabIndex = 4;
            btnJogo.Text = "SAIR";
            btnJogo.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(280, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(305, 273);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnJogo);
            Controls.Add(btnIniciarJogo);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIniciarJogo;
        private Button btnJogo;
        private PictureBox pictureBox2;
    }
}