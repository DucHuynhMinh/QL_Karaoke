namespace NguyenTrongDuy_2201130001
{
    partial class Frm_DatPhong
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
            this.grp_Online = new System.Windows.Forms.GroupBox();
            this.dpk_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TienDatCoc = new System.Windows.Forms.TextBox();
            this.ckb_TienDacCoc = new System.Windows.Forms.CheckBox();
            this.cbo_Buoidat = new System.Windows.Forms.ComboBox();
            this.txt_giodat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_ThongTinKH = new System.Windows.Forms.GroupBox();
            this.cbo_LoaiKH = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.dpk_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_DanhSach = new System.Windows.Forms.GroupBox();
            this.trv_DanhSachPhong = new System.Windows.Forms.TreeView();
            this.grp_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_LuuPD = new System.Windows.Forms.Button();
            this.btn_huyphong = new System.Windows.Forms.Button();
            this.btn_datphong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_PhieuDatPhong = new System.Windows.Forms.DataGridView();
            this.SoPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPHPD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grp_Online.SuspendLayout();
            this.grp_ThongTinKH.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grp_DanhSach.SuspendLayout();
            this.grp_ChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Online
            // 
            this.grp_Online.Controls.Add(this.dpk_ngaydat);
            this.grp_Online.Controls.Add(this.label3);
            this.grp_Online.Controls.Add(this.txt_TienDatCoc);
            this.grp_Online.Controls.Add(this.ckb_TienDacCoc);
            this.grp_Online.Controls.Add(this.cbo_Buoidat);
            this.grp_Online.Controls.Add(this.txt_giodat);
            this.grp_Online.Controls.Add(this.label12);
            this.grp_Online.Controls.Add(this.label8);
            this.grp_Online.Controls.Add(this.label4);
            this.grp_Online.Location = new System.Drawing.Point(231, 36);
            this.grp_Online.Name = "grp_Online";
            this.grp_Online.Size = new System.Drawing.Size(297, 220);
            this.grp_Online.TabIndex = 3;
            this.grp_Online.TabStop = false;
            this.grp_Online.Text = "Đặt Phòng Online";
            // 
            // dpk_ngaydat
            // 
            this.dpk_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_ngaydat.Location = new System.Drawing.Point(129, 31);
            this.dpk_ngaydat.Name = "dpk_ngaydat";
            this.dpk_ngaydat.Size = new System.Drawing.Size(160, 22);
            this.dpk_ngaydat.TabIndex = 11;
            this.dpk_ngaydat.ValueChanged += new System.EventHandler(this.dpk_ngaydat_ValueChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Đặt :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TienDatCoc
            // 
            this.txt_TienDatCoc.Location = new System.Drawing.Point(179, 137);
            this.txt_TienDatCoc.Name = "txt_TienDatCoc";
            this.txt_TienDatCoc.Size = new System.Drawing.Size(110, 22);
            this.txt_TienDatCoc.TabIndex = 6;
            this.txt_TienDatCoc.Text = "0";
            this.txt_TienDatCoc.Click += new System.EventHandler(this.txt_TienDatCoc_Click);
            this.txt_TienDatCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienDatCoc_KeyPress);
            // 
            // ckb_TienDacCoc
            // 
            this.ckb_TienDacCoc.AutoSize = true;
            this.ckb_TienDacCoc.Location = new System.Drawing.Point(129, 137);
            this.ckb_TienDacCoc.Name = "ckb_TienDacCoc";
            this.ckb_TienDacCoc.Size = new System.Drawing.Size(41, 19);
            this.ckb_TienDacCoc.TabIndex = 5;
            this.ckb_TienDacCoc.Text = "Có";
            this.ckb_TienDacCoc.UseVisualStyleBackColor = true;
            this.ckb_TienDacCoc.CheckedChanged += new System.EventHandler(this.ckb_TienDacCoc_CheckedChanged);
            // 
            // cbo_Buoidat
            // 
            this.cbo_Buoidat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Buoidat.FormattingEnabled = true;
            this.cbo_Buoidat.Location = new System.Drawing.Point(129, 101);
            this.cbo_Buoidat.Name = "cbo_Buoidat";
            this.cbo_Buoidat.Size = new System.Drawing.Size(160, 23);
            this.cbo_Buoidat.TabIndex = 4;
            // 
            // txt_giodat
            // 
            this.txt_giodat.Location = new System.Drawing.Point(129, 66);
            this.txt_giodat.MaxLength = 5;
            this.txt_giodat.Name = "txt_giodat";
            this.txt_giodat.Size = new System.Drawing.Size(160, 22);
            this.txt_giodat.TabIndex = 1;
            this.txt_giodat.TextChanged += new System.EventHandler(this.txt_giodat_TextChanged);
            this.txt_giodat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giodat_KeyPress);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(6, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tiền Đặt Cọc :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buổi Đặt :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giờ Đặt :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Đặt Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_ThongTinKH
            // 
            this.grp_ThongTinKH.Controls.Add(this.cbo_LoaiKH);
            this.grp_ThongTinKH.Controls.Add(this.groupBox4);
            this.grp_ThongTinKH.Controls.Add(this.dpk_Ngaysinh);
            this.grp_ThongTinKH.Controls.Add(this.txt_dienthoai);
            this.grp_ThongTinKH.Controls.Add(this.txt_TenKH);
            this.grp_ThongTinKH.Controls.Add(this.label2);
            this.grp_ThongTinKH.Controls.Add(this.label5);
            this.grp_ThongTinKH.Controls.Add(this.label6);
            this.grp_ThongTinKH.Controls.Add(this.label7);
            this.grp_ThongTinKH.Controls.Add(this.label9);
            this.grp_ThongTinKH.Location = new System.Drawing.Point(533, 36);
            this.grp_ThongTinKH.Name = "grp_ThongTinKH";
            this.grp_ThongTinKH.Size = new System.Drawing.Size(297, 194);
            this.grp_ThongTinKH.TabIndex = 3;
            this.grp_ThongTinKH.TabStop = false;
            this.grp_ThongTinKH.Text = "Thông Tin Khách Hàng";
            // 
            // cbo_LoaiKH
            // 
            this.cbo_LoaiKH.FormattingEnabled = true;
            this.cbo_LoaiKH.Location = new System.Drawing.Point(129, 155);
            this.cbo_LoaiKH.Name = "cbo_LoaiKH";
            this.cbo_LoaiKH.Size = new System.Drawing.Size(162, 23);
            this.cbo_LoaiKH.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rad_nu);
            this.groupBox4.Controls.Add(this.rad_nam);
            this.groupBox4.Location = new System.Drawing.Point(129, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 43);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(72, 16);
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
            this.rad_nam.Location = new System.Drawing.Point(7, 16);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(49, 19);
            this.rad_nam.TabIndex = 0;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // dpk_Ngaysinh
            // 
            this.dpk_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_Ngaysinh.Location = new System.Drawing.Point(129, 53);
            this.dpk_Ngaysinh.Name = "dpk_Ngaysinh";
            this.dpk_Ngaysinh.Size = new System.Drawing.Size(163, 22);
            this.dpk_Ngaysinh.TabIndex = 3;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(129, 128);
            this.txt_dienthoai.MaxLength = 11;
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(163, 22);
            this.txt_dienthoai.TabIndex = 1;
            this.txt_dienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dienthoai_KeyPress);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(129, 26);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(163, 22);
            this.txt_TenKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điện Thoại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Sinh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Khách Hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_DanhSach
            // 
            this.grp_DanhSach.Controls.Add(this.trv_DanhSachPhong);
            this.grp_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DanhSach.Location = new System.Drawing.Point(5, 36);
            this.grp_DanhSach.Name = "grp_DanhSach";
            this.grp_DanhSach.Size = new System.Drawing.Size(219, 405);
            this.grp_DanhSach.TabIndex = 5;
            this.grp_DanhSach.TabStop = false;
            this.grp_DanhSach.Text = "Danh Sách Phòng";
            // 
            // trv_DanhSachPhong
            // 
            this.trv_DanhSachPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_DanhSachPhong.Location = new System.Drawing.Point(3, 18);
            this.trv_DanhSachPhong.Name = "trv_DanhSachPhong";
            this.trv_DanhSachPhong.Size = new System.Drawing.Size(213, 384);
            this.trv_DanhSachPhong.TabIndex = 0;
            this.trv_DanhSachPhong.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trv_DanhSachPhong_BeforeSelect);
            this.trv_DanhSachPhong.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_DanhSachPhong_AfterSelect);
            // 
            // grp_ChucNang
            // 
            this.grp_ChucNang.Controls.Add(this.btn_thoat);
            this.grp_ChucNang.Controls.Add(this.btn_LuuPD);
            this.grp_ChucNang.Controls.Add(this.btn_huyphong);
            this.grp_ChucNang.Controls.Add(this.btn_datphong);
            this.grp_ChucNang.Location = new System.Drawing.Point(836, 30);
            this.grp_ChucNang.Name = "grp_ChucNang";
            this.grp_ChucNang.Size = new System.Drawing.Size(127, 184);
            this.grp_ChucNang.TabIndex = 6;
            this.grp_ChucNang.TabStop = false;
            this.grp_ChucNang.Text = "Chức Năng";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(6, 145);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(109, 23);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_LuuPD
            // 
            this.btn_LuuPD.Location = new System.Drawing.Point(6, 100);
            this.btn_LuuPD.Name = "btn_LuuPD";
            this.btn_LuuPD.Size = new System.Drawing.Size(109, 23);
            this.btn_LuuPD.TabIndex = 0;
            this.btn_LuuPD.Text = "&Lưu PD";
            this.btn_LuuPD.UseVisualStyleBackColor = true;
            this.btn_LuuPD.Click += new System.EventHandler(this.btn_LuuPD_Click);
            // 
            // btn_huyphong
            // 
            this.btn_huyphong.Location = new System.Drawing.Point(6, 61);
            this.btn_huyphong.Name = "btn_huyphong";
            this.btn_huyphong.Size = new System.Drawing.Size(109, 23);
            this.btn_huyphong.TabIndex = 0;
            this.btn_huyphong.Text = "&Hủy Phòng";
            this.btn_huyphong.UseVisualStyleBackColor = true;
            this.btn_huyphong.Click += new System.EventHandler(this.btn_huyphong_Click);
            // 
            // btn_datphong
            // 
            this.btn_datphong.Location = new System.Drawing.Point(6, 21);
            this.btn_datphong.Name = "btn_datphong";
            this.btn_datphong.Size = new System.Drawing.Size(109, 23);
            this.btn_datphong.TabIndex = 0;
            this.btn_datphong.Text = "&Đặt Phòng";
            this.btn_datphong.UseVisualStyleBackColor = true;
            this.btn_datphong.Click += new System.EventHandler(this.btn_datphong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_PhieuDatPhong);
            this.groupBox1.Location = new System.Drawing.Point(231, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Đặt";
            // 
            // dgv_PhieuDatPhong
            // 
            this.dgv_PhieuDatPhong.AllowUserToAddRows = false;
            this.dgv_PhieuDatPhong.AllowUserToDeleteRows = false;
            this.dgv_PhieuDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPD,
            this.NgayDat,
            this.GioDat,
            this.BuoiDat,
            this.TienDatCoc,
            this.MaPHPD,
            this.MaKH});
            this.dgv_PhieuDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PhieuDatPhong.Location = new System.Drawing.Point(3, 18);
            this.dgv_PhieuDatPhong.Name = "dgv_PhieuDatPhong";
            this.dgv_PhieuDatPhong.ReadOnly = true;
            this.dgv_PhieuDatPhong.Size = new System.Drawing.Size(727, 160);
            this.dgv_PhieuDatPhong.TabIndex = 0;
            this.dgv_PhieuDatPhong.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuDatPhong_CellEnter);
            // 
            // SoPD
            // 
            this.SoPD.DataPropertyName = "SoPD";
            this.SoPD.HeaderText = "Số PD";
            this.SoPD.Name = "SoPD";
            this.SoPD.ReadOnly = true;
            this.SoPD.Width = 70;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày Đặt";
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            this.NgayDat.Width = 90;
            // 
            // GioDat
            // 
            this.GioDat.DataPropertyName = "GioDat";
            this.GioDat.HeaderText = "Giờ Đặt";
            this.GioDat.Name = "GioDat";
            this.GioDat.ReadOnly = true;
            this.GioDat.Width = 90;
            // 
            // BuoiDat
            // 
            this.BuoiDat.DataPropertyName = "BuoiDat";
            this.BuoiDat.HeaderText = "Buổi Đặt";
            this.BuoiDat.Name = "BuoiDat";
            this.BuoiDat.ReadOnly = true;
            this.BuoiDat.Width = 90;
            // 
            // TienDatCoc
            // 
            this.TienDatCoc.DataPropertyName = "TienDatCoc";
            this.TienDatCoc.HeaderText = "Tiền ĐC";
            this.TienDatCoc.Name = "TienDatCoc";
            this.TienDatCoc.ReadOnly = true;
            this.TienDatCoc.Width = 80;
            // 
            // MaPHPD
            // 
            this.MaPHPD.DataPropertyName = "MaPH";
            this.MaPHPD.HeaderText = "Tên Phòng";
            this.MaPHPD.Name = "MaPHPD";
            this.MaPHPD.ReadOnly = true;
            this.MaPHPD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaPHPD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaPHPD.Width = 110;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Tên KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaKH.Visible = false;
            this.MaKH.Width = 140;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(646, 236);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(312, 27);
            this.txt_diachi.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(539, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "Địa Chỉ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(975, 455);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_ChucNang);
            this.Controls.Add(this.grp_DanhSach);
            this.Controls.Add(this.grp_ThongTinKH);
            this.Controls.Add(this.grp_Online);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đặt Phòng";
            this.Load += new System.EventHandler(this.Frm_DatPhong_Load);
            this.grp_Online.ResumeLayout(false);
            this.grp_Online.PerformLayout();
            this.grp_ThongTinKH.ResumeLayout(false);
            this.grp_ThongTinKH.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grp_DanhSach.ResumeLayout(false);
            this.grp_ChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuDatPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Online;
        private System.Windows.Forms.ComboBox cbo_Buoidat;
        private System.Windows.Forms.TextBox txt_giodat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_ThongTinKH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.DateTimePicker dpk_Ngaysinh;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grp_DanhSach;
        private System.Windows.Forms.GroupBox grp_ChucNang;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_LuuPD;
        private System.Windows.Forms.Button btn_huyphong;
        private System.Windows.Forms.Button btn_datphong;
        private System.Windows.Forms.TextBox txt_TienDatCoc;
        private System.Windows.Forms.CheckBox ckb_TienDacCoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TreeView trv_DanhSachPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_PhieuDatPhong;
        private System.Windows.Forms.ComboBox cbo_LoaiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDatCoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaPHPD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DateTimePicker dpk_ngaydat;
        private System.Windows.Forms.Label label3;
    }
}