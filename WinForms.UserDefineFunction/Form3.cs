using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms.UserDefineFunction
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letters = textBox1.Text;
            int size = int.Parse(textBox2.Text);
            int type = 1;
           // if (radioButton1.Checked) { type = 1; textBox3.Text = letterTriangle1(letters, size); }
           // else if (radioButton2.Checked) { type = 2; textBox3.Text = letterTriangle2(letters); }
            //else if (radioButton3.Checked) { letterTriangle3(letters, size, out string result ); }

        }
    }
}
