using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMuonTra : Form
    {
        string connectionString = "Data Source=maycuabo;Initial Catalog=Net102QuanLyThuVien;Integrated Security=True;";

        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        // Hiển thị danh sách phiếu mượn
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT PM.MaPhieu, DG.TenDocGia, TK.HoTen AS NhanVien, 
                                        PM.NgayMuon, PM.NgayHetHan, 
                                        CASE WHEN PM.TrangThaiTra = 1 THEN N'Đã trả' ELSE N'Chưa trả' END AS TrangThaiTra,
                                        PM.NgayTra, PM.GhiChu
                                 FROM PhieuMuon PM
                                 JOIN DocGia DG ON PM.MaDocGia = DG.MaDocGia
                                 JOIN TaiKhoan TK ON PM.MaNhanVien = TK.MaNhanVien";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMuonTra.DataSource = dt;

                dgvMuonTra.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                dgvMuonTra.Columns["TenDocGia"].HeaderText = "Độc Giả";
                dgvMuonTra.Columns["NhanVien"].HeaderText = "Nhân Viên";
                dgvMuonTra.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                dgvMuonTra.Columns["NgayHetHan"].HeaderText = "Ngày Hết Hạn";
                dgvMuonTra.Columns["TrangThaiTra"].HeaderText = "Trạng Thái";
                dgvMuonTra.Columns["NgayTra"].HeaderText = "Ngày Trả";
                dgvMuonTra.Columns["GhiChu"].HeaderText = "Ghi Chú";

                dgvMuonTra.Columns["NgayMuon"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvMuonTra.Columns["NgayHetHan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvMuonTra.Columns["NgayTra"].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
        }

        // 📌 Load danh sách độc giả và nhân viên vào ComboBox
        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Độc giả
                SqlDataAdapter daDG = new SqlDataAdapter("SELECT MaDocGia, TenDocGia FROM DocGia", conn);
                DataTable dtDG = new DataTable();
                daDG.Fill(dtDG);
                cmbDocGia.DataSource = dtDG;
                cmbDocGia.DisplayMember = "TenDocGia";
                cmbDocGia.ValueMember = "MaDocGia";

                // Nhân viên
                SqlDataAdapter daNV = new SqlDataAdapter("SELECT MaNhanVien, HoTen FROM TaiKhoan WHERE VaiTro = 'ThuThu'", conn);
                DataTable dtNV = new DataTable();
                daNV.Fill(dtNV);
                cmbNhanVien.DataSource = dtNV;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "MaNhanVien";
            }
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";

            dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";

            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
        }

        // Chọn dòng trên DataGridView
        private void dgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMuonTra.Rows[e.RowIndex];

                txtMaPhieu.Text = row.Cells["MaPhieu"].Value?.ToString();
                cmbDocGia.Text = row.Cells["TenDocGia"].Value?.ToString();
                cmbNhanVien.Text = row.Cells["NhanVien"].Value?.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dtpNgayHetHan.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

                string trangThai = row.Cells["TrangThaiTra"].Value?.ToString();
                chkDaTra.Checked = trangThai == "Đã trả";
                if (chkDaTra.Checked)
                {
                    dtpNgayTra.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
                }
                else
                {
                    dtpNgayTra.Value = DateTime.Today;
                }
            }
        }

        // 📌 Thêm phiếu mượn
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO PhieuMuon (MaNhanVien, MaDocGia, NgayMuon, NgayHetHan, GhiChu) 
                                 VALUES (@MaNhanVien, @MaDocGia, @NgayMuon, @NgayHetHan, @GhiChu)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", cmbNhanVien.SelectedValue);
                cmd.Parameters.AddWithValue("@MaDocGia", cmbDocGia.SelectedValue);
                cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtpNgayHetHan.Value);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // Cập nhật trạng thái trả sách
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE PhieuMuon 
                                 SET TrangThaiTra = @TrangThaiTra, 
                                     NgayTra = @NgayTra, 
                                     GhiChu = @GhiChu
                                 WHERE MaPhieu = @MaPhieu";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrangThaiTra", chkDaTra.Checked);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieu.Text);
                if (chkDaTra.Checked)
                {
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NgayTra", DBNull.Value);
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        // Xóa phiếu mượn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM PhieuMuon WHERE MaPhieu = @MaPhieu";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieu.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
    }
}
