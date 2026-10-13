namespace gul_satis
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
            pictureBox2 = new PictureBox();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            güladı = new DataGridViewTextBoxColumn();
            satişsayi = new DataGridViewTextBoxColumn();
            qiymət = new DataGridViewTextBoxColumn();
            yekunqiymət = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(608, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 271);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label4.Location = new Point(611, 404);
            label4.Name = "label4";
            label4.Size = new Size(237, 50);
            label4.TabIndex = 9;
            label4.Text = "toplam gəlir:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(39, 371);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 357);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "gül məlumatları";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(338, 247);
            button1.Name = "button1";
            button1.Size = new Size(159, 67);
            button1.TabIndex = 26;
            button1.Text = "satış et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(317, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label1.Location = new Point(9, 71);
            label1.Name = "label1";
            label1.Size = new Size(171, 50);
            label1.TabIndex = 22;
            label1.Text = "gül növü";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 57);
            textBox1.TabIndex = 19;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(158, 275);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(120, 57);
            maskedTextBox2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label3.Location = new Point(149, 209);
            label3.Name = "label3";
            label3.Size = new Size(139, 50);
            label3.TabIndex = 24;
            label3.Text = "qiymət";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label2.Location = new Point(15, 209);
            label2.Name = "label2";
            label2.Size = new Size(76, 50);
            label2.TabIndex = 23;
            label2.Text = "say";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(15, 275);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(120, 57);
            maskedTextBox1.TabIndex = 20;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Location = new Point(690, 659);
            button2.Name = "button2";
            button2.Size = new Size(73, 46);
            button2.TabIndex = 27;
            button2.Text = "cixis";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { güladı, satişsayi, qiymət, yekunqiymət });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(941, 300);
            dataGridView1.TabIndex = 28;
            // 
            // güladı
            // 
            güladı.HeaderText = "gül adı";
            güladı.MinimumWidth = 10;
            güladı.Name = "güladı";
            güladı.Width = 200;
            // 
            // satişsayi
            // 
            satişsayi.HeaderText = "satış sayı";
            satişsayi.MinimumWidth = 10;
            satişsayi.Name = "satişsayi";
            satişsayi.Width = 200;
            // 
            // qiymət
            // 
            qiymət.HeaderText = "qiymət";
            qiymət.MinimumWidth = 10;
            qiymət.Name = "qiymət";
            qiymət.Width = 200;
            // 
            // yekunqiymət
            // 
            yekunqiymət.HeaderText = "yekun qiymət";
            yekunqiymət.MinimumWidth = 10;
            yekunqiymət.Name = "yekunqiymət";
            yekunqiymət.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(968, 759);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn güladı;
        private DataGridViewTextBoxColumn satişsayi;
        private DataGridViewTextBoxColumn qiymət;
        private DataGridViewTextBoxColumn yekunqiymət;
    }
}
