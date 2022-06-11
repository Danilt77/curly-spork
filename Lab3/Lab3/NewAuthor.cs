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
    public partial class NewAuthor : System.Windows.Forms.Form
    {
        Authors form3;
        public NewAuthor(Authors owner)
        {
            form3 = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                form3.dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = (c < 'А' || c > 'я') && (c < 'A' || c > 'z') && c != 'Ё' && c != 'ё' && c != '\b' && c != ' ';
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !Char.IsDigit(c) && c != '\b';
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = (c < 'А' || c > 'я') && (c < 'A' || c > 'z') && c != 'Ё' && c != 'ё' && c != '\b' && c != ' ';
        }
    }
}
