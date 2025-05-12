using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSach : Form
    {
        string connectionString = "Data Source=maycuabo;Initial Catalog=Net102QuanLyThuVien;Integrated Security=True";

        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTheLoai();
        }

        // 📌 Hàm tải danh sách sách với tên thể loại thay vì mã thể loại
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, TheLoai.TenTheLoai AS TheLoai, 
                           Sach.NamXuatBan, Sach.NXB
                    FROM Sach
                    inner JOIN TheLoai ON Sach.MaTheLoai = TheLoai.MaTheLoai";  
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSach.DataSource = dt;
            }
        }

        // 📌 Hàm tải danh sách thể loại vào ComboBox
        private void LoadTheLoai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenTheLoai FROM TheLoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbTheLoai.Items.Clear();
                while (reader.Read())
                {
                    cmbTheLoai.Items.Add(reader["TenTheLoai"].ToString());
                }
                reader.Close();
            }
        }

        // 📌 Xử lý khi chọn một dòng trong DataGridView
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                txtMaSach.Text = row.Cells["MaSach"].Value?.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value?.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value?.ToString();
                txtNXB.Text = row.Cells["NXB"].Value?.ToString();
                cmbTheLoai.SelectedItem = row.Cells["TheLoai"].Value.ToString();
            }
        }

        // 📌 Thêm sách mới vào CSDL
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || txtTacGia.Text == "" || cmbTheLoai.SelectedItem == null ||
                txtNamXuatBan.Text == "" || txtNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Tìm MaTheLoai từ TenTheLoai
                string queryFind = "SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = @TenTheLoai";
                SqlCommand cmdFind = new SqlCommand(queryFind, conn);
                cmdFind.Parameters.AddWithValue("@TenTheLoai", cmbTheLoai.SelectedItem.ToString());
                object maTheLoai = cmdFind.ExecuteScalar();

                if (maTheLoai == null)
                {
                    MessageBox.Show("Thể loại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chèn dữ liệu vào bảng Sach
                string queryInsert = "INSERT INTO Sach (TenSach, TacGia, MaTheLoai, NamXuatBan, NXB) " +
                                     "VALUES (@TenSach, @TacGia, @MaTheLoai, @NamXuatBan, @NXB)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmdInsert.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                cmdInsert.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmdInsert.Parameters.AddWithValue("@NamXuatBan", txtNamXuatBan.Text);
                cmdInsert.Parameters.AddWithValue("@NXB", txtNXB.Text);

                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // 📌 Cập nhật thông tin sách
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryFind = "SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = @TenTheLoai";
                SqlCommand cmdFind = new SqlCommand(queryFind, conn);
                cmdFind.Parameters.AddWithValue("@TenTheLoai", cmbTheLoai.SelectedItem.ToString());
                object maTheLoai = cmdFind.ExecuteScalar();

                if (maTheLoai == null)
                {
                    MessageBox.Show("Thể loại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string queryUpdate = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, MaTheLoai = @MaTheLoai, " +
                                     "NamXuatBan = @NamXuatBan, NXB = @NXB WHERE MaSach = @MaSach";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmdUpdate.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmdUpdate.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                cmdUpdate.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmdUpdate.Parameters.AddWithValue("@NamXuatBan", txtNamXuatBan.Text);
                cmdUpdate.Parameters.AddWithValue("@NXB", txtNXB.Text);

                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sach WHERE TenSach LIKE @TenSach", conn);
                da.SelectCommand.Parameters.AddWithValue("@TenSach", "%" + txtTenSach.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSach.DataSource = dt;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXuatBan.Clear();
            txtNXB.Clear();
            cmbTheLoai.SelectedIndex = -1; // Reset ComboBox selection
        }
        // 📌 Xóa sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryDelete = "DELETE FROM Sach WHERE MaSach = @MaSach";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, conn);
                cmdDelete.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
    }
}
