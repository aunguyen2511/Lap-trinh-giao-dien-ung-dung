namespace BaiTap01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            BtnThoat = new Button();
            TxtNhap = new TextBox();
            TxtTong = new TextBox();
            BtnTinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 58);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập n:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 167);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "Tổng:";
            // 
            // BtnThoat
            // 
            BtnThoat.Location = new Point(477, 261);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(112, 34);
            BtnThoat.TabIndex = 4;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = true;
            BtnThoat.Click += BtnThoat_Click_1;
            // 
            // TxtNhap
            // 
            TxtNhap.Location = new Point(258, 47);
            TxtNhap.Name = "TxtNhap";
            TxtNhap.Size = new Size(150, 31);
            TxtNhap.TabIndex = 5;
            TxtNhap.TextChanged += TxtNhap_TextChanged;
            // 
            // TxtTong
            // 
            TxtTong.Location = new Point(260, 171);
            TxtTong.Name = "TxtTong";
            TxtTong.ReadOnly = true;
            TxtTong.Size = new Size(150, 31);
            TxtTong.TabIndex = 6;
            // 
            // BtnTinh
            // 
            BtnTinh.Location = new Point(257, 257);
            BtnTinh.Name = "BtnTinh";
            BtnTinh.Size = new Size(112, 34);
            BtnTinh.TabIndex = 7;
            BtnTinh.Text = "Tính";
            BtnTinh.UseVisualStyleBackColor = true;
            BtnTinh.Click += BtnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnTinh);
            Controls.Add(TxtTong);
            Controls.Add(TxtNhap);
            Controls.Add(BtnThoat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BaiTap01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnThoat;
        private TextBox TxtNhap;
        private TextBox TxtTong;
        private Button BtnTinh;
    }
}
