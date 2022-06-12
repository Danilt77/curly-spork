using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public string ImagePath { get; set; }
        public string PDFPath { get; set; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDFPath = "";
            label1.Text = "";
            Bitmap image;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(ofd.FileName);
                    if (fileInfo.Length < 1024 * 1024)
                    {
                        image = new Bitmap(ofd.FileName);
                        pictureBox1.Image = image;
                        pictureBox1.Invalidate();
                        ImagePath = ofd.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Файл слишком большой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Text = "";
            string lang = "eng";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    lang = "eng";
                    break;
                case 1:
                    lang = "rus";
                    break;
            }
            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(1, 1, 1);
            MultipartFormDataContent form = new MultipartFormDataContent();
            form.Add(new StringContent("a75923b6fd88957"), "apikey");
            form.Add(new StringContent(lang), "language");
            form.Add(new StringContent("true"), "scale");
            if (!string.IsNullOrEmpty(ImagePath))
            {
                byte[] imageData = File.ReadAllBytes(ImagePath);
                form.Add(new ByteArrayContent(imageData, 0, imageData.Length), "image", "image.jpg");
            }
            else if (!string.IsNullOrEmpty(PDFPath))
            {
                byte[] imageData = File.ReadAllBytes(PDFPath);
                form.Add(new ByteArrayContent(imageData, 0, imageData.Length), "PDF", "pdf.pdf");
            }
            HttpResponseMessage response = await httpClient.PostAsync("https://api.ocr.space/Parse/Image", form);
            string strContent = await response.Content.ReadAsStringAsync();
            Rootobject result = JsonConvert.DeserializeObject<Rootobject>(strContent);
            if (result.OCRExitCode == 1)
            {
                for (int i = 0; i < result.ParsedResults.Length; i++)
                {
                    textBox1.Text += result.ParsedResults[i].ParsedText;
                }
            }
            else
            {
                MessageBox.Show("Не удалось распознать текст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImagePath = "";
            pictureBox1.Image = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(ofd.FileName);
                    if (fileInfo.Length < 1024 * 1024)
                    {
                        PDFPath = ofd.FileName;
                        label1.Text = ofd.FileName;
                    }
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
