using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab02IOSTREAM
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DriveInfo[] danhsach = DriveInfo.GetDrives();
            foreach (DriveInfo drive in danhsach)
            {
                if (drive.IsReady)
                {
                    TreeNode nganKeo = new TreeNode(drive.Name);
                    nganKeo.Tag = drive.Name;
                    nganKeo.Nodes.Add("Dummy");
                    thuMuc.Nodes.Add(nganKeo);
                }
            }
        }

        private void thuMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode nodeHientai = e.Node;
            if (nodeHientai.Nodes.Count == 1 && nodeHientai.Nodes[0].Text == "Dummy")
            {
                nodeHientai.Nodes.Clear();
                string duongdan = nodeHientai.Tag.ToString();
                try
                {
                    string[] thuMucAll = Directory.GetDirectories(duongdan);
                    foreach (string dir in thuMucAll)
                    {
                        TreeNode nodeThuMuc = new TreeNode(Path.GetFileName(dir));
                        nodeThuMuc.Tag = dir;
                        nodeThuMuc.Nodes.Add("DUMMY");
                        nodeHientai.Nodes.Add(nodeThuMuc);
                    }
                    string[] File = Directory.GetFiles(duongdan);
                    foreach (string file in File)
                    {
                        TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                        fileNode.Tag = file;
                        nodeHientai.Nodes.Add(fileNode);
                    }
                }
                catch (UnauthorizedAccessException)
                {

                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string DuongDan = e.Node.Tag.ToString();
            string duoiFile = Path.GetExtension(DuongDan).ToLower();
            if (duoiFile == ".jpeg" || duoiFile == ".png" || duoiFile == ".jpg")
            {
                picture.Visible = true;
                richTextBox.Visible = false;
                picture.Image = Image.FromFile(DuongDan);
            }
            else if (duoiFile == ".txt")
            {
                picture.Visible = false;
                richTextBox.Visible = true;
                richTextBox.Text = File.ReadAllText(DuongDan);
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


