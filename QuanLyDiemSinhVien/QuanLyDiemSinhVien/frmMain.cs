using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frmMain : Form
    {
        public frmMain(string tendn)
        {
            InitializeComponent();
            mnuTenDN.Text = tendn;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cậpNhậtHồSơSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmSinhVien"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmSinhVien frm = new frmSinhVien();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cậpNhậtNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmNganh"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmNganh frm = new frmNganh();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmLop"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmLop frm = new frmLop();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cậpNhậtHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmHocPhan"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmHocPhan frm = new frmHocPhan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cậpNhậtLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmLopHocPhan"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmLopHocPhan frm = new frmLopHocPhan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void quảnLýĐăngKýLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmDangKyHocPhan"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmDangKyHocPhan frm = new frmDangKyHocPhan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void xửLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmDiem"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }

            if (!kt)
            {
                frmDiem frm = new frmDiem();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
