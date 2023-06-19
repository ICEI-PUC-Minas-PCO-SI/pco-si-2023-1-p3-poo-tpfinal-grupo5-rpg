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
            this.nomeInimigo = new System.Windows.Forms.Label();
            this.btnAtaqBase = new System.Windows.Forms.Button();
            this.btnAtaqMedio = new System.Windows.Forms.Button();
            this.btnAtqEsp = new System.Windows.Forms.Button();
            this.btnDefesa = new System.Windows.Forms.Button();
            this.btnUsarItem = new System.Windows.Forms.Button();
            this.inventario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblInformacoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCenario
            // 
            this.imgCenario.Image = global::telaCombate.Properties.Resources.caverna;
            this.imgCenario.Location = new System.Drawing.Point(-14, 0);
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
            this.playerImg.Location = new System.Drawing.Point(204, 188);
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
            this.imgInimigo.Location = new System.Drawing.Point(603, 188);
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
            this.pictureBox4.Location = new System.Drawing.Point(569, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // vidaInimigo
            // 
            this.vidaInimigo.BackColor = System.Drawing.Color.Red;
            this.vidaInimigo.Location = new System.Drawing.Point(625, 152);
            this.vidaInimigo.Name = "vidaInimigo";
            this.vidaInimigo.Size = new System.Drawing.Size(127, 23);
            this.vidaInimigo.TabIndex = 10;
            // 
            // nomeInimigo
            // 
            this.nomeInimigo.AutoSize = true;
            this.nomeInimigo.BackColor = System.Drawing.Color.White;
            this.nomeInimigo.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeInimigo.ForeColor = System.Drawing.Color.Black;
            this.nomeInimigo.Location = new System.Drawing.Point(650, 128);
            this.nomeInimigo.Name = "nomeInimigo";
            this.nomeInimigo.Size = new System.Drawing.Size(72, 17);
            this.nomeInimigo.TabIndex = 11;
            this.nomeInimigo.Text = "Cultista";
            // 
            // btnAtaqBase
            // 
            this.btnAtaqBase.BackColor = System.Drawing.Color.Maroon;
            this.btnAtaqBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtaqBase.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqBase.Location = new System.Drawing.Point(24, 188);
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
            this.btnAtaqMedio.Location = new System.Drawing.Point(24, 229);
            this.btnAtaqMedio.Name = "btnAtaqMedio";
            this.btnAtaqMedio.Size = new System.Drawing.Size(161, 35);
            this.btnAtaqMedio.TabIndex = 13;
            this.btnAtaqMedio.Text = "Ataque médio";
            this.btnAtaqMedio.UseVisualStyleBackColor = false;
            this.btnAtaqMedio.Click += new System.EventHandler(this.btnAtaqMedio_Click);
            // 
            // btnAtqEsp
            // 
            this.btnAtqEsp.BackColor = System.Drawing.Color.Maroon;
            this.btnAtqEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtqEsp.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtqEsp.Location = new System.Drawing.Point(24, 270);
            this.btnAtqEsp.Name = "btnAtqEsp";
            this.btnAtqEsp.Size = new System.Drawing.Size(161, 35);
            this.btnAtqEsp.TabIndex = 14;
            this.btnAtqEsp.Text = "Ataque especial";
            this.btnAtqEsp.UseVisualStyleBackColor = false;
            // 
            // btnDefesa
            // 
            this.btnDefesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDefesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefesa.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDefesa.Location = new System.Drawing.Point(24, 321);
            this.btnDefesa.Name = "btnDefesa";
            this.btnDefesa.Size = new System.Drawing.Size(161, 35);
            this.btnDefesa.TabIndex = 15;
            this.btnDefesa.Text = "Defesa";
            this.btnDefesa.UseVisualStyleBackColor = false;
            // 
            // btnUsarItem
            // 
            this.btnUsarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUsarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsarItem.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsarItem.Location = new System.Drawing.Point(24, 373);
            this.btnUsarItem.Name = "btnUsarItem";
            this.btnUsarItem.Size = new System.Drawing.Size(161, 35);
            this.btnUsarItem.TabIndex = 16;
            this.btnUsarItem.Text = "Usar item";
            this.btnUsarItem.UseVisualStyleBackColor = false;
            // 
            // inventario
            // 
            this.inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.inventario.Location = new System.Drawing.Point(0, 438);
            this.inventario.Name = "inventario";
            this.inventario.RowTemplate.Height = 25;
            this.inventario.Size = new System.Drawing.Size(928, 86);
            this.inventario.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Image = global::telaCombate.Properties.Resources.vidaPocao;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Image = global::telaCombate.Properties.Resources.manaPocao;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.inventario);
            this.Controls.Add(this.btnUsarItem);
            this.Controls.Add(this.btnDefesa);
            this.Controls.Add(this.btnAtqEsp);
            this.Controls.Add(this.btnAtaqMedio);
            this.Controls.Add(this.btnAtaqBase);
            this.Controls.Add(this.nomeInimigo);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Combate";
            ((System.ComponentModel.ISupportInitialize)(this.imgCenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario)).EndInit();
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
        private Label nomeInimigo;
        private Button btnAtaqBase;
        private Button btnAtaqMedio;
        private Button btnAtqEsp;
        private Button btnDefesa;
        private Button btnUsarItem;
        private DataGridView inventario;
        private DataGridViewImageColumn Column1;
        private DataGridViewImageColumn Column2;
        private DataGridViewImageColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
        private DataGridViewImageColumn Column7;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
        private Label lblInformacoes;
    }
}