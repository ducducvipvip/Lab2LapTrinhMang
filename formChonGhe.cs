using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02IOSTREAM
{
    public partial class formChonGhe : Form
    {
        public string Hoten { get; set; }
        public string TenPhim { get; set; }
        public string SoPhong { get; set; }
        public double GiaVe { get; set; } = 0;
        string danhSach = "";
        double TongTien = 0;
        public formChonGhe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SCREEN(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            string danhsach = " ";
            double TongTien = 0;
            foreach (Control doVat in this.Controls)
            {
                double heso = 1;
                CheckBox Ghe = doVat as CheckBox;
                if (Ghe.Checked == true)
                {
                    string tenGhe = Ghe.Text;
                    danhsach = danhsach + tenGhe + ",";
                    if (tenGhe == "A1" || tenGhe == "A5" || tenGhe == "C1" || tenGhe == "C5") heso = 0.25;
                    if (tenGhe == "B2" || tenGhe == "B3" || tenGhe == "B4") heso = 2;
                    TongTien = TongTien + GiaVe * heso;
                }
                textBox1.Text = TongTien.ToString();
            }
        }

        private void formChonGhe_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuatHoadonBtn_Click(object sender, EventArgs e)
        {
            veXemPhim phim = new veXemPhim();
            double sovemua =
            phim.DoanhThu += TongTien;
            formXuatHoaDon hoadon = new formXuatHoaDon();
            hoadon.Tongtien = TongTien;
            hoadon.SoGhe = danhSach;
            hoadon.Hoten = this.Hoten;
            hoadon.TenPhim = this.TenPhim;
            hoadon.SoPhong = this.SoPhong;
            hoadon.ShowDialog();
            hoadon.ShowDialog();
        }
    }
}
