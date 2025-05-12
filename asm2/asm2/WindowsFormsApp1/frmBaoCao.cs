using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBaoCao : Form
    {
        string connectionString = "Data Source=maycuabo;Initial Catalog=Net102QuanLyThuVien;Integrated Security=True;";

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            ThongKeSoLuongSach();
            ThongKeSachMuonTra();
            ThongKeTheoTheLoai();
        }

        //  Số lượng sách hiện có
        private void ThongKeSoLuongSach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Sach";
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                lblTongSach.Text = $"Tổng số sách: {count}";
            }
        }

        // Thống kê sách mượn / trả
        private void ThongKeSachMuonTra()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM PhieuMuon WHERE TrangThaiTra = 0) AS ChuaTra,
                        (SELECT COUNT(*) FROM PhieuMuon WHERE TrangThaiTra = 1) AS DaTra";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblSachChuaTra.Text = $"Phiếu chưa trả: {reader["ChuaTra"]}";
                    lblSachDaTra.Text = $"Phiếu đã trả: {reader["DaTra"]}";
                }
                reader.Close();
            }
        }

        //  Thống kê sách theo thể loại
        private void ThongKeTheoTheLoai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT TL.TenTheLoai, COUNT(S.MaSach) AS SoLuong
                    FROM Sach S
                    JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai
                    GROUP BY TL.TenTheLoai";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThongKeTheLoai.DataSource = dt;

                dgvThongKeTheLoai.Columns["TenTheLoai"].HeaderText = "Thể Loại";
                dgvThongKeTheLoai.Columns["SoLuong"].HeaderText = "Số Lượng Sách";

                dgvThongKeTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        // Tìm kiếm sách
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT S.MaSach, S.TenSach, S.TacGia, TL.TenTheLoai, S.NXB, S.NamXuatBan
                    FROM Sach S
                    JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai
                    WHERE S.TenSach LIKE @keyword OR S.TacGia LIKE @keyword OR TL.TenTheLoai LIKE @keyword";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + tuKhoa + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKetQuaTimKiem.DataSource = dt;

                dgvKetQuaTimKiem.Columns["MaSach"].HeaderText = "Mã Sách";
                dgvKetQuaTimKiem.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvKetQuaTimKiem.Columns["TacGia"].HeaderText = "Tác Giả";
                dgvKetQuaTimKiem.Columns["TenTheLoai"].HeaderText = "Thể Loại";
                dgvKetQuaTimKiem.Columns["NXB"].HeaderText = "Nhà Xuất Bản";
                dgvKetQuaTimKiem.Columns["NamXuatBan"].HeaderText = "Năm XB";

                dgvKetQuaTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }
    }
}
