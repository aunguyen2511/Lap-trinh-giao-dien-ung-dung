namespace BaiTap01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            if (TxtNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap N");
                return;
            }

            if (int.TryParse(TxtNhap.Text, out int N) && N > 0)
            {
                int tong = 0;
                for (int i = 0; i < N; i++)
                {
                    tong = tong + i + 1;
                }
                TxtTong.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Nhap sai roi", "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                TxtNhap.Focus();
            }
        }

        private void TxtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Thoat chuong trinh?", "Hoi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
