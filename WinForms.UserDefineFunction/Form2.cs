using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.0, weight = 0.0, triangleArea = 0.0;
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out weight))
            {
                triangleArea = CalculateTriangleArea(height, weight);
                label5.Text = triangleArea.ToString("F2");
            }

        }


        private double CalculateTriangleArea(double height, double weight)
        {
            double area = 0.5 * height * weight;
            return area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = 0.0, circleArea = 0.0;
            if (double.TryParse(textBox3.Text, out radius))
            {
                radius = CalculateCircumradius(radius);
                label17.Text = radius.ToString("F2");
                circleArea = CalculateCircleArea(radius);
                label10.Text = circleArea.ToString("F2");
            }

        }

        private double CalculateCircumradius(double radius)
        {
            return 2 * Math.PI * radius;
        }

        private double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox4.Text, out i))
            {
                label10.Text = i.ToString();
                label19.Text = MOG(ref i).ToString();
                textBox3.Text = i.ToString();
            }
        }

        private object MOG(ref int x)
        {
            Random rnd = new Random();
            x += rnd.Next(1, 100);
            return x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sumary = 0.0;
            string[] inputs = textBox5.Lines;
            double[] numbers = new double[inputs.Length];
            for(int i = 0; i < inputs.Length; i++)
            {
                if(!double.TryParse(inputs[i], out numbers[i]))
                {
                    numbers[i] = 0.0;
                }

            }
            sumary = CalculateSumary(numbers);
            MessageBox.Show("ผลรวม = " + sumary.ToString("F2"));
        }

        private double CalculateSumary(double[] numbers)
        {
            return numbers.Sum();
        }
    }
}
