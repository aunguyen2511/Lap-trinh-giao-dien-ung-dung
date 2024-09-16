namespace FirstWinForms
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
            TxtChao = new Label();
            TxtHoten = new TextBox();
            BtnChao = new Button();
            BtnNhapLai = new Button();
            BtnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 62);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // TxtChao
            // 
            TxtChao.AutoSize = true;
            TxtChao.Location = new Point(73, 354);
            TxtChao.Name = "TxtChao";
            TxtChao.Size = new Size(0, 25);
            TxtChao.TabIndex = 1;
            TxtChao.Click += TxtChao_Click;
            // 
            // TxtHoten
            // 
            TxtHoten.Location = new Point(424, 61);
            TxtHoten.Name = "TxtHoten";
            TxtHoten.Size = new Size(150, 31);
            TxtHoten.TabIndex = 2;
            TxtHoten.TextChanged += TxtHoten_TextChanged;
            // 
            // BtnChao
            // 
            BtnChao.Location = new Point(425, 138);
            BtnChao.Name = "BtnChao";
            BtnChao.Size = new Size(112, 34);
            BtnChao.TabIndex = 3;
            BtnChao.Text = "Chào";
            BtnChao.UseVisualStyleBackColor = true;
            BtnChao.Click += BtnChao_Click_1;
            // 
            // BtnNhapLai
            // 
            BtnNhapLai.Location = new Point(425, 281);
            BtnNhapLai.Name = "BtnNhapLai";
            BtnNhapLai.Size = new Size(112, 34);
            BtnNhapLai.TabIndex = 4;
            BtnNhapLai.Text = "Nhập lại";
            BtnNhapLai.UseVisualStyleBackColor = true;
            BtnNhapLai.Click += BtnNhapLai_Click;
            // 
            // BtnThoat
            // 
            BtnThoat.Location = new Point(614, 287);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(112, 34);
            BtnThoat.TabIndex = 5;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = true;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnThoat);
            Controls.Add(BtnNhapLai);
            Controls.Add(BtnChao);
            Controls.Add(TxtHoten);
            Controls.Add(TxtChao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Say Hello";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TxtChao;
        private TextBox TxtHoten;
        private Button BtnChao;
        private Button BtnNhapLai;
        private Button BtnThoat;
    }
}
