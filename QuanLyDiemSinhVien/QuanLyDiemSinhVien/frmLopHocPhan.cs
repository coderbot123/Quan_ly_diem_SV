using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frmLopHocPhan : Form
    {
        public frmLopHocPhan()
        {
            InitializeComponent();
            Load_LopHP();

        }
        QLyDiemSV sv = new QLyDiemSV();
        public void Load_LopHP()
        {
            dgvLopHP.DataSource = sv.dssv3();
        }

        public bool KT_rong3()
        {
            if (txtMaLopHP.Text == "") return false;
            if (txtTenLopHP.Text == "") return false;
            if (cboMaHP.Text == "") return false;
            if (txtTenGV.Text == "") return false;
            return true;

        }

        public void reset_ThongTin3()
        {
            txtMaLopHP.Text = "";
            txtTenLopHP.Text = "";
            cboMaHP.Text = "";
            txtTenGV.Text = "";
            txtSiSo.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong3())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiLopHocPhan(txtMaLopHP.Text.Trim()))
            {
                MessageBox.Show("Mã lớp học phần đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaLopHP.Focus();
                return;
            }

            if (!sv.tontaiHocPhan(cboMaHP.Text.Trim()))
            {
                MessageBox.Show("Mã học phần không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }



            sv.themLopHocPhan(txtMaLopHP.Text.Trim().ToUpper(), txtTenLopHP.Text, cboMaHP.Text,
                txtTenGV.Text, txtSiSo.Text);
            Load_LopHP();
            reset_ThongTin3();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvLopHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin3();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvLopHP.Rows[i];
            txtMaLopHP.Text = row.Cells[0].Value.ToString();
            txtTenLopHP.Text = row.Cells[1].Value.ToString();
            cboMaHP.Text = row.Cells[2].Value.ToString();
            txtTenGV.Text = row.Cells[3].Value.ToString();
            txtSiSo.Text = row.Cells[4].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiLopHocPhan(txtMaLopHP.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn lớp học phần cần xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaLopHocPhan(txtMaLopHP.Text.Trim());
                Load_LopHP();
                reset_ThongTin3();
            }
        }

        private void frmLopHocPhan_Load(object sender, EventArgs e)
        {
            txtSiSo.Enabled = false;
            LoadCombobox1();
            reset_ThongTin3();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiLopHocPhan(txtMaLopHP.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn lớp học phần cần sửa");
                return;
            }
            txtMaLopHP.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenLopHP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KT_rong3())
            {
                MessageBox.Show("Chưa chọn lớp học phần cần sửa");
                return;
            }
            sv.suaLopHocPhan(txtMaLopHP.Text.Trim(), txtTenLopHP.Text, cboMaHP.Text, txtTenGV.Text, txtSiSo.Text);
            Load_LopHP();
            txtMaLopHP.Enabled = true;
            btnThem.Enabled = true;
            txtTenLopHP.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaLopHP.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        public void LoadCombobox1()
        {
            SqlConnection conn;
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaHP From HocPhan", conn);
                da.Fill(dt);
                sv.dongKetNoi();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.ToString);
            }

            try
            {
                cboMaHP.DataSource = dt;
                cboMaHP.DisplayMember = "MaHP";
                cboMaHP.ValueMember = "MaHP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
            conn.Close();
        }

        private void frmLopHocPhan_Click(object sender, EventArgs e)
        {           
            Load_LopHP();
        }
    }
}
