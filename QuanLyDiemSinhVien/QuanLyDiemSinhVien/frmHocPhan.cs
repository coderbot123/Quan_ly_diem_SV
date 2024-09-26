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
    public partial class frmHocPhan : Form
    {
        public frmHocPhan()
        {
            InitializeComponent();
            Load_HocPhan();
        }
        QLyDiemSV sv = new QLyDiemSV();
        public void Load_HocPhan()
        {
            dgvHocPhan.DataSource = sv.dssv5();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool KT_rong5()
        {
            if (txtMaHP.Text == "") return false;
            if (txtTenHP.Text == "") return false;
            if (txtSoTinChi.Text == "") return false;
            return true;

        }

        public void reset_ThongTin5()
        {
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            txtSoTinChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong5())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiHocPhan(txtMaHP.Text.Trim()))
            {
                MessageBox.Show("Mã học phần đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaHP.Focus();
                return;
            }

            sv.themHocPhan(txtMaHP.Text.Trim().ToUpper(), txtTenHP.Text, txtSoTinChi.Text);
            Load_HocPhan();
            reset_ThongTin5();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin5();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvHocPhan.Rows[i];
            txtMaHP.Text = row.Cells[0].Value.ToString();
            txtTenHP.Text = row.Cells[1].Value.ToString();
            txtSoTinChi.Text = row.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiHocPhan(txtMaHP.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn học phần cần xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaHocPhan(txtMaHP.Text.Trim());
                Load_HocPhan();
                reset_ThongTin5();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiHocPhan(txtMaHP.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn học phần cần sửa");
                return;
            }
            txtMaHP.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenHP.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaHP.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!KT_rong5())
            {
                MessageBox.Show("Chưa chọn học phần cần sửa");
                return;
            }
            sv.suaHocPhan(txtMaHP.Text.Trim(), txtTenHP.Text, txtSoTinChi.Text);
            Load_HocPhan();
            txtMaHP.Enabled = true;
            btnThem.Enabled = true;
            txtTenHP.Focus();
        }

        private void frmHocPhan_Load(object sender, EventArgs e)
        {

        }
    }
}
