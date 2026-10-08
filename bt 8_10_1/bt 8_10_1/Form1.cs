namespace bt_8_10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào tất cả các ô!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            double donGia, soLuong, phanTramGiam;

            if (!double.TryParse(txtDonGia.Text, out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là một số hợp lệ (>= 0)!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                return;
            }

            if (!double.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng khách phải là số nguyên/số thực lớn hơn 0!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                txtSoLuong.SelectAll();
                return;
            }

            if (!double.TryParse(txtGiamGia.Text, out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
            {
                MessageBox.Show("Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiamGia.Focus();
                txtGiamGia.SelectAll();
                return;
            }

            double tongTien = (donGia * soLuong) * (100 - phanTramGiam) / 100;
            lblKetQua.Text = tongTien.ToString("Tổng tiền thanh toán: 0") + " đ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblKetQua.Text = "Tổng tiền thanh toán: 0 đ";
            txtDonGia.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDonGia.Focus();
        }
    }
}
