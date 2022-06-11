using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class NewPublication : System.Windows.Forms.Form
    {
        Form1 form1;
        public NewPublication(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" )
            {
                form1.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text, textBox1.Text, textBox5.Text, "Просмотр/изменение авторов");
                this.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !Char.IsDigit(c);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !Char.IsDigit(c);
        }
    }
}
