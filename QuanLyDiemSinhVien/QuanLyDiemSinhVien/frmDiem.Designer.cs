namespace QuanLyDiemSinhVien
{
    partial class frmDiem
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
            txtHoTen = new TextBox();
            txtTenHP = new TextBox();
            cboLoaiDiem = new ComboBox();
            cboMaSV = new ComboBox();
            cboMaHP = new ComboBox();
            txtGhiChu = new RichTextBox();
            label7 = new Label();
            txtGiaTriDiem = new TextBox();
            label6 = new Label();
            txtMaDiem = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dgvDiem = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            MaSV = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            button4 = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnBoQua = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(427, 21);
            label1.Name = "label1";
            label1.Size = new Size(194, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtTenHP);
            groupBox1.Controls.Add(cboLoaiDiem);
            groupBox1.Controls.Add(cboMaSV);
            groupBox1.Controls.Add(cboMaHP);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGiaTriDiem);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMaDiem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1067, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(274, 75);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(254, 27);
            txtHoTen.TabIndex = 16;
            // 
            // txtTenHP
            // 
            txtTenHP.Location = new Point(274, 30);
            txtTenHP.Name = "txtTenHP";
            txtTenHP.Size = new Size(254, 27);
            txtTenHP.TabIndex = 15;
            txtTenHP.TextChanged += txtMaHP_TextChanged;
            // 
            // cboLoaiDiem
            // 
            cboLoaiDiem.FormattingEnabled = true;
            cboLoaiDiem.Items.AddRange(new object[] { "Điểm thường xuyên", "Điểm thi", "Điểm chuyên cần" });
            cboLoaiDiem.Location = new Point(369, 116);
            cboLoaiDiem.Name = "cboLoaiDiem";
            cboLoaiDiem.Size = new Size(159, 28);
            cboLoaiDiem.TabIndex = 14;
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(180, 74);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(88, 28);
            cboMaSV.TabIndex = 13;
            cboMaSV.SelectedIndexChanged += cboMaSV_SelectedIndexChanged;
            cboMaSV.Click += cboMaSV_Click;
            // 
            // cboMaHP
            // 
            cboMaHP.FormattingEnabled = true;
            cboMaHP.Location = new Point(180, 30);
            cboMaHP.Name = "cboMaHP";
            cboMaHP.Size = new Size(88, 28);
            cboMaHP.TabIndex = 12;
            cboMaHP.SelectedIndexChanged += cboMaHP_SelectedIndexChanged;
            cboMaHP.Click += cboMaHP_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(646, 38);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(403, 170);
            txtGhiChu.TabIndex = 11;
            txtGhiChu.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 38);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 10;
            label7.Text = "Ghi chú:";
            // 
            // txtGiaTriDiem
            // 
            txtGiaTriDiem.Location = new Point(180, 164);
            txtGiaTriDiem.Name = "txtGiaTriDiem";
            txtGiaTriDiem.Size = new Size(46, 27);
            txtGiaTriDiem.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 171);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 8;
            label6.Text = "Giá trị điểm:";
            // 
            // txtMaDiem
            // 
            txtMaDiem.Location = new Point(180, 116);
            txtMaDiem.Name = "txtMaDiem";
            txtMaDiem.Size = new Size(88, 27);
            txtMaDiem.TabIndex = 4;
            txtMaDiem.Click += txtMaDiem_Click;
            txtMaDiem.TextChanged += txtMaDiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 122);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 3;
            label5.Text = "Loại điểm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 82);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 38);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã học phần:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 123);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã điểm:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDiem);
            groupBox3.Location = new Point(12, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1067, 263);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dgvDiem
            // 
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, MaSV, Column4, Column5, Column6 });
            dgvDiem.Location = new Point(31, 26);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersWidth = 51;
            dgvDiem.RowTemplate.Height = 29;
            dgvDiem.Size = new Size(1018, 221);
            dgvDiem.TabIndex = 0;
            dgvDiem.CellClick += dgvDiem_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaDiem";
            Column1.HeaderText = "Mã điểm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 160;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaHP";
            Column2.HeaderText = "Mã học phần";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 160;
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "Mã sinh viên";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "LoaiDiem";
            Column4.HeaderText = "Loại điểm";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "GiaTriDiem";
            Column5.HeaderText = "Giá trị điểm";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "GhiChu";
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 250;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(46, 571);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(192, 572);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 43);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(325, 572);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 44);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1007, 588);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(958, 571);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 44);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(458, 572);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 44);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(825, 572);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 42);
            btnBoQua.TabIndex = 9;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1091, 626);
            Controls.Add(btnBoQua);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(button4);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Điểm";
            Load += frmDiem_Load;
            Click += frmDiem_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaDiem;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtGiaTriDiem;
        private Label label6;
        private RichTextBox txtGhiChu;
        private Label label7;
        private GroupBox groupBox3;
        private DataGridView dgvDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button button4;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnBoQua;
        private ComboBox cboLoaiDiem;
        private ComboBox cboMaSV;
        private ComboBox cboMaHP;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox txtHoTen;
        private TextBox txtTenHP;
    }
}