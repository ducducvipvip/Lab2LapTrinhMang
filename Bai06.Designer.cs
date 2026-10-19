namespace lab02IOSTREAM
{
    partial class Bai06
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
            listMonAn = new ListView();
            ID = new ColumnHeader();
            MONAN = new ColumnHeader();
            randfoodBtn = new Button();
            monAnlabel = new Label();
            label1 = new Label();
            monanTxt = new TextBox();
            ngdonggopTxt = new TextBox();
            label2 = new Label();
            hinhAnh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hinhAnh).BeginInit();
            SuspendLayout();
            // 
            // listMonAn
            // 
            listMonAn.Columns.AddRange(new ColumnHeader[] { ID, MONAN });
            listMonAn.Location = new Point(472, 12);
            listMonAn.Name = "listMonAn";
            listMonAn.Size = new Size(316, 426);
            listMonAn.TabIndex = 0;
            listMonAn.UseCompatibleStateImageBehavior = false;
            listMonAn.View = View.Details;
            listMonAn.SelectedIndexChanged += listMonAn_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 160;
            // 
            // MONAN
            // 
            MONAN.Text = "MÓN ĂN";
            MONAN.Width = 200;
            // 
            // randfoodBtn
            // 
            randfoodBtn.Location = new Point(82, 26);
            randfoodBtn.Name = "randfoodBtn";
            randfoodBtn.Size = new Size(147, 50);
            randfoodBtn.TabIndex = 1;
            randfoodBtn.Text = "Hôm nay ăn gì?";
            randfoodBtn.UseVisualStyleBackColor = true;
            randfoodBtn.Click += randfoodBtn_Click;
            // 
            // monAnlabel
            // 
            monAnlabel.AutoSize = true;
            monAnlabel.Location = new Point(22, 107);
            monAnlabel.Name = "monAnlabel";
            monAnlabel.Size = new Size(53, 25);
            monAnlabel.TabIndex = 2;
            monAnlabel.Text = "Món:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 171);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 3;
            label1.Text = "Người đóng góp:";
            // 
            // monanTxt
            // 
            monanTxt.Location = new Point(81, 104);
            monanTxt.Name = "monanTxt";
            monanTxt.Size = new Size(173, 31);
            monanTxt.TabIndex = 4;
            monanTxt.TextChanged += monanTxt_TextChanged;
            // 
            // ngdonggopTxt
            // 
            ngdonggopTxt.Location = new Point(180, 165);
            ngdonggopTxt.Name = "ngdonggopTxt";
            ngdonggopTxt.Size = new Size(177, 31);
            ngdonggopTxt.TabIndex = 5;
            ngdonggopTxt.TextChanged += ngdonggopTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 233);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Hình ảnh:";
            // 
            // hinhAnh
            // 
            hinhAnh.Location = new Point(22, 275);
            hinhAnh.Name = "hinhAnh";
            hinhAnh.Size = new Size(430, 331);
            hinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            hinhAnh.TabIndex = 7;
            hinhAnh.TabStop = false;
            hinhAnh.SizeModeChanged += hinhAnh_Click;
            hinhAnh.Click += hinhAnh_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 608);
            Controls.Add(hinhAnh);
            Controls.Add(label2);
            Controls.Add(ngdonggopTxt);
            Controls.Add(monanTxt);
            Controls.Add(label1);
            Controls.Add(monAnlabel);
            Controls.Add(randfoodBtn);
            Controls.Add(listMonAn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)hinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listMonAn;
        private ColumnHeader ID;
        private ColumnHeader MONAN;
        private Button randfoodBtn;
        private Label monAnlabel;
        private Label label1;
        private TextBox monanTxt;
        private TextBox ngdonggopTxt;
        private Label label2;
        private PictureBox hinhAnh;
    }
}