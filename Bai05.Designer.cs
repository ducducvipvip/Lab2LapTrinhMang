namespace lab02IOSTREAM
{
    partial class Bai05
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
            label1 = new Label();
            label2 = new Label();
            hoTentxt = new TextBox();
            tenPhimcomboBox = new ComboBox();
            label3 = new Label();
            giaVetxt = new TextBox();
            label4 = new Label();
            phongChieucombo = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 83);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 164);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Phim";
            // 
            // hoTentxt
            // 
            hoTentxt.Location = new Point(117, 77);
            hoTentxt.Name = "hoTentxt";
            hoTentxt.Size = new Size(150, 31);
            hoTentxt.TabIndex = 2;
            hoTentxt.TextChanged += hoTentxt_TextChanged;
            // 
            // tenPhimcomboBox
            // 
            tenPhimcomboBox.FormattingEnabled = true;
            tenPhimcomboBox.Items.AddRange(new object[] { "Đào, phở và piano.", "Mai.", "Gặp lại chị bầu.", "Tarot." });
            tenPhimcomboBox.Location = new Point(117, 156);
            tenPhimcomboBox.Name = "tenPhimcomboBox";
            tenPhimcomboBox.Size = new Size(150, 33);
            tenPhimcomboBox.TabIndex = 3;
            tenPhimcomboBox.SelectedIndexChanged += tenPhimcomboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 117);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Giá vé";
            // 
            // giaVetxt
            // 
            giaVetxt.Location = new Point(462, 114);
            giaVetxt.Name = "giaVetxt";
            giaVetxt.Size = new Size(150, 31);
            giaVetxt.TabIndex = 5;
            giaVetxt.TextChanged += giaVetxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 251);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 6;
            label4.Text = "Phòng chiếu";
            // 
            // phongChieucombo
            // 
            phongChieucombo.FormattingEnabled = true;
            phongChieucombo.Location = new Point(117, 251);
            phongChieucombo.Name = "phongChieucombo";
            phongChieucombo.Size = new Size(182, 33);
            phongChieucombo.TabIndex = 7;
            phongChieucombo.SelectedIndexChanged += phongChieucombo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(28, 329);
            button1.Name = "button1";
            button1.Size = new Size(196, 48);
            button1.TabIndex = 8;
            button1.Text = "Chọn ghế";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ChonGhebtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(phongChieucombo);
            Controls.Add(label4);
            Controls.Add(giaVetxt);
            Controls.Add(label3);
            Controls.Add(tenPhimcomboBox);
            Controls.Add(hoTentxt);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox hoTentxt;
        private ComboBox tenPhimcomboBox;
        private Label label3;
        private TextBox giaVetxt;
        private Label label4;
        private ComboBox phongChieucombo;
        private Button button1;
    }
}