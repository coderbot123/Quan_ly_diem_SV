namespace QuanLyDiemSinhVien
{
    partial class frmHocPhan
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
            txtSoTinChi = new TextBox();
            txtTenHP = new TextBox();
            txtMaHP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvHocPhan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            button1 = new Button();
            btnBoQua = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocPhan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(421, 26);
            label1.Name = "label1";
            label1.Size = new Size(264, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HỌC PHẦN";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoTinChi);
            groupBox1.Controls.Add(txtTenHP);
            groupBox1.Controls.Add(txtMaHP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 441);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(139, 144);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(65, 27);
            txtSoTinChi.TabIndex = 5;
            // 
            // txtTenHP
            // 
            txtTenHP.Location = new Point(139, 86);
            txtTenHP.Name = "txtTenHP";
            txtTenHP.Size = new Size(306, 27);
            txtTenHP.TabIndex = 4;
            // 
            // txtMaHP
            // 
            txtMaHP.Location = new Point(139, 31);
            txtMaHP.Name = "txtMaHP";
            txtMaHP.Size = new Size(306, 27);
            txtMaHP.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 151);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Số tín chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên học phần:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 38);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã học phần:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHocPhan);
            groupBox2.Location = new Point(514, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(562, 441);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvHocPhan
            // 
            dgvHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocPhan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvHocPhan.Location = new Point(31, 31);
            dgvHocPhan.Name = "dgvHocPhan";
            dgvHocPhan.RowHeadersWidth = 51;
            dgvHocPhan.RowTemplate.Height = 29;
            dgvHocPhan.Size = new Size(502, 394);
            dgvHocPhan.TabIndex = 0;
            dgvHocPhan.CellClick += dgvHocPhan_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaHP";
            Column1.HeaderText = "Mã học phần";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenHP";
            Column2.HeaderText = "Tên học phần";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SoTinChi";
            Column3.HeaderText = "Số tín chỉ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 553);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 45);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(190, 553);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 45);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(349, 553);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 45);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(965, 553);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 45);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(501, 553);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 7;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(837, 553);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 45);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1094, 610);
            Controls.Add(btnBoQua);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmHocPhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Học phần";
            Load += frmHocPhan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocPhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSoTinChi;
        private TextBox txtTenHP;
        private TextBox txtMaHP;
        private GroupBox groupBox2;
        private DataGridView dgvHocPhan;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button1;
        private Button btnBoQua;
    }
}