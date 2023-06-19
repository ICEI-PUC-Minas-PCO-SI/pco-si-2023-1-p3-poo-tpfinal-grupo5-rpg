namespace telaCombate
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
            this.imgCenario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.vidaPersonagem = new System.Windows.Forms.ProgressBar();
            this.manaPersonagem = new System.Windows.Forms.ProgressBar();
            this.moedasPersonagem = new System.Windows.Forms.Label();
            this.playerImg = new System.Windows.Forms.PictureBox();
            this.imgInimigo = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.vidaInimigo = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtaq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCenario
            // 
            this.imgCenario.Image = global::telaCombate.Properties.Resources.caverna;
            this.imgCenario.Location = new System.Drawing.Point(0, 0);
            this.imgCenario.Name = "imgCenario";
            this.imgCenario.Size = new System.Drawing.Size(928, 524);
            this.imgCenario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCenario.TabIndex = 0;
            this.imgCenario.TabStop = false;
            this.imgCenario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::telaCombate.Properties.Resources.vida;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Image = global::telaCombate.Properties.Resources.moeda;
            this.pictureBox3.Location = new System.Drawing.Point(292, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // vidaPersonagem
            // 
            this.vidaPersonagem.BackColor = System.Drawing.Color.Red;
            this.vidaPersonagem.Location = new System.Drawing.Point(82, 34);
            this.vidaPersonagem.Name = "vidaPersonagem";
            this.vidaPersonagem.Size = new System.Drawing.Size(127, 23);
            this.vidaPersonagem.TabIndex = 4;
            // 
            // manaPersonagem
            // 
            this.manaPersonagem.BackColor = System.Drawing.Color.RoyalBlue;
            this.manaPersonagem.Location = new System.Drawing.Point(82, 106);
            this.manaPersonagem.Name = "manaPersonagem";
            this.manaPersonagem.Size = new System.Drawing.Size(127, 23);
            this.manaPersonagem.TabIndex = 5;
            // 
            // moedasPersonagem
            // 
            this.moedasPersonagem.AutoSize = true;
            this.moedasPersonagem.BackColor = System.Drawing.Color.SeaGreen;
            this.moedasPersonagem.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moedasPersonagem.ForeColor = System.Drawing.Color.Gold;
            this.moedasPersonagem.Location = new System.Drawing.Point(348, 35);
            this.moedasPersonagem.Name = "moedasPersonagem";
            this.moedasPersonagem.Size = new System.Drawing.Size(42, 32);
            this.moedasPersonagem.TabIndex = 6;
            this.moedasPersonagem.Text = "15";
            // 
            // playerImg
            // 
            this.playerImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.playerImg.Image = global::telaCombate.Properties.Resources.ladino;
            this.playerImg.Location = new System.Drawing.Point(179, 267);
            this.playerImg.Name = "playerImg";
            this.playerImg.Size = new System.Drawing.Size(149, 244);
            this.playerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImg.TabIndex = 7;
            this.playerImg.TabStop = false;
            this.playerImg.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // imgInimigo
            // 
            this.imgInimigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.imgInimigo.Image = global::telaCombate.Properties.Resources.cultistaHomem;
            this.imgInimigo.Location = new System.Drawing.Point(603, 267);
            this.imgInimigo.Name = "imgInimigo";
            this.imgInimigo.Size = new System.Drawing.Size(149, 244);
            this.imgInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInimigo.TabIndex = 8;
            this.imgInimigo.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Image = global::telaCombate.Properties.Resources.vida;
            this.pictureBox4.Location = new System.Drawing.Point(544, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // vidaInimigo
            // 
            this.vidaInimigo.BackColor = System.Drawing.Color.Red;
            this.vidaInimigo.Location = new System.Drawing.Point(606, 224);
            this.vidaInimigo.Name = "vidaInimigo";
            this.vidaInimigo.Size = new System.Drawing.Size(127, 23);
            this.vidaInimigo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(626, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cultista";
            // 
            // btnAtaq
            // 
            this.btnAtaq.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtaq.Location = new System.Drawing.Point(12, 267);
            this.btnAtaq.Name = "btnAtaq";
            this.btnAtaq.Size = new System.Drawing.Size(120, 35);
            this.btnAtaq.TabIndex = 12;
            this.btnAtaq.Text = "Ataque base";
            this.btnAtaq.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.btnAtaq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vidaInimigo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.imgInimigo);
            this.Controls.Add(this.playerImg);
            this.Controls.Add(this.moedasPersonagem);
            this.Controls.Add(this.manaPersonagem);
            this.Controls.Add(this.vidaPersonagem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgCenario);
            this.Name = "Form1";
            this.Text = "Combate";
            ((System.ComponentModel.ISupportInitialize)(this.imgCenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imgCenario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ProgressBar vidaPersonagem;
        private ProgressBar manaPersonagem;
        private Label moedasPersonagem;
        private PictureBox playerImg;
        private PictureBox imgInimigo;
        private PictureBox pictureBox4;
        private ProgressBar vidaInimigo;
        private Label label1;
        private Button btnAtaq;
    }
}