namespace WindowsFormsApp1
{
    partial class frmMuonTra
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvMuonTra;
        private System.Windows.Forms.TextBox txtMaPhieu, txtGhiChu;
        private System.Windows.Forms.ComboBox cmbDocGia, cmbNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon, dtpNgayHetHan, dtpNgayTra;
        private System.Windows.Forms.Button btnThem, btnCapNhat, btnXoa;
        private System.Windows.Forms.CheckBox chkDaTra;

        private System.Windows.Forms.Label lblMaPhieu, lblDocGia, lblNhanVien, lblNgayMuon, lblNgayHetHan, lblTrangThai, lblNgayTra, lblGhiChu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.chkDaTra = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuonTra
            // 
            this.dgvMuonTra.ColumnHeadersHeight = 34;
            this.dgvMuonTra.Location = new System.Drawing.Point(30, 250);
            this.dgvMuonTra.Name = "dgvMuonTra";
            this.dgvMuonTra.RowHeadersWidth = 62;
            this.dgvMuonTra.Size = new System.Drawing.Size(820, 250);
            this.dgvMuonTra.TabIndex = 0;
            this.dgvMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonTra_CellClick);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(120, 30);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 26);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(550, 150);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 26);
            this.txtGhiChu.TabIndex = 2;
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.Location = new System.Drawing.Point(120, 70);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(200, 28);
            this.cmbDocGia.TabIndex = 3;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Location = new System.Drawing.Point(120, 110);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(200, 28);
            this.cmbNhanVien.TabIndex = 4;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(120, 150);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayMuon.TabIndex = 5;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(550, 30);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayHetHan.TabIndex = 6;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(550, 110);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayTra.TabIndex = 7;
            // 
            // chkDaTra
            // 
            this.chkDaTra.Location = new System.Drawing.Point(550, 70);
            this.chkDaTra.Name = "chkDaTra";
            this.chkDaTra.Size = new System.Drawing.Size(20, 20);
            this.chkDaTra.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(200, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(300, 200);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 30);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.Location = new System.Drawing.Point(30, 30);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(100, 23);
            this.lblMaPhieu.TabIndex = 12;
            this.lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // lblDocGia
            // 
            this.lblDocGia.Location = new System.Drawing.Point(30, 70);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(100, 23);
            this.lblDocGia.TabIndex = 13;
            this.lblDocGia.Text = "Độc Giả:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Location = new System.Drawing.Point(30, 110);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblNhanVien.TabIndex = 14;
            this.lblNhanVien.Text = "Nhân Viên:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.Location = new System.Drawing.Point(30, 150);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(100, 23);
            this.lblNgayMuon.TabIndex = 15;
            this.lblNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.Location = new System.Drawing.Point(450, 30);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(100, 23);
            this.lblNgayHetHan.TabIndex = 16;
            this.lblNgayHetHan.Text = "Ngày Hết Hạn:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(450, 70);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(100, 23);
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Đã Trả:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.Location = new System.Drawing.Point(450, 110);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(100, 23);
            this.lblNgayTra.TabIndex = 18;
            this.lblNgayTra.Text = "Ngày Trả:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(450, 150);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(100, 23);
            this.lblGhiChu.TabIndex = 19;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // frmMuonTra
            // 
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvMuonTra);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cmbDocGia);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.chkDaTra);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.lblDocGia);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.lblNgayHetHan);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblGhiChu);
            this.Name = "frmMuonTra";
            this.Text = "Quản Lý Mượn/Trả Sách";
            this.Load += new System.EventHandler(this.frmMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
