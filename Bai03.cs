using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab02IOSTREAM
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }
        private void DocvaXuat_Click_1(object sender, EventArgs e)
        {
            string tenFile = "input3.txt";
            string duongDan = Path.Combine(Application.StartupPath, tenFile);
            string noiDung = File.ReadAllText(duongDan);
            if (string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Không có nội dung để tính toán! ");
                return;
            }
                if (File.Exists(duongDan))
            {
                bool check = Regex.IsMatch(noiDung, @"^[0-9\+\-\*\/\(\)\.\s]+$");
                if ( !check)
                {
                    MessageBox.Show("File chỉ chứa các ký tự văn bản, không có số hợp lệ để tính toán! ");
                    return;
                }
                StreamReader read = new StreamReader("input3.txt");
                StreamWriter write = new StreamWriter("output3.txt");
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    string[] mang = line.Split(' ');
                    double ketqua = double.Parse(mang[0]);
                    for (int i = 1; i < mang.Length - 1; i += 2)
                    {
                        string phepTinh = mang[i];
                        double ConSo = double.Parse(mang[i + 1]);
                        if (phepTinh == "+") ketqua += ConSo;
                        else if (phepTinh == "-") ketqua -= ConSo;
                        else if (phepTinh == "*") ketqua *= ConSo;
                        else if (phepTinh == "/") ketqua /= ConSo;
                    }
                    write.WriteLine(line + " = " + ketqua);
                }
                MessageBox.Show("Xuất file thành công! ");
                write.Close();
            }
            else
            {
                MessageBox.Show("Không tồn tại file input3.txt trong thư mục!");
            }
        }
    }
}
