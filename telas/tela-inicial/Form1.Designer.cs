namespace tela_inicial
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 22, 38);
            button1.FlatAppearance.BorderColor = Color.FromArgb(247, 247, 247);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(139, 107);
            button1.Name = "button1";
            button1.Size = new Size(254, 52);
            button1.TabIndex = 0;
            button1.Text = "INICIAR JOGO";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(204, 22, 38);
            button2.FlatAppearance.BorderColor = Color.FromArgb(247, 247, 247);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(139, 188);
            button2.Name = "button2";
            button2.Size = new Size(254, 52);
            button2.TabIndex = 4;
            button2.Text = "CRÉDITOS";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(204, 22, 38);
            button3.FlatAppearance.BorderColor = Color.FromArgb(247, 247, 247);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(139, 269);
            button3.Name = "button3";
            button3.Size = new Size(254, 52);
            button3.TabIndex = 5;
            button3.Text = "SAIR";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 472);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(920, 496);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}