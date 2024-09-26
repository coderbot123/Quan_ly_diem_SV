using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frmDangKyHocPhan : Form
    {
        public frmDangKyHocPhan()
        {
            InitializeComponent();
            Load_DangKyHocPhan();

        }
        QLyDiemSV sv = new QLyDiemSV();
        public void Load_DangKyHocPhan()
        {

            dgvDKHP.DataSource = sv.dssv7();
        }

        private void DangKyHocPhan_Load(object sender, EventArgs e)
        {
            LoadCombobox3();
            reset_ThongTin7();
            txtMaDK.Text = sv.Manhanvientutang();
        }

        public bool KT_rong7()
        {
            if (txtMaDK.Text == "") return false;
            if (cboMaLopHP.Text == "") return false;
            if (cboMaSV.Text == "") return false;

            return true;

        }

        public void reset_ThongTin7()
        {
            txtMaDK.Text = "";
            cboMaLopHP.Text = "";

            cboMaSV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong7())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiDangKyHocPhan(txtMaDK.Text.Trim()))
            {
                MessageBox.Show("Mã đăng ký đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaDK.Focus();
                return;
            }

            if (!sv.tontaiLopHocPhan(cboMaLopHP.Text.Trim()))
            {
                MessageBox.Show("Mã học phần không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }

            if (!sv.tontaiSinhVien(cboMaSV.Text.Trim()))
            {
                MessageBox.Show("Mã sinh viên không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }

            if (sv.kTra(cboMaLopHP.Text, cboMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại trong lớp học phần, hãy nhập lại!", "Thông báo");
                return;
            }

            sv.themDangKyHocPhan(txtMaDK.Text.Trim().ToUpper(), cboMaLopHP.Text, cboMaSV.Text, dtpNgayDangKy.Text);
            Load_DangKyHocPhan();
            sv.tang(cboMaLopHP.Text);
            reset_ThongTin7();
            txtMaDK.Text = sv.Manhanvientutang();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDKHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin7();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvDKHP.Rows[i];
            txtMaDK.Text = row.Cells[0].Value.ToString();
            cboMaLopHP.Text = row.Cells[1].Value.ToString();
            cboMaSV.Text = row.Cells[2].Value.ToString();
            dtpNgayDangKy.Text = row.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiDangKyHocPhan(txtMaDK.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn đăng ký học phần cần xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaDangKyHocPhan(txtMaDK.Text.Trim());
                Load_DangKyHocPhan();
                sv.giam(cboMaLopHP.Text);
                reset_ThongTin7();
                txtMaDK.Text = sv.Manhanvientutang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiDangKyHocPhan(txtMaDK.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn mã đăng ký cần sửa");
                return;
            }
            txtMaDK.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cboMaLopHP.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaDK.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KT_rong7())
            {
                MessageBox.Show("Chưa chọn đăng ký học phần  cần sửa");
                return;
            }

            if (sv.kTra(cboMaLopHP.Text, cboMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại trong lớp học phần, hãy nhập lại!", "Thông báo");
                return;
            }

            sv.suaDangKyHocPhan(txtMaDK.Text.Trim(), cboMaLopHP.Text, cboMaSV.Text, dtpNgayDangKy.Text);
            Load_DangKyHocPhan();
            txtMaDK.Enabled = true;
            btnThem.Enabled = true;
            cboMaLopHP.Focus();
        }

        public void LoadCombobox3()
        {
            SqlConnection conn;
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                string q1 = cboMaLopHP.Text;
                SqlDataAdapter da1 = new SqlDataAdapter("Select MaLopHP From LopHocPhan", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("Select MaSV From SinhVien", conn);
                da1.Fill(dt1);
                da2.Fill(dt2);

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.ToString);
            }

            try
            {
                cboMaLopHP.DataSource = dt1;
                cboMaLopHP.DisplayMember = "MaLopHP";
                cboMaLopHP.ValueMember = "MaLopHP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }

            try
            {
                cboMaSV.DataSource = dt2;
                cboMaSV.DisplayMember = "MaSV";
                cboMaSV.ValueMember = "MaSV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }


            conn.Close();
        }


        private void txtMaDK_Click(object sender, EventArgs e)
        {           
        }

        private void frmDangKyHocPhan_Click(object sender, EventArgs e)
        {
            LoadCombobox3();
            reset_ThongTin7();
        }
    }
}
