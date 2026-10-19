namespace lab02IOSTREAM
{
    partial class Bai07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            thuMuc = new TreeView();
            picture = new PictureBox();
            richTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // thuMuc
            // 
            thuMuc.Location = new Point(12, 12);
            thuMuc.Name = "thuMuc";
            thuMuc.Size = new Size(222, 426);
            thuMuc.TabIndex = 0;
            thuMuc.BeforeExpand += thuMuc_BeforeExpand;
            thuMuc.AfterSelect += treeView1_AfterSelect;
            // 
            // picture
            // 
            picture.Location = new Point(252, 28);
            picture.Name = "picture";
            picture.Size = new Size(536, 410);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 1;
            picture.TabStop = false;
            picture.Click += picture_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(252, 28);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(536, 395);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(picture);
            Controls.Add(thuMuc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView thuMuc;
        private PictureBox picture;
        private RichTextBox richTextBox;
    }
}