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
    public partial class AuthorsPub : Form
    {
        Form1 form;
        public AuthorsPub(Form1 owner, int row)
        {
            form = owner;
            InitializeComponent();
            this.Text = form.dataGridView1[0, row].Value.ToString() + " (авторы)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAuthorPub form = new NewAuthorPub(this);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
