using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02IOSTREAM
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void ReadFromFileButton(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string duongDan = open.FileName;
            string duoiFile = Path.GetExtension(duongDan).ToLower();
            if ( duoiFile != ".txt")
            {
                MessageBox.Show("Không đúng định dạng đuôi! Xin vui lòng chọn lại.");
                return;
            }
            string tenFile = open.SafeFileName;
            FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate);
            StreamReader read = new StreamReader(fs);
            string Chuoi = read.ReadToEnd();
            rtbALL.Text = Chuoi;
            rtbURL.Text = open.FileName;
            FileName.Text = tenFile;
            LineCount.Text = rtbALL.Lines.Length.ToString();
            int chaCount = Chuoi.Length;
            CharacterCount.Text = chaCount.ToString();
            int sotu = 0;
            char[] ranhGioi = new char[] { ' ', '\n', '\r', '\t' };
            string[] Tu = Chuoi.Split(ranhGioi, StringSplitOptions.RemoveEmptyEntries);
            int soTu = Tu.Length;
            WordCount.Text = soTu.ToString();
            FileInfo file = new FileInfo(open.FileName);
            Size.Text = file.Length + " Bytes";
        }


        private void TextBoxFileName(object sender, EventArgs e)
        {

        }

        private void TextBoxSize(object sender, EventArgs e)
        {

        }

        private void TextBoxURL(object sender, EventArgs e)
        {

        }

        private void TextBoxLineCount(object sender, EventArgs e)
        {

        }

        private void TextBoxWordCount(object sender, EventArgs e)
        {

        }

        private void TextBoxCharacterCount(object sender, EventArgs e)
        {

        }

        private void TextBoxALL(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxALL_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbALL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
