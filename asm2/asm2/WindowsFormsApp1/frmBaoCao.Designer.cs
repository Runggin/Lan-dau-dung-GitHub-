namespace WindowsFormsApp1
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTongSach;
        private System.Windows.Forms.Label lblSachChuaTra;
        private System.Windows.Forms.Label lblSachDaTra;
        private System.Windows.Forms.DataGridView dgvThongKeTheLoai;

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTongSach = new System.Windows.Forms.Label();
            this.lblSachChuaTra = new System.Windows.Forms.Label();
            this.lblSachDaTra = new System.Windows.Forms.Label();
            this.dgvThongKeTheLoai = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongSach
            // 
            this.lblTongSach.AutoSize = true;
            this.lblTongSach.Location = new System.Drawing.Point(30, 30);
            this.lblTongSach.Name = "lblTongSach";
            this.lblTongSach.Size = new System.Drawing.Size(108, 20);
            this.lblTongSach.TabIndex = 0;
            this.lblTongSach.Text = "Tổng số sách:";
            // 
            // lblSachChuaTra
            // 
            this.lblSachChuaTra.AutoSize = true;
            this.lblSachChuaTra.Location = new System.Drawing.Point(30, 60);
            this.lblSachChuaTra.Name = "lblSachChuaTra";
            this.lblSachChuaTra.Size = new System.Drawing.Size(115, 20);
            this.lblSachChuaTra.TabIndex = 1;
            this.lblSachChuaTra.Text = "Phiếu chưa trả:";
            // 
            // lblSachDaTra
            // 
            this.lblSachDaTra.AutoSize = true;
            this.lblSachDaTra.Location = new System.Drawing.Point(30, 90);
            this.lblSachDaTra.Name = "lblSachDaTra";
            this.lblSachDaTra.Size = new System.Drawing.Size(98, 20);
            this.lblSachDaTra.TabIndex = 2;
            this.lblSachDaTra.Text = "Phiếu đã trả:";
            // 
            // dgvThongKeTheLoai
            // 
            this.dgvThongKeTheLoai.ColumnHeadersHeight = 34;
            this.dgvThongKeTheLoai.Location = new System.Drawing.Point(30, 130);
            this.dgvThongKeTheLoai.Name = "dgvThongKeTheLoai";
            this.dgvThongKeTheLoai.RowHeadersWidth = 62;
            this.dgvThongKeTheLoai.Size = new System.Drawing.Size(600, 200);
            this.dgvThongKeTheLoai.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(30, 350);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(400, 26);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(450, 350);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(422, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm theo Tên sách (tác giả, thể loại) ";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.ColumnHeadersHeight = 34;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(30, 400);
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.RowHeadersWidth = 62;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(800, 200);
            this.dgvKetQuaTimKiem.TabIndex = 6;
            // 
            // frmBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lblTongSach);
            this.Controls.Add(this.lblSachChuaTra);
            this.Controls.Add(this.lblSachDaTra);
            this.Controls.Add(this.dgvThongKeTheLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvKetQuaTimKiem);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo và Thống kê";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
