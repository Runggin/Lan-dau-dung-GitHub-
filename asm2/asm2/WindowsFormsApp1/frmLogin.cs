using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        // Thuộc tính để lấy VaiTrò về frmMain
        public string VaiTro { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=maycuabo;Initial Catalog=Net102QuanLyThuVien;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT VaiTro FROM TaiKhoan WHERE TaiKhoan = @taiKhoan AND MatKhau = @matKhau";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@matKhau", matKhau);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        VaiTro = result.ToString(); // Gán vai trò lấy được
                        this.DialogResult = DialogResult.OK; //this là frmLogin, Trả về OK cho frmMain
                        this.Close(); // Đóng form login
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hủy đăng nhập, đóng lại form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
