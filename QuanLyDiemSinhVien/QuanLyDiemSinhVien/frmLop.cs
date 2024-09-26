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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
            Load_Lop();

        }
        QLyDiemSV sv = new QLyDiemSV();
        public void Load_Lop()
        {
            dgvLop.DataSource = sv.dssv4();
        }

        public bool KT_rong4()
        {
            if (txtMaLop.Text == "") return false;
            if (txtTenLop.Text == "") return false;
            if (cboMaNganh.Text == "") return false;
            if (txtCVHT.Text == "") return false;
            return true;

        }

        public void reset_ThongTin4()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboMaNganh.Text = "";
            txtCVHT.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCVHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiLop(txtMaLop.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn lớp cần xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaLop(txtMaLop.Text.Trim());
                Load_Lop();
                reset_ThongTin4();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong4())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiLop(txtMaLop.Text.Trim()))
            {
                MessageBox.Show("Mã lớp đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaLop.Focus();
                return;
            }

            if (!sv.tontaiNganh(cboMaNganh.Text.Trim()))
            {
                MessageBox.Show("Mã ngành không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }

            sv.themLop(txtMaLop.Text.Trim().ToUpper(), txtTenLop.Text, cboMaNganh.Text, txtCVHT.Text);
            Load_Lop();
            reset_ThongTin4();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin4();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvLop.Rows[i];
            txtMaLop.Text = row.Cells[0].Value.ToString();
            txtTenLop.Text = row.Cells[1].Value.ToString();
            cboMaNganh.Text = row.Cells[2].Value.ToString();
            txtCVHT.Text = row.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiLop(txtMaLop.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn lớp cần sửa");
                return;
            }
            txtMaLop.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenLop.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaLop.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KT_rong4())
            {
                MessageBox.Show("Chưa chọn lớp cần sửa");
                return;
            }
            sv.suaLop(txtMaLop.Text.Trim(), txtTenLop.Text, cboMaNganh.Text, txtCVHT.Text);
            Load_Lop();
            txtMaLop.Enabled = true;
            btnThem.Enabled = true;
            txtTenLop.Focus();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadCombobox2();
            reset_ThongTin4();
        }

        public void LoadCombobox2()
        {
            SqlConnection conn;
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaNganh From Nganh", conn);
                da.Fill(dt);
                sv.dongKetNoi();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.ToString);
            }

            try
            {
                cboMaNganh.DataSource = dt;
                cboMaNganh.DisplayMember = "MaNganh";
                cboMaNganh.ValueMember = "MaNganh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
            conn.Close();
        }

        private void frmLop_Click(object sender, EventArgs e)
        {
           
        }
    }
}
