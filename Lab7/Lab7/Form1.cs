using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private Pen pen = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
        }

        class Bot
        {
            public bool enabled = false;
            public string sign = "O";
        }

        Bot bot = new Bot();
        private bool O;
        private string[] cells = new string[9];
        private int[,] wins = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            NextMove(e.X, e.Y);
            BotMove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            end = false;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.DrawLine(pen, pictureBox1.Width / 3, 0, pictureBox1.Width / 3, pictureBox1.Height);
                g.DrawLine(pen, (pictureBox1.Width / 3) * 2, 0, (pictureBox1.Width / 3) * 2, pictureBox1.Height);
                g.DrawLine(pen, 0, pictureBox1.Height / 3, pictureBox1.Width, pictureBox1.Height / 3);
                g.DrawLine(pen, 0, (pictureBox1.Height / 3) * 2, pictureBox1.Width, (pictureBox1.Height / 3) * 2);
            }
            for (int i = 0; i < cells.Length; i ++)
            {
                cells[i] = " ";
            }
            if (radioButton1.Checked)
            {
                O = true;
                label1.Text = "Ходит O";
            }
            else if (radioButton2.Checked)
            {
                O = false;
                label1.Text = "Ходит X";
            }
            if (checkBox1.Checked)
            {
                bot.enabled = true;
                if (radioButton3.Checked) { bot.sign = "X"; }
                else { bot.sign = "O"; }
                BotMove();
            }
            else
            {
                bot.enabled = false;
            }
        }

        static bool end = false;
        private void NextMove(int clickX, int clickY)
        {
            if (end)
            {
                return;
            }
            int x = (pictureBox1.Width / 3 - 100) / 2, y = (pictureBox1.Height / 3 - 100) / 2, w = pictureBox1.Width, h = pictureBox1.Height;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (clickX < ((double)w / 3) * (i + 1) && clickY < ((double)h / 3) * (j + 1))
                    {
                        if (cells[0 + i + j * 3] != " ")
                        {
                            return;
                        }
                        x += w / 3 * i;
                        y += (h / 3) * j;
                        if (O)
                        {
                            cells[0 + i + j * 3] = "O";
                        }
                        else
                        {
                            cells[0 + i + j * 3] = "X";
                        }
                        goto LoopEnd;
                    }
                }
            }
        LoopEnd:
            if (!O)
            {
                label1.Text = "Ходит O";
            }
            else
            {
                label1.Text = "Ходит X";
            }
            int win = -1;
            for (int i = 0; i < wins.GetLength(0); i++)
            {
                if (cells[wins[i, 0]] == cells[wins[i, 1]] && cells[wins[i, 0]] == cells[wins[i, 2]] && cells[wins[i, 0]] != " ")
                {
                    win = i;
                }
            }
            Pen penRed = new Pen(Color.Red, 10);
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                if (O)
                {
                    g.DrawEllipse(pen, x, y, 100, 100);
                    O = !O;
                }
                else
                {
                    g.DrawLine(pen, x, y, x + 100, y + 100);
                    g.DrawLine(pen, x + 100, y, x, y + 100);
                    O = !O;
                }
                if (win != -1)
                {
                    switch (win)
                    {
                        case 0:
                            g.DrawLine(penRed, 0, h / 6, w, h / 6);
                            break;
                        case 1:
                            g.DrawLine(penRed, 0, h / 2, w, h / 2);
                            break;
                        case 2:
                            g.DrawLine(penRed, 0, h - h / 6, w, h - h / 6);
                            break;
                        case 3:
                            g.DrawLine(penRed, w / 6, 0, w / 6, h);
                            break;
                        case 4:
                            g.DrawLine(penRed, w / 2, 0, w / 2, h);
                            break;
                        case 5:
                            g.DrawLine(penRed, w - w / 6, 0, w - w / 6, h);
                            break;
                        case 6:
                            g.DrawLine(penRed, 0, 0, w, h);
                            break;
                        case 7:
                            g.DrawLine(penRed, w, 0, 0, h);
                            break;
                    }
                    end = true;
                    label1.Text = "";
                }
                else
                {
                    end = false;
                }
            }
            pictureBox1.Refresh();
        }

        private void BotMove()
        {
            if (end)
            {
                return;
            }
            if (bot.enabled)
            {
                Random rnd = new Random();
                switch (bot.sign)
                {
                    case "O":
                        while (!O)
                        {
                            NextMove(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height));
                        }
                        break;
                    case "X":
                        while (O)
                        {
                            NextMove(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height));
                        }
                        break;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = checkBox1.Checked;
        }
    }
}