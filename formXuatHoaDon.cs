using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02IOSTREAM
{

    public partial class formXuatHoaDon : Form
    {
        public string Hoten { get; set; } = "";
        public string TenPhim { get; set; } = "";
        public double Tongtien { get; set; } = 0;
        public string SoPhong { get; set; } = "";
        public string SoGhe { get; set; } = "";
        public formXuatHoaDon()
        {
            InitializeComponent();
        }

        private void formXuatHoaDon_Load(object sender, EventArgs e)
        {
            hoTentxt.Text = Hoten;
            tenPhimtxt.Text = TenPhim;
            soTientxt.Text = Tongtien.ToString();
            soGhetxt.Text = SoGhe;
            phongChieutxt.Text = SoPhong;
        }

        private void hoTentxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void muatiepbtn_Click(object sender, EventArgs e)
        {
       
        }
    }
}
