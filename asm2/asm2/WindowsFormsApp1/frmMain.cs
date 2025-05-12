using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        private string vaiTro = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            var result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                vaiTro = loginForm.VaiTro;
                PhanQuyen();
            }
            else
            {
                Application.Exit();
            }
        }

        private void PhanQuyen()
        {
            if (vaiTro == "ThuThu")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }
            else if (vaiTro == "Admin")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                vaiTro = loginForm.VaiTro;
                PhanQuyen();
            }
            else
            {
                Application.Exit();
            }
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.MdiParent = this; // Đặt MDI Parent
            frm.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.MdiParent = this; // Đặt MDI Parent
            frm.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.MdiParent = this; // Đặt MDI Parent
            frm.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.MdiParent = this; // Đặt MDI Parent
            frm.Show();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonTra frm = new frmMuonTra();
            frm.MdiParent = this; // Đặt MDI Parent
            frm.Show();
        }
    }
}
