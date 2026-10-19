namespace lab02IOSTREAM
{
    partial class Bai02
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
            FileName = new RichTextBox();
            Size = new RichTextBox();
            rtbURL = new RichTextBox();
            LineCount = new RichTextBox();
            WordCount = new RichTextBox();
            CharacterCount = new RichTextBox();
            rtbALL = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(97, 23);
            button1.Name = "button1";
            button1.Size = new Size(222, 34);
            button1.TabIndex = 0;
            button1.Text = "Read From File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ReadFromFileButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 79);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "FileName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 137);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 184);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 3;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 227);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 4;
            label4.Text = "Line Count";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(32, 258);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 283);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 6;
            label5.Text = "Word Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 327);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 7;
            label6.Text = "Character Count";
            // 
            // FileName
            // 
            FileName.Location = new Point(126, 76);
            FileName.Name = "FileName";
            FileName.Size = new Size(193, 35);
            FileName.TabIndex = 8;
            FileName.Text = "";
            FileName.TextChanged += TextBoxFileName;
            // 
            // Size
            // 
            Size.AcceptsTab = true;
            Size.Location = new Point(126, 117);
            Size.Name = "Size";
            Size.Size = new Size(193, 45);
            Size.TabIndex = 9;
            Size.Text = "";
            Size.TextChanged += TextBoxSize;
            // 
            // rtbURL
            // 
            rtbURL.Location = new Point(126, 168);
            rtbURL.Name = "rtbURL";
            rtbURL.Size = new Size(193, 41);
            rtbURL.TabIndex = 10;
            rtbURL.Text = "";
            rtbURL.TextChanged += TextBoxURL;
            // 
            // LineCount
            // 
            LineCount.Location = new Point(126, 215);
            LineCount.Name = "LineCount";
            LineCount.Size = new Size(193, 37);
            LineCount.TabIndex = 11;
            LineCount.Text = "";
            LineCount.TextChanged += TextBoxLineCount;
            // 
            // WordCount
            // 
            WordCount.Location = new Point(131, 268);
            WordCount.Name = "WordCount";
            WordCount.Size = new Size(188, 41);
            WordCount.TabIndex = 12;
            WordCount.Text = "";
            WordCount.TextChanged += TextBoxWordCount;
            // 
            // CharacterCount
            // 
            CharacterCount.Location = new Point(169, 315);
            CharacterCount.Name = "CharacterCount";
            CharacterCount.Size = new Size(150, 37);
            CharacterCount.TabIndex = 13;
            CharacterCount.Text = "";
            CharacterCount.TextChanged += TextBoxCharacterCount;
            // 
            // rtbALL
            // 
            rtbALL.Location = new Point(392, 45);
            rtbALL.Name = "rtbALL";
            rtbALL.Size = new Size(367, 307);
            rtbALL.TabIndex = 14;
            rtbALL.Text = "";
            rtbALL.TextChanged += rtbALL_TextChanged;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbALL);
            Controls.Add(CharacterCount);
            Controls.Add(WordCount);
            Controls.Add(LineCount);
            Controls.Add(rtbURL);
            Controls.Add(Size);
            Controls.Add(FileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Bai02";
            Text = "S";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label6;
        private RichTextBox FileName;
        private RichTextBox Size;
        private RichTextBox rtbURL;
        private RichTextBox LineCount;
        private RichTextBox WordCount;
        private RichTextBox CharacterCount;
        private RichTextBox rtbALL;
    }
}