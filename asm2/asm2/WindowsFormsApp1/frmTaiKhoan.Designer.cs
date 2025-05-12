namespace WindowsFormsApp1
{
    partial class frmTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TextBox txtMaNhanVien, txtHoTen, txtSoDienThoai, txtTaiKhoan, txtMatKhau;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cmbVaiTro;
        private System.Windows.Forms.Button btnThem, btnCapNhat, btnXoa;
        private System.Windows.Forms.Label lblMaNhanVien, lblHoTen, lblNgaySinh, lblSoDienThoai, lblVaiTro, lblTaiKhoan, lblMatKhau;

        /// <summary>
        /// Giải phóng tài nguyên được sử dụng.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.cmbVaiTro = new System.Windows.Forms.ComboBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(20, 250);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(750, 250);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(157, 17);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(150, 26);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(157, 47);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 26);
            this.txtHoTen.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(157, 77);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 26);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(157, 107);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(150, 26);
            this.txtSoDienThoai.TabIndex = 8;
            // 
            // cmbVaiTro
            // 
            this.cmbVaiTro.Items.AddRange(new object[] {
            "Admin",
            "ThuThu"});
            this.cmbVaiTro.Location = new System.Drawing.Point(157, 137);
            this.cmbVaiTro.Name = "cmbVaiTro";
            this.cmbVaiTro.Size = new System.Drawing.Size(150, 28);
            this.cmbVaiTro.TabIndex = 10;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(157, 167);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(200, 26);
            this.txtTaiKhoan.TabIndex = 12;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(157, 197);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(200, 26);
            this.txtMatKhau.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(557, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(657, 20);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 30);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(757, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.Location = new System.Drawing.Point(20, 20);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblMaNhanVien.TabIndex = 1;
            this.lblMaNhanVien.Text = "Mã NV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(20, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 23);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 80);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 110);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(100, 23);
            this.lblSoDienThoai.TabIndex = 7;
            this.lblSoDienThoai.Text = "SĐT:";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.Location = new System.Drawing.Point(20, 140);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(100, 23);
            this.lblVaiTro.TabIndex = 9;
            this.lblVaiTro.Text = "Vai trò:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Location = new System.Drawing.Point(20, 170);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(100, 23);
            this.lblTaiKhoan.TabIndex = 11;
            this.lblTaiKhoan.Text = "Tài khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Location = new System.Drawing.Point(20, 200);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(100, 23);
            this.lblMatKhau.TabIndex = 13;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // frmTaiKhoan
            // 
            this.ClientSize = new System.Drawing.Size(859, 535);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.cmbVaiTro);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Name = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
