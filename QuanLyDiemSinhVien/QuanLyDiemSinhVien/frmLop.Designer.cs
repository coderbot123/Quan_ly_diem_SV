namespace QuanLyDiemSinhVien
{
    partial class frmLop
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
            cboMaNganh = new ComboBox();
            txtCVHT = new TextBox();
            txtTenLop = new TextBox();
            txtMaLop = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvLop = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            button4 = new Button();
            btnLuu = new Button();
            btnBoQua = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(437, 21);
            label1.Name = "label1";
            label1.Size = new Size(178, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaNganh);
            groupBox1.Controls.Add(txtCVHT);
            groupBox1.Controls.Add(txtTenLop);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 440);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboMaNganh
            // 
            cboMaNganh.FormattingEnabled = true;
            cboMaNganh.Location = new Point(142, 125);
            cboMaNganh.Name = "cboMaNganh";
            cboMaNganh.Size = new Size(293, 28);
            cboMaNganh.TabIndex = 8;
            // 
            // txtCVHT
            // 
            txtCVHT.Location = new Point(142, 169);
            txtCVHT.Name = "txtCVHT";
            txtCVHT.Size = new Size(293, 27);
            txtCVHT.TabIndex = 7;
            txtCVHT.TextChanged += txtCVHT_TextChanged;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(142, 79);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(293, 27);
            txtTenLop.TabIndex = 5;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(142, 35);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(293, 27);
            txtMaLop.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 176);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 3;
            label5.Text = "Cố vấn học tập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 133);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã ngành:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 42);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã lớp:";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLop);
            groupBox2.Location = new Point(486, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 440);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvLop
            // 
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvLop.Location = new Point(11, 26);
            dgvLop.Name = "dgvLop";
            dgvLop.RowHeadersWidth = 51;
            dgvLop.RowTemplate.Height = 29;
            dgvLop.Size = new Size(563, 392);
            dgvLop.TabIndex = 0;
            dgvLop.CellClick += dgvLop_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaLop";
            Column1.HeaderText = "Mã lớp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenLop";
            Column2.HeaderText = "Tên lớp";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MaNganh";
            Column3.HeaderText = "Mã ngành";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "CoVanHT";
            Column4.HeaderText = "Cố vấn học tập";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 550);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(111, 46);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(180, 550);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 46);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(323, 550);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 46);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // button4
            // 
            button4.Location = new Point(957, 550);
            button4.Name = "button4";
            button4.Size = new Size(103, 46);
            button4.TabIndex = 6;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(465, 550);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 46);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(825, 550);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 46);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1088, 618);
            Controls.Add(btnBoQua);
            Controls.Add(btnLuu);
            Controls.Add(button4);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lớp";
            Load += frmLop_Load;
            Click += frmLop_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaLop;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCVHT;
        private TextBox txtTenLop;
        private GroupBox groupBox2;
        private DataGridView dgvLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnLuu;
        private Button btnBoQua;
        private ComboBox cboMaNganh;
    }
}