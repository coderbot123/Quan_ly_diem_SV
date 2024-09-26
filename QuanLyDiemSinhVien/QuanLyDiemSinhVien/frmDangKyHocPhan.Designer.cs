namespace QuanLyDiemSinhVien
{
    partial class frmDangKyHocPhan
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
            groupBox1 = new GroupBox();
            dtpNgayDangKy = new DateTimePicker();
            cboMaSV = new ComboBox();
            cboMaLopHP = new ComboBox();
            label4 = new Label();
            txtMaDK = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvDKHP = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnBoQua = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDKHP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(365, 23);
            label1.Name = "label1";
            label1.Size = new Size(383, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐĂNG KÝ HỌC PHẦN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayDangKy);
            groupBox1.Controls.Add(cboMaSV);
            groupBox1.Controls.Add(cboMaLopHP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaDK);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 398);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Format = DateTimePickerFormat.Short;
            dtpNgayDangKy.Location = new Point(186, 171);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(244, 27);
            dtpNgayDangKy.TabIndex = 8;
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(186, 124);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(244, 28);
            cboMaSV.TabIndex = 7;
            // 
            // cboMaLopHP
            // 
            cboMaLopHP.FormattingEnabled = true;
            cboMaLopHP.Location = new Point(186, 80);
            cboMaLopHP.Name = "cboMaLopHP";
            cboMaLopHP.Size = new Size(244, 28);
            cboMaLopHP.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 178);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày đăng ký:";
            // 
            // txtMaDK
            // 
            txtMaDK.Location = new Point(186, 38);
            txtMaDK.Name = "txtMaDK";
            txtMaDK.Size = new Size(244, 27);
            txtMaDK.TabIndex = 4;
            txtMaDK.Click += txtMaDK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 132);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 3;
            label5.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã lớp học phần:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 45);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã đăng ký:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDKHP);
            groupBox2.Location = new Point(463, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 398);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvDKHP
            // 
            dgvDKHP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDKHP.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5 });
            dgvDKHP.Location = new Point(17, 38);
            dgvDKHP.Name = "dgvDKHP";
            dgvDKHP.RowHeadersWidth = 51;
            dgvDKHP.RowTemplate.Height = 29;
            dgvDKHP.Size = new Size(594, 354);
            dgvDKHP.TabIndex = 0;
            dgvDKHP.CellClick += dgvDKHP_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaDK";
            Column1.HeaderText = "Mã đăng ký";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaLopHP";
            Column2.HeaderText = "Mã lớp học phần";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MaSV";
            Column4.HeaderText = "Mã sinh viên";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "NgayDK";
            Column5.HeaderText = "Ngày đăng ký";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 497);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(165, 497);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 44);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(311, 497);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 44);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(978, 497);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 44);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(449, 497);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 44);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(855, 497);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 44);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmDangKyHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1092, 553);
            Controls.Add(btnBoQua);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmDangKyHocPhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký học phần";
            Load += DangKyHocPhan_Load;
            Click += frmDangKyHocPhan_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDKHP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaDK;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvDKHP;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnBoQua;
        private DateTimePicker dtpNgayDangKy;
        private ComboBox cboMaSV;
        private ComboBox cboMaLopHP;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}