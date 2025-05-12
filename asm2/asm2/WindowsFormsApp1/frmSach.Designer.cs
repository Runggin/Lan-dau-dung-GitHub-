namespace WindowsFormsApp1
{
    partial class frmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lblNXB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(17, 197);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 25;
            this.dgvSach.Size = new System.Drawing.Size(747, 203);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(99, 16);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(151, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(99, 49);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(151, 20);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(99, 81);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(151, 20);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(99, 114);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(151, 20);
            this.txtNamXuatBan.TabIndex = 4;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(325, 16);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(151, 20);
            this.txtNXB.TabIndex = 5;
            // 
            // cmbTheLoai
            // 
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Items.AddRange(new object[] {
            "Kinh dị",
            "Hành động",
            "Viễn tưởng",
            "Hài",
            "Tâm lý học"});
            this.cmbTheLoai.Location = new System.Drawing.Point(325, 49);
            this.cmbTheLoai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(151, 21);
            this.cmbTheLoai.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(487, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 25);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(487, 49);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 25);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(487, 81);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 25);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(487, 114);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 25);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(487, 146);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(182, 25);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm theo tên sách";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(15, 19);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(51, 13);
            this.lblMaSach.TabIndex = 12;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(15, 51);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(55, 13);
            this.lblTenSach.TabIndex = 13;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(15, 84);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(46, 13);
            this.lblTacGia.TabIndex = 14;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(265, 51);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(48, 13);
            this.lblTheLoai.TabIndex = 15;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Location = new System.Drawing.Point(15, 116);
            this.lblNamXuatBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(76, 13);
            this.lblNamXuatBan.TabIndex = 16;
            this.lblNamXuatBan.Text = "Năm xuất bản:";
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(265, 19);
            this.lblNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(32, 13);
            this.lblNXB.TabIndex = 17;
            this.lblNXB.Text = "NXB:";
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 414);
            this.Controls.Add(this.lblNXB);
            this.Controls.Add(this.lblNamXuatBan);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbTheLoai);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtNamXuatBan);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.dgvSach);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmSach";
            this.Text = "x";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Label lblNXB;
    }
}