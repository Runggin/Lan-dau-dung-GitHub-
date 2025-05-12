using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTaiKhoan : Form
    {
        string connectionString = "Data Source=maycuabo;Initial Catalog=Net102QuanLyThuVien;Integrated Security=True";

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            // Đặt định dạng ngày tháng năm
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        //  Hàm tải danh sách tài khoản lên DataGridView
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaNhanVien, HoTen, NgaySinh, SoDienThoai, VaiTro, TaiKhoan FROM TaiKhoan";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTaiKhoan.DataSource = dt;

                // 📌 Đặt tiêu đề cột tiếng Việt
                dgvTaiKhoan.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                dgvTaiKhoan.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvTaiKhoan.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvTaiKhoan.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dgvTaiKhoan.Columns["VaiTro"].HeaderText = "Vai Trò";
                dgvTaiKhoan.Columns["TaiKhoan"].HeaderText = "Tài Khoản";
                dgvTaiKhoan.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
        }

        //  Xử lý khi người dùng click vào DataGridView
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                cmbVaiTro.SelectedItem = row.Cells["VaiTro"].Value?.ToString();
                txtTaiKhoan.Text = row.Cells["TaiKhoan"].Value?.ToString();
            }
        }

        //  Thêm tài khoản mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || cmbVaiTro.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO TaiKhoan (HoTen, NgaySinh, SoDienThoai, VaiTro, TaiKhoan, MatKhau) " +
                               "VALUES (@HoTen, @NgaySinh, @SoDienThoai, @VaiTro, @TaiKhoan, @MatKhau)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@VaiTro", cmbVaiTro.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // Cập nhật tài khoản
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE TaiKhoan SET HoTen=@HoTen, NgaySinh=@NgaySinh, SoDienThoai=@SoDienThoai, " +
                               "VaiTro=@VaiTro, TaiKhoan=@TaiKhoan WHERE MaNhanVien=@MaNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@VaiTro", cmbVaiTro.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        //  Xóa tài khoản
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM TaiKhoan WHERE MaNhanVien=@MaNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
    }
}
