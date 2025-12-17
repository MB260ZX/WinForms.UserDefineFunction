namespace WinForms.UserDefineFunction
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 41);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "ต้องไม่ต่ำกว่า 2 ตัว";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 148);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "ชื่อผู้ใช้บัญชี";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 199);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "รหัสผ่าน";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 247);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 7;
            label5.Text = "ยืนยันรหัสผ่าน";
            // 
            // button1
            // 
            button1.Location = new Point(153, 354);
            button1.Name = "button1";
            button1.Size = new Size(174, 44);
            button1.TabIndex = 9;
            button1.Text = "สมัครสมาชิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 155);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 10;
            label6.Text = "ไม่เกิน 20 ตัว";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 206);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 11;
            label7.Text = "ต้องไม่ต่ำกว่า 8 ตัว";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(394, 91);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 14;
            label8.Text = "ต้องไม่ต่ำกว่า 2 ตัว";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 91);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(265, 27);
            textBox5.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 91);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 12;
            label9.Text = "นามสกุล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
    }
}
