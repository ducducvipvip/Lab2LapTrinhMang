using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace lab02IOSTREAM
{
    public partial class Bai04 : Form
    {
        List<SinhVien> danhsachNhap = new List<SinhVien>();
        List<SinhVien> danhsachDoc = new List<SinhVien>();
        int vitri = 0;

        public Bai04()
        {
            InitializeComponent();
        }

        private void writetoaFilebtn_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(danhsachNhap);
            File.WriteAllText("input4.txt", json);
        }

        private void diemTBtextBox_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int mssv = int.Parse(IDtextbox.Text);
            float Diem1 = float.Parse(diem1Textbox.Text);
            float Diem2 = float.Parse(diem2TextBox.Text);
            float Diem3 = float.Parse(diem3TextBox.Text);
            string phone = PhonetextBox.Text;
            if (mssv.ToString().Length != 8)
            {
                MessageBox.Show("MSSV phải đúng 8 chữ số");
                return;
            }
            if (Diem1 < 0 || Diem1 > 10 || Diem2 < 0 || Diem2 > 10 || Diem3 < 0 || Diem3 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng 0 đến 10");
                return;
            }
            if (phone.ToString().Length != 10 || !phone.StartsWith("0"))
            {
                MessageBox.Show("SĐT phải đủ mười số và bắt đầu từ số 0");
                return;
            }
            SinhVien sv = new SinhVien()
            {
                HoTen = nameTextBox.Text,
                Diem1 = Diem1,
                Diem2 = Diem2,
                Diem3 = Diem3,
                MSSV = mssv,
                dienThoai = phone,
                DiemTB = 0
            };
            danhsachNhap.Add(sv);
            string thongTin = $"{sv.HoTen} \n {sv.MSSV} \n {sv.dienThoai} \n {sv.Diem1} \n {sv.Diem2} \n {sv.Diem3} \n ";
            richTextBox1.Text += thongTin;
            nameTextBox.Clear();
            diem1Textbox.Clear();
            diem2TextBox.Clear();
            diem3TextBox.Clear();
            PhonetextBox.Clear();
            IDtextbox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (vitri > 0)
            {
                vitri--;
                HienThiTrang(vitri);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void diem1Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhonetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void readaFilebtn_Click(object sender, EventArgs e)
        {
            if ( !File.Exists("input4.txt"))
            {
                MessageBox.Show("Chưa tồn tại file input4.txt , xin vui lòng khởi tạo file trước! ");
                return;
            }
            string json = File.ReadAllText("input4.txt");
            danhsachDoc = JsonSerializer.Deserialize<List<SinhVien>>(json);
            foreach (SinhVien sv in danhsachDoc)
            {
                sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3;
            }
            string jsonoutput = JsonSerializer.Serialize(danhsachDoc);
            File.WriteAllText("output4.txt", jsonoutput);
            HienThiTrang(vitri);
        }
        private void HienThiTrang(int vitri)
        {
            SinhVien sv = danhsachDoc[vitri];
            nameTextboxRight.Text = sv.HoTen;
            IDtextBoxRight.Text = sv.MSSV.ToString();
            phoneTextboxRight.Text = sv.dienThoai;
            Diem1TxtRight.Text = sv.Diem1.ToString();
            Diem2txtRight.Text = sv.Diem2.ToString();
            Diem3TxtRight.Text = sv.Diem3.ToString();
            diemTBtxtRight.Text = sv.DiemTB.ToString();
        }

        private void nameTextboxRight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (vitri < danhsachDoc.Count - 1)
            {
                vitri++;
                HienThiTrang(vitri);
            }
            }
        }
}
