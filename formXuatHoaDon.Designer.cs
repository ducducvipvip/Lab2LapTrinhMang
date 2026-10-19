namespace lab02IOSTREAM
{
    partial class formXuatHoaDon
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            hoTentxt = new TextBox();
            tenPhimtxt = new TextBox();
            phongChieutxt = new TextBox();
            soGhetxt = new TextBox();
            soTientxt = new TextBox();
            label7 = new Label();
            muatiepbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 177);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 227);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Phim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 268);
            label3.Name = "label3";
            label3.Size = new Size(214, 25);
            label3.TabIndex = 2;
            label3.Text = "Tổng tiền cần thanh toán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 183);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 3;
            label4.Text = "Số phòng chiếu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(580, 186);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 4;
            label5.Text = "Số ghế:";
            // 
            // hoTentxt
            // 
            hoTentxt.Location = new Point(116, 177);
            hoTentxt.Name = "hoTentxt";
            hoTentxt.Size = new Size(141, 31);
            hoTentxt.TabIndex = 5;
            hoTentxt.TextChanged += hoTentxt_TextChanged;
            // 
            // tenPhimtxt
            // 
            tenPhimtxt.Location = new Point(132, 221);
            tenPhimtxt.Name = "tenPhimtxt";
            tenPhimtxt.Size = new Size(150, 31);
            tenPhimtxt.TabIndex = 6;
            // 
            // phongChieutxt
            // 
            phongChieutxt.Location = new Point(455, 180);
            phongChieutxt.Name = "phongChieutxt";
            phongChieutxt.Size = new Size(109, 31);
            phongChieutxt.TabIndex = 7;
            // 
            // soGhetxt
            // 
            soGhetxt.Location = new Point(658, 186);
            soGhetxt.Name = "soGhetxt";
            soGhetxt.Size = new Size(102, 31);
            soGhetxt.TabIndex = 8;
            // 
            // soTientxt
            // 
            soTientxt.Location = new Point(257, 265);
            soTientxt.Name = "soTientxt";
            soTientxt.Size = new Size(150, 31);
            soTientxt.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 92);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 11;
            label7.Text = "Hóa Đơn";
            // 
            // muatiepbtn
            // 
            muatiepbtn.Location = new Point(51, 332);
            muatiepbtn.Name = "muatiepbtn";
            muatiepbtn.Size = new Size(200, 62);
            muatiepbtn.TabIndex = 12;
            muatiepbtn.Text = "Mua Tiếp";
            muatiepbtn.UseVisualStyleBackColor = true;
            muatiepbtn.Click += muatiepbtn_Click;
            // 
            // formXuatHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(muatiepbtn);
            Controls.Add(label7);
            Controls.Add(soTientxt);
            Controls.Add(soGhetxt);
            Controls.Add(phongChieutxt);
            Controls.Add(tenPhimtxt);
            Controls.Add(hoTentxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formXuatHoaDon";
            Text = "Form1";
            Load += formXuatHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox hoTentxt;
        private TextBox tenPhimtxt;
        private TextBox phongChieutxt;
        private TextBox soGhetxt;
        private TextBox soTientxt;
        private Label label7;
        private Button muatiepbtn;
    }
}