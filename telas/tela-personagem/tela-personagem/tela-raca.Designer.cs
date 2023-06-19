namespace tela_personagem
{
    partial class tela_raca
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
            picturePersonagem = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            buttonTanque = new Button();
            buttonClerigo = new Button();
            buttonLadino = new Button();
            buttonArqueiro = new Button();
            buttonGuerreiro = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picturePersonagem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picturePersonagem
            // 
            picturePersonagem.Image = Properties.Resources.WhatsApp_Image_2023_06_15_at_21_50_44;
            picturePersonagem.Location = new Point(0, 0);
            picturePersonagem.Name = "picturePersonagem";
            picturePersonagem.Size = new Size(494, 471);
            picturePersonagem.TabIndex = 3;
            picturePersonagem.TabStop = false;
            picturePersonagem.Click += picturePersonagem_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Zhihu;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(305, 443);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(107, 60);
            iconButton1.TabIndex = 6;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(222, 22, 34);
            label1.Location = new Point(19, 95);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 5;
            label1.Text = "Escolha sua raça:";
            // 
            // buttonTanque
            // 
            buttonTanque.BackColor = Color.FromArgb(224, 22, 38);
            buttonTanque.Cursor = Cursors.Hand;
            buttonTanque.FlatStyle = FlatStyle.Flat;
            buttonTanque.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTanque.Location = new Point(228, 310);
            buttonTanque.Name = "buttonTanque";
            buttonTanque.Size = new Size(120, 78);
            buttonTanque.TabIndex = 4;
            buttonTanque.Text = "Gnomo";
            buttonTanque.UseVisualStyleBackColor = false;
            // 
            // buttonClerigo
            // 
            buttonClerigo.BackColor = Color.FromArgb(224, 22, 38);
            buttonClerigo.Cursor = Cursors.Hand;
            buttonClerigo.FlatStyle = FlatStyle.Flat;
            buttonClerigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClerigo.Location = new Point(86, 310);
            buttonClerigo.Name = "buttonClerigo";
            buttonClerigo.Size = new Size(120, 78);
            buttonClerigo.TabIndex = 3;
            buttonClerigo.Text = "Orc";
            buttonClerigo.UseVisualStyleBackColor = false;
            // 
            // buttonLadino
            // 
            buttonLadino.BackColor = Color.FromArgb(224, 22, 38);
            buttonLadino.Cursor = Cursors.Hand;
            buttonLadino.FlatStyle = FlatStyle.Flat;
            buttonLadino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLadino.Location = new Point(301, 216);
            buttonLadino.Name = "buttonLadino";
            buttonLadino.Size = new Size(120, 78);
            buttonLadino.TabIndex = 2;
            buttonLadino.Text = "Anão";
            buttonLadino.UseVisualStyleBackColor = false;
            // 
            // buttonArqueiro
            // 
            buttonArqueiro.BackColor = Color.FromArgb(224, 22, 38);
            buttonArqueiro.Cursor = Cursors.Hand;
            buttonArqueiro.FlatStyle = FlatStyle.Flat;
            buttonArqueiro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonArqueiro.Location = new Point(162, 216);
            buttonArqueiro.Name = "buttonArqueiro";
            buttonArqueiro.Size = new Size(120, 78);
            buttonArqueiro.TabIndex = 1;
            buttonArqueiro.Text = "Elfo";
            buttonArqueiro.UseVisualStyleBackColor = false;
            // 
            // buttonGuerreiro
            // 
            buttonGuerreiro.BackColor = Color.FromArgb(224, 22, 38);
            buttonGuerreiro.Cursor = Cursors.Hand;
            buttonGuerreiro.FlatStyle = FlatStyle.Flat;
            buttonGuerreiro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuerreiro.Location = new Point(21, 216);
            buttonGuerreiro.Name = "buttonGuerreiro";
            buttonGuerreiro.Size = new Size(120, 78);
            buttonGuerreiro.TabIndex = 0;
            buttonGuerreiro.Text = "Humano";
            buttonGuerreiro.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonTanque);
            panel1.Controls.Add(buttonClerigo);
            panel1.Controls.Add(buttonLadino);
            panel1.Controls.Add(buttonArqueiro);
            panel1.Controls.Add(buttonGuerreiro);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(500, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 515);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 22, 34);
            label2.Location = new Point(0, 474);
            label2.Name = "label2";
            label2.Padding = new Padding(120, 0, 0, 0);
            label2.Size = new Size(403, 41);
            label2.TabIndex = 4;
            label2.Text = "Nome Personagem";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // tela_raca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(924, 515);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(picturePersonagem);
            Name = "tela_raca";
            Text = "Raça do Personagem";
            ((System.ComponentModel.ISupportInitialize)picturePersonagem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturePersonagem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Button buttonTanque;
        private Button buttonClerigo;
        private Button buttonLadino;
        private Button buttonArqueiro;
        private Button buttonGuerreiro;
        private Panel panel1;
        private Label label2;
    }
}