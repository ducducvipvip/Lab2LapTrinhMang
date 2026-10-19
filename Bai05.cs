using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab02IOSTREAM
{
    public partial class Bai05 : Form
    {
        int giave = 0;
        public Bai05()
        {
            InitializeComponent();
        }

        private void tenPhimcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void giaVetxt_TextChanged(object sender, EventArgs e)
        {
            if (tenPhimcomboBox.Text == "Mai")
            {
                giave = 45000;
                giaVetxt.Text = giave.ToString() + "Đồng";

            }
            else if (tenPhimcomboBox.Text == "Đào, phở và piano")
            {
                giave = 100000;
                giaVetxt.Text = giave.ToString() + "Đồng";
            }
            else if (tenPhimcomboBox.Text == "Gặp lại chị bầu"){
                giave = 70000;
                giaVetxt.Text = giave.ToString() + "Đồng";
            }
            else {
                giave = 90000;
                giaVetxt.Text = giave.ToString() + "Đồng";
            }
        }

        private void phongChieucombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tenPhimcomboBox.Text == "Mai")
            {
                phongChieucombo.Items.Add("2");
                phongChieucombo.Items.Add("3");
            }
            else if (tenPhimcomboBox.Text == "Đào, phở và piano")
            {
                phongChieucombo.Items.Add("1");
                phongChieucombo.Items.Add("2");
                phongChieucombo.Items.Add("3");
            }
            else if (tenPhimcomboBox.Text == "Gặp lại chị bầu"){
                phongChieucombo.Items.Add("1");
            }
            else phongChieucombo.Items.Add("3");
        }

        private void ChonGhebtn(object sender, EventArgs e)
        {
            formChonGhe chonghe = new formChonGhe();
            chonghe.GiaVe = giave ;
            chonghe.TenPhim = tenPhimcomboBox.Text;
            chonghe.Hoten = hoTentxt.Text;
            chonghe.SoPhong = phongChieucombo.Text;
            chonghe.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoTentxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
