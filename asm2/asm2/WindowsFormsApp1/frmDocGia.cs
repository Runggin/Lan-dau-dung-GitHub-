using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDocGia : Form
    {
        string connectionString = "Data Source=maycuabo;Initial Catalog=Net102QuanLyThuVien;Integrated Security=True;";

        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // 📌 Hàm tải danh sách độc giả lên DataGridView
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaDocGia, TenDocGia, SoThe FROM DocGia";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDocGia.DataSource = dt;

                // Cập nhật tên hiển thị cột
                dgvDocGia.Columns["MaDocGia"].HeaderText = "Mã Độc Giả";
                dgvDocGia.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
                dgvDocGia.Columns["SoThe"].HeaderText = "Số Thẻ";
            }
        }

        // 📌 Xử lý chọn dòng
        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];

                txtMaDocGia.Text = row.Cells["MaDocGia"].Value?.ToString();
                txtHoTen.Text = row.Cells["TenDocGia"].Value?.ToString();
                txtSoThe.Text = row.Cells["SoThe"].Value?.ToString();
            }
        }

        // 📌 Thêm độc giả
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSoThe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra trùng số thẻ
                string checkQuery = "SELECT COUNT(*) FROM DocGia WHERE SoThe = @SoThe";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Số thẻ đã tồn tại. Vui lòng nhập số thẻ khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO DocGia (TenDocGia, SoThe) VALUES (@TenDocGia, @SoThe)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDocGia", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // 📌 Cập nhật độc giả
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn độc giả cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE DocGia SET TenDocGia=@TenDocGia, SoThe=@SoThe WHERE MaDocGia=@MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);
                cmd.Parameters.AddWithValue("@TenDocGia", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@SoThe", txtSoThe.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // 📌 Xóa độc giả
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM DocGia WHERE MaDocGia=@MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
    }
}
