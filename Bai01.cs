using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace lab02IOSTREAM
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DocFileButton(object sender, EventArgs e)
        {
            if (File.Exists("input1.txt"))
            {
                using (FileStream fs = new FileStream("input1.txt", FileMode.OpenOrCreate))
                using (StreamReader rs = new StreamReader(fs))
                {
                    richTextBox1.Text = rs.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("File không tồn tại! ");
            }
        }

        private void GhiFileButton(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("output1.txt", FileMode.OpenOrCreate))
            using (StreamWriter rs = new StreamWriter(fs))
            {
                richTextBox1.Text = richTextBox1.Text.ToUpper();
                rs.Write(richTextBox1.Text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
