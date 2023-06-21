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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.moedasPersonagem = new System.Windows.Forms.Label();
            this.playerImg = new System.Windows.Forms.PictureBox();
            this.imgInimigo = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.nomeInimigo = new System.Windows.Forms.Label();
            this.btnAtaqBase = new System.Windows.Forms.Button();
            this.btnAtaqMedio = new System.Windows.Forms.Button();
            this.btnUsarItem = new System.Windows.Forms.Button();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.vidaPersonagem = new System.Windows.Forms.Label();
            this.btnBatalhar = new System.Windows.Forms.Button();
            this.manaPersonagem = new System.Windows.Forms.Label();
            this.vidaInimigo = new System.Windows.Forms.Label();
            this.nomeInventario = new System.Windows.Forms.Label();
            this.listInventario = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnAtaqEspecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.playerImg.BackColor = System.Drawing.Color.Transparent;
            this.playerImg.Location = new System.Drawing.Point(193, 167);
            this.playerImg.Name = "playerImg";
            this.playerImg.Size = new System.Drawing.Size(149, 244);
            this.playerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImg.TabIndex = 7;
            this.playerImg.TabStop = false;
            this.playerImg.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // imgInimigo
            // 
            this.imgInimigo.BackColor = System.Drawing.Color.Transparent;
            this.imgInimigo.Image = global::telaCombate.Properties.Resources.javali;
            this.imgInimigo.Location = new System.Drawing.Point(569, 167);
            this.imgInimigo.Name = "imgInimigo";
            this.imgInimigo.Size = new System.Drawing.Size(169, 244);
            this.imgInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInimigo.TabIndex = 8;
            this.imgInimigo.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Image = global::telaCombate.Properties.Resources.vida;
            this.pictureBox4.Location = new System.Drawing.Point(569, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // nomeInimigo
            // 
            this.nomeInimigo.AutoSize = true;
            this.nomeInimigo.BackColor = System.Drawing.Color.Transparent;
            this.nomeInimigo.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeInimigo.ForeColor = System.Drawing.Color.Black;
            this.nomeInimigo.Location = new System.Drawing.Point(633, 98);
            this.nomeInimigo.Name = "nomeInimigo";
            this.nomeInimigo.Size = new System.Drawing.Size(96, 17);
            this.nomeInimigo.TabIndex = 11;
            this.nomeInimigo.Text = "nomeInimigo";
            // 
            // btnAtaqBase
            // 
            this.btnAtaqBase.BackColor = System.Drawing.Color.Maroon;
            this.btnAtaqBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtaqBase.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqBase.Location = new System.Drawing.Point(24, 187);
            this.btnAtaqBase.Name = "btnAtaqBase";
            this.btnAtaqBase.Size = new System.Drawing.Size(161, 35);
            this.btnAtaqBase.TabIndex = 12;
            this.btnAtaqBase.Text = "Ataque base";
            this.btnAtaqBase.UseVisualStyleBackColor = false;
            this.btnAtaqBase.Click += new System.EventHandler(this.btnAtaqBase_Click);
            // 
            // btnAtaqMedio
            // 
            this.btnAtaqMedio.BackColor = System.Drawing.Color.Maroon;
            this.btnAtaqMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtaqMedio.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqMedio.Location = new System.Drawing.Point(24, 230);
            this.btnAtaqMedio.Name = "btnAtaqMedio";
            this.btnAtaqMedio.Size = new System.Drawing.Size(161, 35);
            this.btnAtaqMedio.TabIndex = 13;
            this.btnAtaqMedio.Text = "Ataque médio";
            this.btnAtaqMedio.UseVisualStyleBackColor = false;
            this.btnAtaqMedio.Click += new System.EventHandler(this.btnAtaqMedio_Click);
            // 
            // btnUsarItem
            // 
            this.btnUsarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUsarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsarItem.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsarItem.Location = new System.Drawing.Point(26, 340);
            this.btnUsarItem.Name = "btnUsarItem";
            this.btnUsarItem.Size = new System.Drawing.Size(161, 35);
            this.btnUsarItem.TabIndex = 16;
            this.btnUsarItem.Text = "Usar item";
            this.btnUsarItem.UseVisualStyleBackColor = false;
            this.btnUsarItem.Click += new System.EventHandler(this.btnUsarItem_Click);
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacoes.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacoes.Location = new System.Drawing.Point(242, 167);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(0, 17);
            this.lblInformacoes.TabIndex = 18;
            // 
            // vidaPersonagem
            // 
            this.vidaPersonagem.AutoSize = true;
            this.vidaPersonagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vidaPersonagem.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vidaPersonagem.ForeColor = System.Drawing.Color.White;
            this.vidaPersonagem.Location = new System.Drawing.Point(82, 35);
            this.vidaPersonagem.Name = "vidaPersonagem";
            this.vidaPersonagem.Size = new System.Drawing.Size(84, 28);
            this.vidaPersonagem.TabIndex = 19;
            this.vidaPersonagem.Text = "label1";
            // 
            // btnBatalhar
            // 
            this.btnBatalhar.BackColor = System.Drawing.Color.Yellow;
            this.btnBatalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalhar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatalhar.Location = new System.Drawing.Point(376, 270);
            this.btnBatalhar.Name = "btnBatalhar";
            this.btnBatalhar.Size = new System.Drawing.Size(161, 35);
            this.btnBatalhar.TabIndex = 21;
            this.btnBatalhar.Text = "Iniciar Combate";
            this.btnBatalhar.UseVisualStyleBackColor = false;
            this.btnBatalhar.Click += new System.EventHandler(this.btnBatalhar_Click);
            // 
            // manaPersonagem
            // 
            this.manaPersonagem.AutoSize = true;
            this.manaPersonagem.BackColor = System.Drawing.Color.MidnightBlue;
            this.manaPersonagem.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manaPersonagem.ForeColor = System.Drawing.Color.White;
            this.manaPersonagem.Location = new System.Drawing.Point(82, 104);
            this.manaPersonagem.Name = "manaPersonagem";
            this.manaPersonagem.Size = new System.Drawing.Size(84, 28);
            this.manaPersonagem.TabIndex = 22;
            this.manaPersonagem.Text = "label1";
            // 
            // vidaInimigo
            // 
            this.vidaInimigo.AutoSize = true;
            this.vidaInimigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vidaInimigo.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vidaInimigo.ForeColor = System.Drawing.Color.White;
            this.vidaInimigo.Location = new System.Drawing.Point(640, 119);
            this.vidaInimigo.Name = "vidaInimigo";
            this.vidaInimigo.Size = new System.Drawing.Size(84, 28);
            this.vidaInimigo.TabIndex = 23;
            this.vidaInimigo.Text = "label1";
            // 
            // nomeInventario
            // 
            this.nomeInventario.AutoSize = true;
            this.nomeInventario.BackColor = System.Drawing.Color.Black;
            this.nomeInventario.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeInventario.ForeColor = System.Drawing.Color.White;
            this.nomeInventario.Location = new System.Drawing.Point(26, 429);
            this.nomeInventario.Name = "nomeInventario";
            this.nomeInventario.Size = new System.Drawing.Size(100, 21);
            this.nomeInventario.TabIndex = 24;
            this.nomeInventario.Text = "Inventário";
            // 
            // listInventario
            // 
            this.listInventario.BackColor = System.Drawing.Color.Black;
            this.listInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listInventario.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listInventario.ForeColor = System.Drawing.Color.White;
            this.listInventario.Location = new System.Drawing.Point(24, 455);
            this.listInventario.Name = "listInventario";
            this.listInventario.Size = new System.Drawing.Size(878, 63);
            this.listInventario.TabIndex = 25;
            this.listInventario.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 500;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 500;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 500;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 500;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 500;
            // 
            // btnAtaqEspecial
            // 
            this.btnAtaqEspecial.BackColor = System.Drawing.Color.Maroon;
            this.btnAtaqEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtaqEspecial.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqEspecial.Location = new System.Drawing.Point(24, 274);
            this.btnAtaqEspecial.Name = "btnAtaqEspecial";
            this.btnAtaqEspecial.Size = new System.Drawing.Size(161, 35);
            this.btnAtaqEspecial.TabIndex = 26;
            this.btnAtaqEspecial.Text = "Ataque especial";
            this.btnAtaqEspecial.UseVisualStyleBackColor = false;
            this.btnAtaqEspecial.Click += new System.EventHandler(this.btnAtaqEspecial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::telaCombate.Properties.Resources.floresta1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.btnAtaqEspecial);
            this.Controls.Add(this.listInventario);
            this.Controls.Add(this.nomeInventario);
            this.Controls.Add(this.vidaInimigo);
            this.Controls.Add(this.manaPersonagem);
            this.Controls.Add(this.btnBatalhar);
            this.Controls.Add(this.vidaPersonagem);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.btnUsarItem);
            this.Controls.Add(this.btnAtaqMedio);
            this.Controls.Add(this.btnAtaqBase);
            this.Controls.Add(this.nomeInimigo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.imgInimigo);
            this.Controls.Add(this.playerImg);
            this.Controls.Add(this.moedasPersonagem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Combate";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label moedasPersonagem;
        private PictureBox playerImg;
        private PictureBox imgInimigo;
        private PictureBox pictureBox4;
        private Label nomeInimigo;
        private Button btnAtaqBase;
        private Button btnAtaqMedio;
        private Button btnUsarItem;
        private Label lblInformacoes;
        private Label vidaPersonagem;
        private Button btnBatalhar;
        private Label manaPersonagem;
        private Label vidaInimigo;
        private Label nomeInventario;
        private ListView listInventario;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnAtaqEspecial;
    }
}