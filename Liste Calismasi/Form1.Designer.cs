namespace Liste_Calismasi
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            textBox5 = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Location = new Point(206, 50);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Adiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadiniz";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(253, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Location = new Point(253, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(253, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 152);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Mesleginiz";
            // 
            // button2
            // 
            button2.Location = new Point(26, 197);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 94);
            listBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(102, 197);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "aktar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(257, 148);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "ara";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(225, 73);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "arayacaginiz kelimeyi yaziniz";
            textBox4.Size = new Size(168, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(414, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 443);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Girilecek Bilgiler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1397720391_170x170;
            pictureBox1.Location = new Point(29, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 136);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 64, 0);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(-2, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 257);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kaydedilen Bilgiler";
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Location = new Point(147, 90);
            button5.Name = "button5";
            button5.Size = new Size(75, 42);
            button5.TabIndex = 15;
            button5.Text = "hesapla";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(368, 34);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(51, 48);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(46, 48);
            label4.Name = "label4";
            label4.Size = new Size(286, 17);
            label4.TabIndex = 13;
            label4.Text = "ARA KISMINA YAZILAN YAZINI GELME OLASILIGI";
            label4.Click += label4_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaptionText;
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(-2, 262);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(790, 186);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Olasılık";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__2_;
            pictureBox2.Location = new Point(488, -22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 208);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Label label4;
        private Button button5;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}