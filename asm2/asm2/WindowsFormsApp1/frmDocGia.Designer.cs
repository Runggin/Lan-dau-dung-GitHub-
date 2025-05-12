namespace WindowsFormsApp1
{
    partial class frmDocGia
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia, txtHoTen, txtSoThe;
        private System.Windows.Forms.Button btnThem, btnCapNhat, btnXoa;
        private System.Windows.Forms.Label lblMaDocGia, lblHoTen, lblSoThe;

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
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSoThe = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();

            // dgvDocGia
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(22, 188);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.Size = new System.Drawing.Size(562, 250);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);

            // txtMaDocGia
            this.txtMaDocGia.Location = new System.Drawing.Point(165, 25);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.ReadOnly = true;
            this.txtMaDocGia.Size = new System.Drawing.Size(200, 26);

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(165, 65);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 26);

            // txtSoThe
            this.txtSoThe.Location = new System.Drawing.Point(165, 105);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(200, 26);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(400, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnCapNhat
            this.btnCapNhat.Location = new System.Drawing.Point(500, 20);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(600, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // lblMaDocGia
            this.lblMaDocGia.Location = new System.Drawing.Point(22, 25);
            this.lblMaDocGia.Text = "Mã Độc Giả:";

            // lblHoTen
            this.lblHoTen.Location = new System.Drawing.Point(22, 65);
            this.lblHoTen.Text = "Tên Độc Giả:";

            // lblSoThe
            this.lblSoThe.Location = new System.Drawing.Point(22, 105);
            this.lblSoThe.Text = "Số Thẻ:";

            // frmDocGia
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.lblMaDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSoThe);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Name = "frmDocGia";
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
