using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace QuanLyDiemSinhVien
{
    public partial class frmSinhVien : Form
    {
        
        public frmSinhVien()
        {
            InitializeComponent();
            Load_SinhVien();
            if (sv.timkiemSV(txtTimKiem.Text.Trim()))
            {
                Load_SinhVien1();
            }
            
        }

        QLyDiemSV sv = new QLyDiemSV();
        public void Load_SinhVien()
        {
            dgvSinhVien.DataSource = sv.dssv1();
        }

        public bool KT_rong()
        {
            if (txtMaSV.Text == "") return false;
            if (txtHoTen.Text == "") return false;
            if (txtQueQuan.Text == "") return false;
            if (txtSoDT.Text == "") return false;
            if (txtCheDoUT.Text == "") return false;
            if (cboMaLop.Text == "") return false;
            if (txtDiaChi.Text == "") return false;
            return true;

        }

        public void reset_ThongTin()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtQueQuan.Text = "";
            rdoNam.Checked = true;
            dtpNgaySinh.Text = "";
            txtSoDT.Text = "";
            txtCheDoUT.Text = "";
            cboMaLop.Text = "";
            txtDiaChi.Text = "";
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            if (sv.tontaiSinhVien(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaSV.Focus();
                return;
            }

            if (!sv.tontaiLop(cboMaLop.Text.Trim()))
            {
                MessageBox.Show("Mã lớp không tồn tại, hãy nhập lại!", "Thông báo");
                return;
            }

            string gt;
            if (rdoNam.Checked) gt = "Nam";
            else gt = "Nữ";
            sv.themSinhVien(txtMaSV.Text.Trim().ToUpper(), txtHoTen.Text, txtQueQuan.Text, gt,
                DateTime.Parse(dtpNgaySinh.Text), txtSoDT.Text, txtCheDoUT.Text, cboMaLop.Text, txtDiaChi.Text);
            Load_SinhVien();
            reset_ThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                reset_ThongTin();
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row = dgvSinhVien.Rows[i];
            txtMaSV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtQueQuan.Text = row.Cells[2].Value.ToString();
            string gt = row.Cells[3].Value.ToString();
            if (gt == "Nam") rdoNam.Checked = true;
            else rdoNu.Checked = true;
            dtpNgaySinh.Text = row.Cells[4].Value.ToString();
            txtSoDT.Text = row.Cells[5].Value.ToString();
            txtCheDoUT.Text = row.Cells[6].Value.ToString();
            cboMaLop.Text = row.Cells[7].Value.ToString();
            txtDiaChi.Text = row.Cells[8].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiSinhVien(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn sinh viên cần xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sv.xoaSinhVien(txtMaSV.Text.Trim());
                Load_SinhVien();
                reset_ThongTin();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!sv.tontaiSinhVien(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn sinh viên cần sửa");
                return;
            }
            txtMaSV.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtHoTen.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa chọn sinh viên cần sửa");
                return;
            }
            string gt;
            if (rdoNam.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nu";
            sv.suaSinhVien(txtMaSV.Text.Trim(), txtHoTen.Text, txtQueQuan.Text, gt,
                DateTime.Parse(dtpNgaySinh.Text), txtSoDT.Text, txtCheDoUT.Text, cboMaLop.Text, txtDiaChi.Text);
            Load_SinhVien();
            txtMaSV.Enabled = true;
            btnThem.Enabled = true;
            txtHoTen.Focus();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            reset_ThongTin();
        }

        public void Load_SinhVien1()
        {
            dgvSinhVien.DataSource = sv.TK(txtTimKiem.Text.Trim());
            LoadCombobox();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (sv.timkiemSV(txtTimKiem.Text.Trim()))
            {
                
                reset_ThongTin();
                Load_SinhVien1();
                btnThem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }


        
       
        
        public void LoadCombobox()
        {
            SqlConnection conn;
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            DataTable dt = new DataTable();
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaLop From Lop", conn);
                da.Fill(dt);
            
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.ToString);
            }

            try
            {
                cboMaLop.DataSource = dt;
                cboMaLop.DisplayMember = "MaLop";
                cboMaLop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi");
            }
            conn.Close();
        }
    }
}