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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPublication form = new NewPublication(this);
            form.ShowDialog();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors form = new Authors();
            form.Show();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publishing form = new Publishing();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                AuthorsPub form = new AuthorsPub(this, e.RowIndex);
                form.ShowDialog();
            }
        }

        private void уДКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UDC form = new UDC();
            form.Show();
        }

        private void местаРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkPlaces form = new WorkPlaces();
            form.Show();
        }

        private void научныеСтепениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degrees form = new Degrees();
            form.Show();
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
