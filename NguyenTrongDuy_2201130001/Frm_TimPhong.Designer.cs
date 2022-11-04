namespace NguyenTrongDuy_2201130001
{
    partial class Frm_TimPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TimPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_NoiDungTim = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.rad_SucChua = new System.Windows.Forms.RadioButton();
            this.rad_LoaiPhong = new System.Windows.Forms.RadioButton();
            this.rad_NgayGio = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachTimKiem = new System.Windows.Forms.DataGridView();
            this.TenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.img_ListHinh = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_PhongDaDat = new System.Windows.Forms.RadioButton();
            this.rad_PhongCoKhach = new System.Windows.Forms.RadioButton();
            this.rad_PhongTrong = new System.Windows.Forms.RadioButton();
            this.gpb_NoiDungTim.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tìm Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpb_NoiDungTim
            // 
            this.gpb_NoiDungTim.Controls.Add(this.txt_TimKiem);
            this.gpb_NoiDungTim.Controls.Add(this.rad_SucChua);
            this.gpb_NoiDungTim.Controls.Add(this.rad_LoaiPhong);
            this.gpb_NoiDungTim.Controls.Add(this.rad_NgayGio);
            this.gpb_NoiDungTim.Location = new System.Drawing.Point(203, 50);
            this.gpb_NoiDungTim.Name = "gpb_NoiDungTim";
            this.gpb_NoiDungTim.Size = new System.Drawing.Size(276, 108);
            this.gpb_NoiDungTim.TabIndex = 1;
            this.gpb_NoiDungTim.TabStop = false;
            this.gpb_NoiDungTim.Text = "Chọn Nội Dùng Tìm Phòng";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(7, 61);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(258, 23);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.Text = "Gõ từ khóa cần tìm";
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // rad_SucChua
            // 
            this.rad_SucChua.AutoSize = true;
            this.rad_SucChua.Location = new System.Drawing.Point(183, 23);
            this.rad_SucChua.Name = "rad_SucChua";
            this.rad_SucChua.Size = new System.Drawing.Size(82, 20);
            this.rad_SucChua.TabIndex = 0;
            this.rad_SucChua.TabStop = true;
            this.rad_SucChua.Text = "Sức Chứa";
            this.rad_SucChua.UseVisualStyleBackColor = true;
            // 
            // rad_LoaiPhong
            // 
            this.rad_LoaiPhong.AutoSize = true;
            this.rad_LoaiPhong.Location = new System.Drawing.Point(89, 23);
            this.rad_LoaiPhong.Name = "rad_LoaiPhong";
            this.rad_LoaiPhong.Size = new System.Drawing.Size(88, 20);
            this.rad_LoaiPhong.TabIndex = 0;
            this.rad_LoaiPhong.TabStop = true;
            this.rad_LoaiPhong.Text = "Loại Phòng";
            this.rad_LoaiPhong.UseVisualStyleBackColor = true;
            // 
            // rad_NgayGio
            // 
            this.rad_NgayGio.AutoSize = true;
            this.rad_NgayGio.Location = new System.Drawing.Point(7, 23);
            this.rad_NgayGio.Name = "rad_NgayGio";
            this.rad_NgayGio.Size = new System.Drawing.Size(76, 20);
            this.rad_NgayGio.TabIndex = 0;
            this.rad_NgayGio.TabStop = true;
            this.rad_NgayGio.Text = "Ngày Giờ";
            this.rad_NgayGio.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_DanhSachTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(13, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 182);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Thông Tin Phòng";
            // 
            // dgv_DanhSachTimKiem
            // 
            this.dgv_DanhSachTimKiem.AllowUserToAddRows = false;
            this.dgv_DanhSachTimKiem.AllowUserToDeleteRows = false;
            this.dgv_DanhSachTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPH,
            this.NgayGioVao,
            this.NgayGioRa,
            this.SucChua,
            this.TrangThai,
            this.MaLoai});
            this.dgv_DanhSachTimKiem.Location = new System.Drawing.Point(7, 23);
            this.dgv_DanhSachTimKiem.Name = "dgv_DanhSachTimKiem";
            this.dgv_DanhSachTimKiem.ReadOnly = true;
            this.dgv_DanhSachTimKiem.Size = new System.Drawing.Size(620, 150);
            this.dgv_DanhSachTimKiem.TabIndex = 0;
            // 
            // TenPH
            // 
            this.TenPH.DataPropertyName = "TenPH";
            this.TenPH.HeaderText = "Tên PH";
            this.TenPH.Name = "TenPH";
            this.TenPH.ReadOnly = true;
            this.TenPH.Width = 90;
            // 
            // NgayGioVao
            // 
            this.NgayGioVao.DataPropertyName = "NgayVao";
            this.NgayGioVao.HeaderText = "Ngày Vào";
            this.NgayGioVao.Name = "NgayGioVao";
            this.NgayGioVao.ReadOnly = true;
            this.NgayGioVao.Width = 90;
            // 
            // NgayGioRa
            // 
            this.NgayGioRa.DataPropertyName = "NgayDi";
            this.NgayGioRa.HeaderText = "Giờ Ra";
            this.NgayGioRa.Name = "NgayGioRa";
            this.NgayGioRa.ReadOnly = true;
            this.NgayGioRa.Width = 90;
            // 
            // SucChua
            // 
            this.SucChua.DataPropertyName = "SucChua";
            this.SucChua.HeaderText = "Sức Chứa";
            this.SucChua.Name = "SucChua";
            this.SucChua.ReadOnly = true;
            this.SucChua.Width = 90;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThaiHinh";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Loại Phòng";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 120;
            // 
            // img_ListHinh
            // 
            this.img_ListHinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_ListHinh.ImageStream")));
            this.img_ListHinh.TransparentColor = System.Drawing.Color.Transparent;
            this.img_ListHinh.Images.SetKeyName(0, "phongtrong.jpg");
            this.img_ListHinh.Images.SetKeyName(1, "phongcokhach.jpg");
            this.img_ListHinh.Images.SetKeyName(2, "phongdat.jpg");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_PhongDaDat);
            this.groupBox1.Controls.Add(this.rad_PhongCoKhach);
            this.groupBox1.Controls.Add(this.rad_PhongTrong);
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Trạng Thái Tìm";
            // 
            // rad_PhongDaDat
            // 
            this.rad_PhongDaDat.AutoSize = true;
            this.rad_PhongDaDat.Location = new System.Drawing.Point(7, 74);
            this.rad_PhongDaDat.Name = "rad_PhongDaDat";
            this.rad_PhongDaDat.Size = new System.Drawing.Size(105, 20);
            this.rad_PhongDaDat.TabIndex = 2;
            this.rad_PhongDaDat.TabStop = true;
            this.rad_PhongDaDat.Text = "Phòng Đã Đặt";
            this.rad_PhongDaDat.UseVisualStyleBackColor = true;
            this.rad_PhongDaDat.CheckedChanged += new System.EventHandler(this.rad_PhongDaDat_CheckedChanged);
            // 
            // rad_PhongCoKhach
            // 
            this.rad_PhongCoKhach.AutoSize = true;
            this.rad_PhongCoKhach.Location = new System.Drawing.Point(7, 48);
            this.rad_PhongCoKhach.Name = "rad_PhongCoKhach";
            this.rad_PhongCoKhach.Size = new System.Drawing.Size(118, 20);
            this.rad_PhongCoKhach.TabIndex = 1;
            this.rad_PhongCoKhach.TabStop = true;
            this.rad_PhongCoKhach.Text = "Phòng Có Khách";
            this.rad_PhongCoKhach.UseVisualStyleBackColor = true;
            this.rad_PhongCoKhach.CheckedChanged += new System.EventHandler(this.rad_PhongCoKhach_CheckedChanged);
            // 
            // rad_PhongTrong
            // 
            this.rad_PhongTrong.AutoSize = true;
            this.rad_PhongTrong.Location = new System.Drawing.Point(7, 22);
            this.rad_PhongTrong.Name = "rad_PhongTrong";
            this.rad_PhongTrong.Size = new System.Drawing.Size(99, 20);
            this.rad_PhongTrong.TabIndex = 0;
            this.rad_PhongTrong.TabStop = true;
            this.rad_PhongTrong.Text = "Phòng Trống";
            this.rad_PhongTrong.UseVisualStyleBackColor = true;
            this.rad_PhongTrong.CheckedChanged += new System.EventHandler(this.rad_PhongTrong_CheckedChanged);
            // 
            // Frm_TimPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(657, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_NoiDungTim);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_TimPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Phòng";
            this.Load += new System.EventHandler(this.Frm_TimPhong_Load);
            this.gpb_NoiDungTim.ResumeLayout(false);
            this.gpb_NoiDungTim.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_NoiDungTim;
        private System.Windows.Forms.RadioButton rad_SucChua;
        private System.Windows.Forms.RadioButton rad_LoaiPhong;
        private System.Windows.Forms.RadioButton rad_NgayGio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachTimKiem;
        private System.Windows.Forms.ImageList img_ListHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_PhongTrong;
        private System.Windows.Forms.RadioButton rad_PhongDaDat;
        private System.Windows.Forms.RadioButton rad_PhongCoKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
        private System.Windows.Forms.DataGridViewImageColumn TrangThai;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoai;
    }
}