namespace lab02IOSTREAM
{
    partial class Bai03
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
            DocvaXuat = new Button();
            SuspendLayout();
            // 
            // DocvaXuat
            // 
            DocvaXuat.Location = new Point(147, 85);
            DocvaXuat.Name = "DocvaXuat";
            DocvaXuat.Size = new Size(449, 153);
            DocvaXuat.TabIndex = 0;
            DocvaXuat.Text = "Đọc và Xuất File";
            DocvaXuat.UseVisualStyleBackColor = true;
            DocvaXuat.Click += DocvaXuat_Click_1;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DocvaXuat);
            Name = "Bai03";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button DocvaXuat;
    }
}