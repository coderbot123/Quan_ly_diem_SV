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

    public partial class frmLogin : Form
    {

        QLyDiemSV ketnoi = new QLyDiemSV();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                txtTenDN.Focus();
                return;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            if (!ketnoi.tontaiNguoiDung(txtTenDN.Text.Trim(), txtMatKhau.Text))
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }

            
            frmMain frm = new frmMain(txtTenDN.Text);
            frm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }


}
