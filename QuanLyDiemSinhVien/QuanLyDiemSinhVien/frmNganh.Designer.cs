namespace QuanLyDiemSinhVien
{
    partial class frmNganh
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
            txtTenNganh = new TextBox();
            txtMaNganh = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvNganh = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnBoQua = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNganh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(450, 22);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NGÀNH";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenNganh);
            groupBox1.Controls.Add(txtMaNganh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtTenNganh
            // 
            txtTenNganh.Location = new Point(136, 77);
            txtTenNganh.Name = "txtTenNganh";
            txtTenNganh.Size = new Size(333, 27);
            txtTenNganh.TabIndex = 3;
            // 
            // txtMaNganh
            // 
            txtMaNganh.Location = new Point(136, 34);
            txtMaNganh.Name = "txtMaNganh";
            txtMaNganh.Size = new Size(333, 27);
            txtMaNganh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 41);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã ngành:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên ngành:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNganh);
            groupBox2.Location = new Point(504, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 378);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgvNganh
            // 
            dgvNganh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNganh.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvNganh.Location = new Point(20, 26);
            dgvNganh.Name = "dgvNganh";
            dgvNganh.RowHeadersWidth = 51;
            dgvNganh.RowTemplate.Height = 29;
            dgvNganh.Size = new Size(551, 337);
            dgvNganh.TabIndex = 0;
            dgvNganh.CellClick += dgvNganh_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaNganh";
            Column1.HeaderText = "Mã ngành";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenNganh";
            Column2.HeaderText = "Tên ngành";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 477);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(166, 477);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(108, 44);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(314, 477);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 44);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(981, 477);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 44);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(463, 477);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 44);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(858, 477);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 44);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmNganh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1093, 544);
            Controls.Add(btnBoQua);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNganh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ngành";
            Load += frmNganh_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenNganh;
        private TextBox txtMaNganh;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvNganh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnLuu;
        private Button btnBoQua;
    }
}