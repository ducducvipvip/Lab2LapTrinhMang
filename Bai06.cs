using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace lab02IOSTREAM
{
    public partial class Bai06 : Form
    {
        string connectionString = "Data Source=Food.db;Version=3;";
        public Bai06()
        {
            InitializeComponent();
        }

        private void listMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listMonAn.Items.Clear();    
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT IDMN, TENMONAN FROM MONANest";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ListViewItem ID = new ListViewItem(read["IDMN"].ToString());
                            ID.SubItems.Add(read["TENMONAN"].ToString());
                            listMonAn.Items.Add(ID);
                        }

                    }
                }
            }
        }


        private void randfoodBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT m.TENMONAN, m.HINHANH, n.HOTEN 
                    FROM MONAN m 
                    JOIN NGUOIDUNG n ON m.IDND = n.IDND 

                    ORDER BY RANDOM() 
                    LIMIT 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            monanTxt.Text = reader["TENMONAN"].ToString();
                            ngdonggopTxt.Text = reader["HOTEN"].ToString();
                            string tenfile = reader["HINHANH"].ToString();
                            string duongDan = Path.Combine(Application.StartupPath, tenfile);
                            hinhAnh.Image = Image.FromFile(duongDan);
                        }
                        else
                        {
                            MessageBox.Show("Chưa có món ăn nào trong danh sách!");
                            return;
                        }
                    }
                }
            }
        }

        private void monanTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngdonggopTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void hinhAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
