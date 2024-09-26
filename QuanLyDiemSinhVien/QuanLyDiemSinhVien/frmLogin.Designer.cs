namespace QuanLyDiemSinhVien
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTenDN = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 111);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 172);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(386, 104);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(278, 27);
            txtTenDN.TabIndex = 2;
            txtTenDN.KeyPress += txtTenDN_KeyPress;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(386, 165);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(278, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.KeyPress += txtMatKhau_KeyPress;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(351, 226);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(109, 48);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(522, 226);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 48);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(241, 19);
            label3.Name = "label3";
            label3.Size = new Size(255, 35);
            label3.TabIndex = 6;
            label3.Text = "Đăng nhập hệ thống";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.z4985616051417_1d1cd98bbc5c9e791e210faa9970f1c5;
            pictureBox1.Location = new Point(12, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(696, 363);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenDN;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private Label label3;
        private PictureBox pictureBox1;
    }
}