using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Policy;
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
            string letter = textBox1.Text;


            int size = 0;
            int.TryParse(textBox2.Text, out size);

            if (radioButton1.Checked)
            {
                // แบบที่ 1: ส่งค่าเป็น Value ปกติ
                textBox3.Text = Triangle1(letter, size);
            }
            else if (radioButton2.Checked)
            {
                // แบบที่ 2: ส่งค่าแบบ Optional กำหนดค่าเริ่มต้น Size = 5

                if (size == 0) // สมมติถ้าไม่ได้กรอกตัวเลข ให้ใช้ค่า Default
                {
                    textBox3.Text = Triangle2(letter);
                }
                else
                {
                    textBox3.Text = Triangle2(letter, size);
                }
            }
            else if (radioButton3.Checked)
            {
                // แบบที่ 3: ส่งค่าแบบ Out Parameter
                string result;
                Triangle3(letter, size, out result);

                // นำค่าที่ได้จากตัวแปร result มาแสดงผล
                textBox3.Text = result;
            }
        }

        private string Triangle1(string letter, int size)
        {
            string str = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    str += letter;
                }
                str += Environment.NewLine; // ขึ้นบรรทัดใหม่
            }
            return str;
        }

        private string Triangle2(string letter, int size = 5)
        {
            string str = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    str += letter;
                }
                str += Environment.NewLine;
            }
            return str;
        }

        private void Triangle3(string letter, int size, out string result)
        {
            result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }
        }


    }
}

