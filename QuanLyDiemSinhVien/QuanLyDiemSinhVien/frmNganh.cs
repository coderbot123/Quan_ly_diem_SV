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
    public partial class frmNganh : Form
    {
        public frmNganh()
        {
            InitializeComponent();
            Load_Nganh();
        }

        QLyDiemSV sv = new QLyDiemSV();
        public void Load_Nganh()
        {
            dgvNganh.DataSource = sv.dssv2();
        }

        public bool KT_rong2()
        {
            if (txtMaNganh.Text == "") return false;
            if (txtTenNganh.Text == "") return false;
            return true;

        }

        public void reset_ThongTin2()
        {
            txtMaNganh.Text = "";
            txtTenNganh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong2())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiNganh(txtMaNganh.Text.Trim()))
            {
                MessageBox.Show("Mã ngành đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaNganh.Focus();
                return;
            }
            sv.themNganh(txtMaNganh.Text.Trim().ToUpper(), txtTenNganh.Text);
            Load_Nganh();
            reset_ThongTin2();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin2();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvNganh.Rows[i];
            txtMaNganh.Text = row.Cells[0].Value.ToString();
            txtTenNganh.Text = row.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiNganh(txtMaNganh.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn ngành cần xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaNganh(txtMaNganh.Text.Trim());
                Load_Nganh();
                reset_ThongTin2();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiNganh(txtMaNganh.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn ngành cần sửa");
                return;
            }
            txtMaNganh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenNganh.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaNganh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KT_rong2())
            {
                MessageBox.Show("Chưa chọn ngành cần sửa");
                return;
            }
            string gt;
            sv.suaNganh(txtMaNganh.Text.Trim(), txtTenNganh.Text);
            Load_Nganh();
            txtMaNganh.Enabled = true;
            btnThem.Enabled = true;
            txtTenNganh.Focus();
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {

        }
    }
}
