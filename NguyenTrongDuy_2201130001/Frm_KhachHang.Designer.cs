namespace PhucHien_MinhDuc
{
    partial class Frm_KhachHang
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.txt_TheCard = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_danhsachkh = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.cbo_LoaiKH = new System.Windows.Forms.ComboBox();
            this.dpk_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_Dkweb = new System.Windows.Forms.RadioButton();
            this.rad_GoiDien = new System.Windows.Forms.RadioButton();
            this.rad_TrucTiep = new System.Windows.Forms.RadioButton();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachkh)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.Gpb_ThongTin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(892, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thông Tin Khách Hàng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_nu);
            this.groupBox2.Controls.Add(this.rad_nam);
            this.groupBox2.Location = new System.Drawing.Point(130, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 31);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(77, 11);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(41, 19);
            this.rad_nu.TabIndex = 0;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // rad_nam
            // 
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(7, 11);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(49, 19);
            this.rad_nam.TabIndex = 0;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // txt_TheCard
            // 
            this.txt_TheCard.Location = new System.Drawing.Point(375, 18);
            this.txt_TheCard.Name = "txt_TheCard";
            this.txt_TheCard.Size = new System.Drawing.Size(124, 22);
            this.txt_TheCard.TabIndex = 1;
            this.txt_TheCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TheCard_KeyPress);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(130, 18);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(151, 22);
            this.txt_TenKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phái :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(505, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(287, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thẻ Card :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_danhsachkh
            // 
            this.dgv_danhsachkh.AllowUserToAddRows = false;
            this.dgv_danhsachkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.TheCard,
            this.NgaySinh,
            this.Phai,
            this.DienThoai,
            this.DiaChi,
            this.Email,
            this.HinhThucDK,
            this.MaLoaiKH});
            this.dgv_danhsachkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhsachkh.Location = new System.Drawing.Point(3, 18);
            this.dgv_danhsachkh.Name = "dgv_danhsachkh";
            this.dgv_danhsachkh.Size = new System.Drawing.Size(867, 203);
            this.dgv_danhsachkh.TabIndex = 0;
            this.dgv_danhsachkh.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachkh_CellEnter);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 70;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 130;
            // 
            // TheCard
            // 
            this.TheCard.DataPropertyName = "TheCard";
            this.TheCard.HeaderText = "Thẻ Card";
            this.TheCard.Name = "TheCard";
            this.TheCard.Visible = false;
            this.TheCard.Width = 90;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 90;
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "Phai";
            this.Phai.HeaderText = "Phái";
            this.Phai.Name = "Phai";
            this.Phai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Phai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Phai.Width = 50;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 210;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 90;
            // 
            // HinhThucDK
            // 
            this.HinhThucDK.DataPropertyName = "HinhThucDK";
            this.HinhThucDK.HeaderText = "Đăng Ký";
            this.HinhThucDK.Name = "HinhThucDK";
            this.HinhThucDK.Width = 80;
            // 
            // MaLoaiKH
            // 
            this.MaLoaiKH.DataPropertyName = "MaLoaiKH";
            this.MaLoaiKH.HeaderText = "Loại KH";
            this.MaLoaiKH.Name = "MaLoaiKH";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_danhsachkh);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(6, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(873, 224);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Khách Hàng";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gpb_ThongTin
            // 
            this.Gpb_ThongTin.Controls.Add(this.cbo_LoaiKH);
            this.Gpb_ThongTin.Controls.Add(this.dpk_NgaySinh);
            this.Gpb_ThongTin.Controls.Add(this.groupBox3);
            this.Gpb_ThongTin.Controls.Add(this.groupBox2);
            this.Gpb_ThongTin.Controls.Add(this.txt_TheCard);
            this.Gpb_ThongTin.Controls.Add(this.txt_DiaChi);
            this.Gpb_ThongTin.Controls.Add(this.txt_Email);
            this.Gpb_ThongTin.Controls.Add(this.txt_DienThoai);
            this.Gpb_ThongTin.Controls.Add(this.txt_TenKH);
            this.Gpb_ThongTin.Controls.Add(this.label5);
            this.Gpb_ThongTin.Controls.Add(this.label3);
            this.Gpb_ThongTin.Controls.Add(this.label2);
            this.Gpb_ThongTin.Controls.Add(this.label10);
            this.Gpb_ThongTin.Controls.Add(this.label9);
            this.Gpb_ThongTin.Controls.Add(this.label7);
            this.Gpb_ThongTin.Controls.Add(this.label8);
            this.Gpb_ThongTin.Controls.Add(this.label4);
            this.Gpb_ThongTin.Controls.Add(this.label1);
            this.Gpb_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.Gpb_ThongTin.Location = new System.Drawing.Point(12, 29);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.Gpb_ThongTin.Size = new System.Drawing.Size(738, 166);
            this.Gpb_ThongTin.TabIndex = 4;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông Tin";
            // 
            // cbo_LoaiKH
            // 
            this.cbo_LoaiKH.FormattingEnabled = true;
            this.cbo_LoaiKH.Location = new System.Drawing.Point(527, 124);
            this.cbo_LoaiKH.Name = "cbo_LoaiKH";
            this.cbo_LoaiKH.Size = new System.Drawing.Size(203, 23);
            this.cbo_LoaiKH.TabIndex = 4;
            // 
            // dpk_NgaySinh
            // 
            this.dpk_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_NgaySinh.Location = new System.Drawing.Point(593, 18);
            this.dpk_NgaySinh.Name = "dpk_NgaySinh";
            this.dpk_NgaySinh.Size = new System.Drawing.Size(135, 22);
            this.dpk_NgaySinh.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_Dkweb);
            this.groupBox3.Controls.Add(this.rad_GoiDien);
            this.groupBox3.Controls.Add(this.rad_TrucTiep);
            this.groupBox3.Location = new System.Drawing.Point(130, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 31);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rad_Dkweb
            // 
            this.rad_Dkweb.AutoSize = true;
            this.rad_Dkweb.Location = new System.Drawing.Point(161, 11);
            this.rad_Dkweb.Name = "rad_Dkweb";
            this.rad_Dkweb.Size = new System.Drawing.Size(90, 19);
            this.rad_Dkweb.TabIndex = 0;
            this.rad_Dkweb.TabStop = true;
            this.rad_Dkweb.Text = "ĐK Website";
            this.rad_Dkweb.UseVisualStyleBackColor = true;
            // 
            // rad_GoiDien
            // 
            this.rad_GoiDien.AutoSize = true;
            this.rad_GoiDien.Location = new System.Drawing.Point(87, 11);
            this.rad_GoiDien.Name = "rad_GoiDien";
            this.rad_GoiDien.Size = new System.Drawing.Size(63, 19);
            this.rad_GoiDien.TabIndex = 0;
            this.rad_GoiDien.TabStop = true;
            this.rad_GoiDien.Text = "Gọi ĐT";
            this.rad_GoiDien.UseVisualStyleBackColor = true;
            // 
            // rad_TrucTiep
            // 
            this.rad_TrucTiep.AutoSize = true;
            this.rad_TrucTiep.Location = new System.Drawing.Point(7, 11);
            this.rad_TrucTiep.Name = "rad_TrucTiep";
            this.rad_TrucTiep.Size = new System.Drawing.Size(77, 19);
            this.rad_TrucTiep.TabIndex = 0;
            this.rad_TrucTiep.TabStop = true;
            this.rad_TrucTiep.Text = "Trực Tiếp";
            this.rad_TrucTiep.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(130, 91);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(600, 22);
            this.txt_DiaChi.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(593, 51);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(135, 22);
            this.txt_Email.TabIndex = 1;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(375, 51);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(124, 22);
            this.txt_DienThoai.TabIndex = 1;
            this.txt_DienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DienThoai_KeyPress);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(397, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại Khách Hàng :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hình Thức ĐK :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(505, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(287, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện Thoại :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Thoat);
            this.groupBox5.Controls.Add(this.btn_Luu);
            this.groupBox5.Controls.Add(this.btn_Sua);
            this.groupBox5.Controls.Add(this.btn_Xoa);
            this.groupBox5.Controls.Add(this.btn_Them);
            this.groupBox5.Location = new System.Drawing.Point(756, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(129, 166);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(6, 135);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(117, 25);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(6, 107);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(117, 25);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(6, 78);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(117, 25);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(6, 48);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 25);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(6, 19);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 25);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(892, 436);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Gpb_ThongTin);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachkh)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.Gpb_ThongTin.ResumeLayout(false);
            this.Gpb_ThongTin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.TextBox txt_TheCard;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_danhsachkh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private System.Windows.Forms.ComboBox cbo_LoaiKH;
        private System.Windows.Forms.DateTimePicker dpk_NgaySinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_GoiDien;
        private System.Windows.Forms.RadioButton rad_TrucTiep;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rad_Dkweb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucDK;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiKH;
    }
}