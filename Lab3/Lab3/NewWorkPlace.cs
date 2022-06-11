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
    public partial class NewWorkPlace : Form
    {
        WorkPlaces form;
        public NewWorkPlace(WorkPlaces owner)
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
    }
}
