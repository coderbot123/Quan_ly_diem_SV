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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDiemSinhVien
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
            Load_Diem();


        }
        QLyDiemSV sv = new QLyDiemSV();
        public void Load_Diem()
        {

            dgvDiem.DataSource = sv.dssv6();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiDiem(txtMaDiem.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn điểm cần sửa");
                return;
            }
            txtMaDiem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cboMaHP.Focus();
        }

        public bool KT_rong6()
        {
            if (txtMaDiem.Text == "") return false;
            if (cboMaHP.Text == "") return false;
            if (cboMaSV.Text == "") return false;
            if (cboLoaiDiem.Text == "") return false;
            if (txtGiaTriDiem.Text == "") return false;
            return true;

        }

        public void reset_ThongTin6()
        {
            txtMaDiem.Text = "";
            cboMaHP.Text = "";
            cboMaSV.Text = "";

            cboLoaiDiem.Text = "";
            txtGiaTriDiem.Text = "";
            txtGhiChu.Text = "";
            txtHoTen.Text = "";
            txtTenHP.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong6())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiDiem(txtMaDiem.Text.Trim()))
            {
                MessageBox.Show("Mã điểm đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaDiem.Focus();
                return;
            }

            if (!sv.tontaiHocPhan(cboMaHP.Text.Trim()))
            {
                MessageBox.Show("Mã học phần không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }

            if (!sv.tontaiSinhVien(cboMaSV.Text.Trim()))
            {
                MessageBox.Show("Mã sinh viên không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }

            if (sv.kTra2(cboMaHP.Text, cboMaSV.Text, cboLoaiDiem.Text))
            {
                MessageBox.Show("Loại điểm này của sinh viên đã có trong học phần, hãy nhập lại!", "Thông báo");
                return;
            }

            sv.themDiem(txtMaDiem.Text.Trim().ToUpper(), cboMaHP.Text, cboMaSV.Text,
            cboLoaiDiem.Text, txtGiaTriDiem.Text, txtGhiChu.Text);
            Load_Diem();
            reset_ThongTin6();
            txtMaDiem.Text = sv.Manhanvientutang2();            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin6();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvDiem.Rows[i];
            txtMaDiem.Text = row.Cells[0].Value.ToString();
            cboMaHP.Text = row.Cells[1].Value.ToString();
            cboMaSV.Text = row.Cells[2].Value.ToString();
            cboLoaiDiem.Text = row.Cells[3].Value.ToString();
            txtGiaTriDiem.Text = row.Cells[4].Value.ToString();
            txtGhiChu.Text = row.Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiDiem(txtMaDiem.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn điểm cần xóa, hãy kiểm tra lại");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaDiem(txtMaDiem.Text.Trim());
                Load_Diem();
                reset_ThongTin6();
                txtMaDiem.Text = sv.Manhanvientutang2();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaDiem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KT_rong6())
            {
                MessageBox.Show("Chưa chọn điểm cần sửa");
                return;
            }


            sv.suaDiem(txtMaDiem.Text.Trim(), cboMaHP.Text, cboMaSV.Text,
                cboLoaiDiem.Text, txtGiaTriDiem.Text, txtGhiChu.Text);
            Load_Diem();
            txtMaDiem.Enabled = true;
            btnThem.Enabled = true;
            cboMaHP.Focus();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            reset_ThongTin6();
            txtMaDiem.Text = sv.Manhanvientutang2();
        }

        public void LoadCombobox3()
        {
            SqlConnection conn;
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            DataTable dt1 = new DataTable();
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select MaHP From HocPhan", conn);               
                da1.Fill(dt1);

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.ToString);
            }

            try
            {
                cboMaHP.DataSource = dt1;
                cboMaHP.DisplayMember = "MaHP";
                cboMaHP.ValueMember = "MaHP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
            conn.Close();
        }

        public void LoadComboBox4()
        {
            SqlConnection conn;
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select DISTINCT SinhVien.MaSV from DangKyHocPhan, HocPhan, LopHocPhan, SinhVien " +
                    "where DangKyHocPhan.MaLopHP = LopHocPhan.MaLopHP and LopHocPhan.MaHP = HocPhan.MaHP and SinhVien.MaSV = DangKyHocPhan.MaSV and HocPhan.MaHP = '" +cboMaHP.Text +"'", conn);

            da2.Fill(dt2);
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

        private void frmDiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaHP_TextChanged(object sender, EventArgs e)
        {

        }





        private void txtMaDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDiem_Click(object sender, EventArgs e)
        {

        }

        private void cboMaHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True");
            string sqlQuery = "SELECT * FROM HocPhan WHERE MaHP = '" + cboMaHP.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string name = (string)dr["TenHP"].ToString();
                txtTenHP.Text = name;
            }
        }

        private void cboMaHP_Click(object sender, EventArgs e)
        {
            LoadCombobox3();
        }

        private void cboMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True");
            string sqlQuery = "SELECT * FROM SinhVien WHERE MaSV = '" + cboMaSV.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string name = (string)dr["HoTen"].ToString();
                txtHoTen.Text = name;
            }
        }

        private void cboMaSV_Click(object sender, EventArgs e)
        {
            LoadComboBox4();
        }
    }
}
