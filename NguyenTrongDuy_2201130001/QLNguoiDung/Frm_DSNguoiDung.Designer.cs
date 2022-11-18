namespace PhucHien_MinhDuc.QLNguoiDung
{
    partial class Frm_DSNguoiDung
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
            this.label6 = new System.Windows.Forms.Label();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.dpk_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_NhanVienPV = new System.Windows.Forms.RadioButton();
            this.rad_NhanVienTN = new System.Windows.Forms.RadioButton();
            this.rad_Admin = new System.Windows.Forms.RadioButton();
            this.txt_HoTenNV = new System.Windows.Forms.TextBox();
            this.txt_MatMaDN = new System.Windows.Forms.TextBox();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatMaDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.Gpb_ThongTin.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(663, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Danh Sách Người Dùng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gpb_ThongTin
            // 
            this.Gpb_ThongTin.Controls.Add(this.dpk_NgaySinh);
            this.Gpb_ThongTin.Controls.Add(this.label7);
            this.Gpb_ThongTin.Controls.Add(this.groupBox5);
            this.Gpb_ThongTin.Controls.Add(this.label3);
            this.Gpb_ThongTin.Controls.Add(this.groupBox2);
            this.Gpb_ThongTin.Controls.Add(this.txt_HoTenNV);
            this.Gpb_ThongTin.Controls.Add(this.txt_MatMaDN);
            this.Gpb_ThongTin.Controls.Add(this.txt_TenDN);
            this.Gpb_ThongTin.Controls.Add(this.label5);
            this.Gpb_ThongTin.Controls.Add(this.label4);
            this.Gpb_ThongTin.Controls.Add(this.label2);
            this.Gpb_ThongTin.Controls.Add(this.label1);
            this.Gpb_ThongTin.Location = new System.Drawing.Point(12, 33);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.Gpb_ThongTin.Size = new System.Drawing.Size(486, 170);
            this.Gpb_ThongTin.TabIndex = 10;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông Tin";
            // 
            // dpk_NgaySinh
            // 
            this.dpk_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_NgaySinh.Location = new System.Drawing.Point(155, 134);
            this.dpk_NgaySinh.Name = "dpk_NgaySinh";
            this.dpk_NgaySinh.Size = new System.Drawing.Size(113, 20);
            this.dpk_NgaySinh.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(8, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày Sinh :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rad_Nu);
            this.groupBox5.Controls.Add(this.rad_Nam);
            this.groupBox5.Location = new System.Drawing.Point(342, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(137, 34);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(65, 11);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(39, 17);
            this.rad_Nu.TabIndex = 0;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(8, 11);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(47, 17);
            this.rad_Nam.TabIndex = 0;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(342, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phái :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_NhanVienPV);
            this.groupBox2.Controls.Add(this.rad_NhanVienTN);
            this.groupBox2.Controls.Add(this.rad_Admin);
            this.groupBox2.Location = new System.Drawing.Point(155, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 36);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // rad_NhanVienPV
            // 
            this.rad_NhanVienPV.AutoSize = true;
            this.rad_NhanVienPV.Location = new System.Drawing.Point(203, 11);
            this.rad_NhanVienPV.Name = "rad_NhanVienPV";
            this.rad_NhanVienPV.Size = new System.Drawing.Size(119, 17);
            this.rad_NhanVienPV.TabIndex = 0;
            this.rad_NhanVienPV.TabStop = true;
            this.rad_NhanVienPV.Text = "Nhân Viên Phục Vụ";
            this.rad_NhanVienPV.UseVisualStyleBackColor = true;
            // 
            // rad_NhanVienTN
            // 
            this.rad_NhanVienTN.AutoSize = true;
            this.rad_NhanVienTN.Location = new System.Drawing.Point(71, 11);
            this.rad_NhanVienTN.Name = "rad_NhanVienTN";
            this.rad_NhanVienTN.Size = new System.Drawing.Size(126, 17);
            this.rad_NhanVienTN.TabIndex = 0;
            this.rad_NhanVienTN.TabStop = true;
            this.rad_NhanVienTN.Text = "Nhân Viên Thu Ngân";
            this.rad_NhanVienTN.UseVisualStyleBackColor = true;
            // 
            // rad_Admin
            // 
            this.rad_Admin.AutoSize = true;
            this.rad_Admin.Location = new System.Drawing.Point(11, 11);
            this.rad_Admin.Name = "rad_Admin";
            this.rad_Admin.Size = new System.Drawing.Size(54, 17);
            this.rad_Admin.TabIndex = 0;
            this.rad_Admin.TabStop = true;
            this.rad_Admin.Text = "Admin";
            this.rad_Admin.UseVisualStyleBackColor = true;
            // 
            // txt_HoTenNV
            // 
            this.txt_HoTenNV.Location = new System.Drawing.Point(155, 69);
            this.txt_HoTenNV.Name = "txt_HoTenNV";
            this.txt_HoTenNV.Size = new System.Drawing.Size(175, 20);
            this.txt_HoTenNV.TabIndex = 1;
            // 
            // txt_MatMaDN
            // 
            this.txt_MatMaDN.Location = new System.Drawing.Point(155, 45);
            this.txt_MatMaDN.Name = "txt_MatMaDN";
            this.txt_MatMaDN.Size = new System.Drawing.Size(175, 20);
            this.txt_MatMaDN.TabIndex = 1;
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(155, 21);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(175, 20);
            this.txt_TenDN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(8, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quyền DN :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Nhân Viên :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Mã Đăng Nhập :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSachNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 244);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Người Dùng";
            // 
            // dgv_DanhSachNV
            // 
            this.dgv_DanhSachNV.AllowUserToAddRows = false;
            this.dgv_DanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenDN,
            this.MatMaDN,
            this.QuyenDN,
            this.HoTenNV,
            this.NgaySinh,
            this.Phai,
            this.DienThoai,
            this.DiaChi,
            this.LuongNV});
            this.dgv_DanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachNV.Location = new System.Drawing.Point(3, 16);
            this.dgv_DanhSachNV.Name = "dgv_DanhSachNV";
            this.dgv_DanhSachNV.Size = new System.Drawing.Size(632, 225);
            this.dgv_DanhSachNV.TabIndex = 1;
            this.dgv_DanhSachNV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNV_CellEnter);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 70;
            // 
            // TenDN
            // 
            this.TenDN.DataPropertyName = "TenDN";
            this.TenDN.HeaderText = "Tên DN";
            this.TenDN.Name = "TenDN";
            this.TenDN.Width = 110;
            // 
            // MatMaDN
            // 
            this.MatMaDN.DataPropertyName = "MatMaDN";
            this.MatMaDN.HeaderText = "Mật Mã DN";
            this.MatMaDN.Name = "MatMaDN";
            // 
            // QuyenDN
            // 
            this.QuyenDN.DataPropertyName = "QuyenDN";
            this.QuyenDN.HeaderText = "Quyền DN";
            this.QuyenDN.Name = "QuyenDN";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ Tên NV";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = false;
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "Phai";
            this.Phai.HeaderText = "Phái";
            this.Phai.Name = "Phai";
            this.Phai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Phai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Phai.Width = 60;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = false;
            this.DienThoai.Width = 120;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = false;
            // 
            // LuongNV
            // 
            this.LuongNV.DataPropertyName = "LuongNV";
            this.LuongNV.HeaderText = "Lương";
            this.LuongNV.Name = "LuongNV";
            this.LuongNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LuongNV.Visible = false;
            this.LuongNV.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Luu);
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.btn_Thoai);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(504, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 170);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(16, 104);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(113, 23);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(16, 75);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoai
            // 
            this.btn_Thoai.Location = new System.Drawing.Point(16, 133);
            this.btn_Thoai.Name = "btn_Thoai";
            this.btn_Thoai.Size = new System.Drawing.Size(113, 23);
            this.btn_Thoai.TabIndex = 0;
            this.btn_Thoai.Text = "&Thoát";
            this.btn_Thoai.UseVisualStyleBackColor = true;
            this.btn_Thoai.Click += new System.EventHandler(this.btn_Thoai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(16, 46);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(16, 17);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(113, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Frm_DSNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gpb_ThongTin);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DSNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.Frm_DSNguoiDung_Load);
            this.Gpb_ThongTin.ResumeLayout(false);
            this.Gpb_ThongTin.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_NhanVienPV;
        private System.Windows.Forms.RadioButton rad_NhanVienTN;
        private System.Windows.Forms.RadioButton rad_Admin;
        private System.Windows.Forms.TextBox txt_HoTenNV;
        private System.Windows.Forms.TextBox txt_MatMaDN;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_DanhSachNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatMaDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongNV;
        private System.Windows.Forms.DateTimePicker dpk_NgaySinh;
        private System.Windows.Forms.Label label7;

    }
}