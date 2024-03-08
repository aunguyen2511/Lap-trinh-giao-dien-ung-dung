namespace FirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtHoten_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnChao_Click_1(object sender, EventArgs e)
        {
            if (TxtHoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chua nhap ho ten");
                return;
            }
            int gioHienTai = DateTime.Now.Hour;
            string buoi = string.Empty;
            if(gioHienTai > 18) 
            {
                buoi = "buoi toi";
            }
            else if(gioHienTai > 15)             
            {
                buoi = "buoi chieu";
            }
            else if(gioHienTai > 10) 
            {
                buoi = "buoi trua";
            }
            else
            {
                buoi = "buoi sang";
            }
            string loiChao = $"Chao {TxtHoten.Text.Trim()}. Chao {buoi}. Bay gio la {gioHienTai} gio.";
            TxtChao.Text = loiChao;
        }

        private void TxtChao_Click(object sender, EventArgs e)
        {

        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            TxtHoten.Text = string.Empty;
            TxtChao.Text = string.Empty;
            TxtHoten.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Thoat chuong trinh?", "Hoi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(traLoi== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
