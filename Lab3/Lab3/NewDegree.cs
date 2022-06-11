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
    public partial class NewDegree : Form
    {
        Degrees form;
        public NewDegree(Degrees owner)
        {
            form = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                form.dataGridView1.Rows.Add(textBox1.Text);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = (c < 'А' || c > 'я') && (c < 'A' || c > 'z') && c != 'Ё' && c != 'ё' && c != '\b' && c != ' ';
        }
    }
}
