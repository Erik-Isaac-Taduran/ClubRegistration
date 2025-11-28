namespace ClubRegistration
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBox4 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(14, 184);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 4;
            label4.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(14, 263);
            label7.Name = "label7";
            label7.Size = new Size(131, 28);
            label7.TabIndex = 7;
            label7.Text = "Middle Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(11, 431);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 524);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 10;
            label6.Text = "Program";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 133);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 216);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 27);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(11, 295);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 27);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(14, 344);
            label8.Name = "label8";
            label8.Size = new Size(47, 28);
            label8.TabIndex = 15;
            label8.Text = "Age";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 376);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(95, 27);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Prefer not say", "Others" });
            comboBox2.Location = new Point(11, 463);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 28);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(96, 728);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(159, 87);
            button3.TabIndex = 20;
            button3.Text = "Confirm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BS Computer Science", "BS Computer Engineering", "BS Information Technology", "BS Tourism in Management", "BS Multimedia Arts", "BS Business Administration", "BS Criminology", "BS Culinary Arts" });
            comboBox1.Location = new Point(11, 556);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(307, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(11, 43);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(208, 28);
            comboBox4.TabIndex = 23;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 853);
            Controls.Add(comboBox4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
    }
}