using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        static double size;
        private void button1_Click(object sender, EventArgs e)
        {
            size = (double)numericUpDown1.Value;
            chart1.ChartAreas[0].AxisX.Minimum = -size;
            chart1.ChartAreas[0].AxisX.Maximum = size;
            chart1.ChartAreas[0].AxisY.Minimum = -size;
            chart1.ChartAreas[0].AxisY.Maximum = size;
            double xMin = -size - 1, xMax = size + 1, h = 0.1, x, y;
            string str1 = textBox1.Text.Replace('.', ','), str2 = textBox2.Text.Replace('.', ','), str3 = textBox3.Text.Replace('.', ',');
            bool isDouble1 = double.TryParse(str1, out double a);
            bool isDouble2 = double.TryParse(str2, out double b);
            bool isDouble3 = double.TryParse(str3, out double c);
            if ((!isDouble1 || !isDouble2 || !isDouble3) && comboBox1.SelectedIndex > 0 && comboBox1.SelectedIndex < 5)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка");
                return;
            }
            else if (!isDouble1 || !isDouble2)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка");
                return;
            }
            textBox4.Enabled = true;
            button2.Enabled = true;
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            x = xMin + h;
            while (x <= xMax)
            {
                switch (comboBox1.SelectedIndex)
                {
                    default:
                        y = x * a + b;
                        break;
                    case 1:
                        y = a * Math.Sin(x * b) + c;
                        break;
                    case 2:
                        y = a * Math.Cos(x * b + c);
                        break;
                    case 3:
                        y = a * Math.Tan(x * b) + c;
                        break;
                    case 4:
                        y = a * 1 / Math.Tan(x * b + c);
                        break;
                    case 5:
                        y = b * Math.Pow(x, a);
                        break;
                    case 6:
                        y = Math.Pow(a, x + b);
                        break;
                    case 7:
                        y = Math.Pow((Math.Sin(x) + a * x) / ((x - Math.Pow(x, (double)1 / 2)) + 1), b / x);
                        break;
                }
                if (y <= size + 1 && y >= -(size + 1))
                {
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else if (y < -(size + 1))
                {
                    this.chart1.Series[0].Points.AddXY(x, -(size + 1));
                }
                else
                {
                    this.chart1.Series[0].Points.AddXY(x, size + 1);
                }
                x += h;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0 && comboBox1.SelectedIndex < 5)
            {
                textBox3.Enabled = true;
                
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series[1].Points.Clear();
            string str = textBox4.Text.Replace('.', ',');
            bool isDouble = double.TryParse(str, out double x);
            if (x == 0){
                x += 0.0001;
            }
            if (x > size || x < -size)
            {
                MessageBox.Show("x выходит за границы", "Ошибка");
                return;
            }

            if (!isDouble)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка");
                return;
            }
            double y = this.chart1.Series[0].Points[(int)Math.Round((x + size + 1 - 0.1) * 10)].YValues[0];
            if (y > size || y < -size)
            {
                MessageBox.Show("x выходит за границы поля");
                return;
            }
            this.chart1.Series[1].Points.AddXY(x, y);
        }
    }
}
