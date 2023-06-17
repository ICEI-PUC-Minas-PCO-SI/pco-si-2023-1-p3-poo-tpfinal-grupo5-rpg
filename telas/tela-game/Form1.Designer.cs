namespace tela_game
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
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewImageColumn();
            Column3 = new DataGridViewImageColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 26, 33);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 150);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(635, 90);
            button3.Name = "button3";
            button3.Size = new Size(193, 34);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(180, 90);
            button1.Name = "button1";
            button1.Size = new Size(193, 34);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(407, 90);
            button2.Name = "button2";
            button2.Size = new Size(193, 34);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(141, 24);
            label1.Name = "label1";
            label1.Size = new Size(728, 28);
            label1.TabIndex = 3;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum rutrum magna.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 26, 33);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(0, 361);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 62);
            panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(0, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(922, 54);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 157;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 157;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 157;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 157;
            // 
            // Column5
            // 
            Column5.HeaderText = "";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 157;
            // 
            // Column6
            // 
            Column6.HeaderText = "";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 157;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(920, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewImageColumn Column1;
        private DataGridViewImageColumn Column2;
        private DataGridViewImageColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}