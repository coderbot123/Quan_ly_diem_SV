namespace QuanLyDiemSinhVien
{
    partial class frmSinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label11 = new Label();
            txtSoDT = new TextBox();
            label9 = new Label();
            txtDiaChi = new TextBox();
            txtCheDoUT = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtQueQuan = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvSinhVien = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            QueQuan = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            SoDT = new DataGridViewTextBoxColumn();
            CheDoUT = new DataGridViewTextBoxColumn();
            MaLop = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnBoQua = new Button();
            cboMaLop = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(356, 20);
            label1.Name = "label1";
            label1.Size = new Size(405, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaLop);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtCheDoUT);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Controls.Add(txtQueQuan);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1053, 266);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(369, 219);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(81, 29);
            btnTimKiem.TabIndex = 23;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.ForeColor = Color.FromArgb(64, 64, 64);
            txtTimKiem.Location = new Point(131, 221);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 27);
            txtTimKiem.TabIndex = 22;
            txtTimKiem.Text = "Nhập mã sinh viên";
            txtTimKiem.Click += txtTimKiem_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 228);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 21;
            label11.Text = "Tìm kiếm:";
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(683, 76);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(298, 27);
            txtSoDT.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(550, 79);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 19;
            label9.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(683, 221);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(298, 27);
            txtDiaChi.TabIndex = 18;
            // 
            // txtCheDoUT
            // 
            txtCheDoUT.Location = new Point(683, 129);
            txtCheDoUT.Name = "txtCheDoUT";
            txtCheDoUT.Size = new Size(298, 27);
            txtCheDoUT.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(683, 31);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(298, 27);
            dtpNgaySinh.TabIndex = 14;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(224, 182);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 13;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(142, 182);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 12;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(131, 129);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(319, 27);
            txtQueQuan.TabIndex = 11;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(131, 76);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(319, 27);
            txtHoTen.TabIndex = 10;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(131, 31);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(319, 27);
            txtMaSV.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(551, 228);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 8;
            label10.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(550, 186);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 6;
            label8.Text = "Mã lớp:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(551, 136);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 5;
            label7.Text = "Chế độ ưu tiên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 38);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 186);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 3;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 136);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "Quê quán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 83);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 38);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSinhVien);
            groupBox2.Location = new Point(19, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1053, 278);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, QueQuan, GioiTinh, NgaySinh, SoDT, CheDoUT, MaLop, DiaChi });
            dgvSinhVien.Location = new Point(12, 26);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 29;
            dgvSinhVien.Size = new Size(1041, 246);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "Mã sinh viên";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.Width = 102;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // QueQuan
            // 
            QueQuan.DataPropertyName = "QueQuan";
            QueQuan.HeaderText = "Quê quán";
            QueQuan.MinimumWidth = 6;
            QueQuan.Name = "QueQuan";
            QueQuan.Width = 140;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 70;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // SoDT
            // 
            SoDT.DataPropertyName = "SoDT";
            SoDT.HeaderText = "Số điện thoại";
            SoDT.MinimumWidth = 6;
            SoDT.Name = "SoDT";
            SoDT.Width = 125;
            // 
            // CheDoUT
            // 
            CheDoUT.DataPropertyName = "CheDoUT";
            CheDoUT.HeaderText = "Chế độ ưu tiên";
            CheDoUT.MinimumWidth = 6;
            CheDoUT.Name = "CheDoUT";
            CheDoUT.Width = 80;
            // 
            // MaLop
            // 
            MaLop.DataPropertyName = "MaLop";
            MaLop.HeaderText = "Mã lớp";
            MaLop.MinimumWidth = 6;
            MaLop.Name = "MaLop";
            MaLop.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 145;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(31, 631);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(172, 631);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 44);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(301, 631);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 44);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(950, 631);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 44);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(436, 631);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 44);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(823, 631);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(103, 44);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // cboMaLop
            // 
            cboMaLop.FormattingEnabled = true;
            cboMaLop.Location = new Point(683, 178);
            cboMaLop.Name = "cboMaLop";
            cboMaLop.Size = new Size(298, 28);
            cboMaLop.TabIndex = 24;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1078, 683);
            Controls.Add(btnBoQua);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sinh viên";
            Load += frmSinhVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtQueQuan;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private TextBox txtDiaChi;
        private TextBox txtCheDoUT;
        private DateTimePicker dtpNgaySinh;
        private GroupBox groupBox2;
        private DataGridView dgvSinhVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnBoQua;
        private TextBox txtSoDT;
        private Label label9;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn QueQuan;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn SoDT;
        private DataGridViewTextBoxColumn CheDoUT;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn DiaChi;
        private TextBox txtTimKiem;
        private Label label11;
        private Button btnTimKiem;
        private ComboBox cboMaLop;
    }
}