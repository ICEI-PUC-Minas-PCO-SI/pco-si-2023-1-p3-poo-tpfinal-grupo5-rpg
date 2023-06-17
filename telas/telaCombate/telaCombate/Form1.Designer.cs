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
            this.vidaProtagonista = new System.Windows.Forms.ProgressBar();
            this.manaProtagonista = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.moedasPlayer = new System.Windows.Forms.Label();
            this.btnAtaqBase = new System.Windows.Forms.Button();
            this.btnAtaqMedio = new System.Windows.Forms.Button();
            this.btnAtaqEspecial = new System.Windows.Forms.Button();
            this.btnDefesa = new System.Windows.Forms.Button();
            this.btnConsItem = new System.Windows.Forms.Button();
            this.inventario = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.vidaInimigo = new System.Windows.Forms.ProgressBar();
            this.nomeInimigo = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgInimigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::telaCombate.Properties.Resources.vila02;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // vidaProtagonista
            // 
            this.vidaProtagonista.BackColor = System.Drawing.Color.Black;
            this.vidaProtagonista.ForeColor = System.Drawing.Color.Red;
            this.vidaProtagonista.Location = new System.Drawing.Point(67, 23);
            this.vidaProtagonista.Name = "vidaProtagonista";
            this.vidaProtagonista.Size = new System.Drawing.Size(141, 23);
            this.vidaProtagonista.TabIndex = 1;
            // 
            // manaProtagonista
            // 
            this.manaProtagonista.BackColor = System.Drawing.Color.Black;
            this.manaProtagonista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.manaProtagonista.Location = new System.Drawing.Point(67, 88);
            this.manaProtagonista.Name = "manaProtagonista";
            this.manaProtagonista.Size = new System.Drawing.Size(141, 23);
            this.manaProtagonista.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 51);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 51);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(254, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 51);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // moedasPlayer
            // 
            this.moedasPlayer.AutoSize = true;
            this.moedasPlayer.BackColor = System.Drawing.Color.Green;
            this.moedasPlayer.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moedasPlayer.ForeColor = System.Drawing.Color.Gold;
            this.moedasPlayer.Location = new System.Drawing.Point(309, 35);
            this.moedasPlayer.Name = "moedasPlayer";
            this.moedasPlayer.Size = new System.Drawing.Size(47, 35);
            this.moedasPlayer.TabIndex = 6;
            this.moedasPlayer.Text = "20";
            this.moedasPlayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAtaqBase
            // 
            this.btnAtaqBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAtaqBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaqBase.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqBase.Location = new System.Drawing.Point(21, 209);
            this.btnAtaqBase.Name = "btnAtaqBase";
            this.btnAtaqBase.Size = new System.Drawing.Size(122, 31);
            this.btnAtaqBase.TabIndex = 7;
            this.btnAtaqBase.Text = "Ataque base";
            this.btnAtaqBase.UseVisualStyleBackColor = false;
            // 
            // btnAtaqMedio
            // 
            this.btnAtaqMedio.BackColor = System.Drawing.Color.Red;
            this.btnAtaqMedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaqMedio.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqMedio.Location = new System.Drawing.Point(21, 246);
            this.btnAtaqMedio.Name = "btnAtaqMedio";
            this.btnAtaqMedio.Size = new System.Drawing.Size(122, 31);
            this.btnAtaqMedio.TabIndex = 8;
            this.btnAtaqMedio.Text = "Ataque médio";
            this.btnAtaqMedio.UseVisualStyleBackColor = false;
            // 
            // btnAtaqEspecial
            // 
            this.btnAtaqEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtaqEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaqEspecial.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtaqEspecial.Location = new System.Drawing.Point(21, 283);
            this.btnAtaqEspecial.Name = "btnAtaqEspecial";
            this.btnAtaqEspecial.Size = new System.Drawing.Size(122, 31);
            this.btnAtaqEspecial.TabIndex = 9;
            this.btnAtaqEspecial.Text = "Ataque especial";
            this.btnAtaqEspecial.UseVisualStyleBackColor = false;
            // 
            // btnDefesa
            // 
            this.btnDefesa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDefesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefesa.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDefesa.Location = new System.Drawing.Point(21, 357);
            this.btnDefesa.Name = "btnDefesa";
            this.btnDefesa.Size = new System.Drawing.Size(122, 31);
            this.btnDefesa.TabIndex = 10;
            this.btnDefesa.Text = "Defesa";
            this.btnDefesa.UseVisualStyleBackColor = false;
            // 
            // btnConsItem
            // 
            this.btnConsItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsItem.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsItem.Location = new System.Drawing.Point(21, 409);
            this.btnConsItem.Name = "btnConsItem";
            this.btnConsItem.Size = new System.Drawing.Size(122, 31);
            this.btnConsItem.TabIndex = 11;
            this.btnConsItem.Text = "Consumir item";
            this.btnConsItem.UseVisualStyleBackColor = false;
            // 
            // inventario
            // 
            this.inventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.inventario.Location = new System.Drawing.Point(0, 502);
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(932, 59);
            this.inventario.TabIndex = 12;
            this.inventario.UseCompatibleStateImageBehavior = false;
            this.inventario.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Brown;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(577, 246);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 51);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // vidaInimigo
            // 
            this.vidaInimigo.BackColor = System.Drawing.Color.Black;
            this.vidaInimigo.ForeColor = System.Drawing.Color.Red;
            this.vidaInimigo.Location = new System.Drawing.Point(632, 272);
            this.vidaInimigo.Name = "vidaInimigo";
            this.vidaInimigo.Size = new System.Drawing.Size(141, 23);
            this.vidaInimigo.TabIndex = 14;
            // 
            // nomeInimigo
            // 
            this.nomeInimigo.AutoSize = true;
            this.nomeInimigo.BackColor = System.Drawing.Color.White;
            this.nomeInimigo.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeInimigo.ForeColor = System.Drawing.Color.Black;
            this.nomeInimigo.Location = new System.Drawing.Point(640, 245);
            this.nomeInimigo.Name = "nomeInimigo";
            this.nomeInimigo.Size = new System.Drawing.Size(117, 20);
            this.nomeInimigo.TabIndex = 15;
            this.nomeInimigo.Text = "Nome inimigo";
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(230, 310);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(117, 186);
            this.imgPlayer.TabIndex = 17;
            this.imgPlayer.TabStop = false;
            // 
            // imgInimigo
            // 
            this.imgInimigo.Image = ((System.Drawing.Image)(resources.GetObject("imgInimigo.Image")));
            this.imgInimigo.Location = new System.Drawing.Point(640, 310);
            this.imgInimigo.Name = "imgInimigo";
            this.imgInimigo.Size = new System.Drawing.Size(117, 186);
            this.imgInimigo.TabIndex = 18;
            this.imgInimigo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 558);
            this.Controls.Add(this.imgInimigo);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.nomeInimigo);
            this.Controls.Add(this.vidaInimigo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.inventario);
            this.Controls.Add(this.btnConsItem);
            this.Controls.Add(this.btnDefesa);
            this.Controls.Add(this.btnAtaqEspecial);
            this.Controls.Add(this.btnAtaqMedio);
            this.Controls.Add(this.btnAtaqBase);
            this.Controls.Add(this.moedasPlayer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.manaProtagonista);
            this.Controls.Add(this.vidaProtagonista);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Batalha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInimigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar vidaProtagonista;
        private ProgressBar manaProtagonista;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label moedasPlayer;
        private Button btnAtaqBase;
        private Button btnAtaqMedio;
        private Button btnAtaqEspecial;
        private Button btnDefesa;
        private Button btnConsItem;
        private ListView inventario;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private PictureBox pictureBox5;
        private ProgressBar vidaInimigo;
        private Label nomeInimigo;
        private PictureBox imgPlayer;
        private PictureBox imgInimigo;
    }
}