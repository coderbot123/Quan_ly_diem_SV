namespace QuanLyDiemSinhVien
{
    partial class frmLopHocPhan
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
            cboMaHP = new ComboBox();
            txtSiSo = new TextBox();
            txtTenGV = new TextBox();
            txtTenLopHP = new TextBox();
            txtMaLopHP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvLopHP = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvLopHP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(393, 18);
            label1.Name = "label1";
            label1.Size = new Size(318, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP HỌC PHẦN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaHP);
            groupBox1.Controls.Add(txtSiSo);
            groupBox1.Controls.Add(txtTenGV);
            groupBox1.Controls.Add(txtTenLopHP);
            groupBox1.Controls.Add(txtMaLopHP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1068, 143);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboMaHP
            // 
            cboMaHP.FormattingEnabled = true;
            cboMaHP.Location = new Point(691, 35);
            cboMaHP.Name = "cboMaHP";
            cboMaHP.Size = new Size(358, 28);
            cboMaHP.TabIndex = 10;
            // 
            // txtSiSo
            // 
            txtSiSo.Location = new Point(943, 81);
            txtSiSo.Name = "txtSiSo";
            txtSiSo.Size = new Size(106, 27);
            txtSiSo.TabIndex = 9;
            // 
            // txtTenGV
            // 
            txtTenGV.Location = new Point(691, 81);
            txtTenGV.Name = "txtTenGV";
            txtTenGV.Size = new Size(186, 27);
            txtTenGV.TabIndex = 8;
            // 
            // txtTenLopHP
            // 
            txtTenLopHP.Location = new Point(181, 81);
            txtTenLopHP.Name = "txtTenLopHP";
            txtTenLopHP.Size = new Size(326, 27);
            txtTenLopHP.TabIndex = 6;
            // 
            // txtMaLopHP
            // 
            txtMaLopHP.Location = new Point(181, 35);
            txtMaLopHP.Name = "txtMaLopHP";
            txtMaLopHP.Size = new Size(326, 27);
            txtMaLopHP.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(895, 88);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 4;
            label6.Text = "Sĩ số:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(563, 88);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 3;
            label5.Text = "Tên giảng viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(563, 42);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã học phần:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên lớp học phần:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 42);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã lớp học phần:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLopHP);
            groupBox2.Location = new Point(12, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1068, 313);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvLopHP
            // 
            dgvLopHP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHP.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvLopHP.Location = new Point(6, 26);
            dgvLopHP.Name = "dgvLopHP";
            dgvLopHP.RowHeadersWidth = 51;
            dgvLopHP.RowTemplate.Height = 29;
            dgvLopHP.Size = new Size(1056, 281);
            dgvLopHP.TabIndex = 0;
            dgvLopHP.CellClick += dgvLopHP_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaLopHP";
            Column1.HeaderText = "Mã lớp học phần";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 210;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenLopHP";
            Column2.HeaderText = "Tên lớp học phần";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MaHP";
            Column3.HeaderText = "Mã học phần";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TenGV";
            Column4.HeaderText = "Tên giảng viên";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SiSo";
            Column5.HeaderText = "Sĩ số";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 569);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 42);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(157, 569);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 42);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(296, 569);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 42);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(980, 569);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 42);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(435, 569);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 42);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(856, 569);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 42);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmLopHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1092, 623);
            Controls.Add(btnBoQua);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmLopHocPhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lớp học phần";
            Load += frmLopHocPhan_Load;
            Click += frmLopHocPhan_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLopHP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenLopHP;
        private TextBox txtMaLopHP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSiSo;
        private TextBox txtTenGV;
        private GroupBox groupBox2;
        private DataGridView dgvLopHP;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnBoQua;
        private ComboBox cboMaHP;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}