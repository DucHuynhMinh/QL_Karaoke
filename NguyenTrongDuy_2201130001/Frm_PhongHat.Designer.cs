namespace PhucHien_MinhDuc
{
    partial class Frm_PhongHat
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
            this.label1 = new System.Windows.Forms.Label();
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_KhongHD = new System.Windows.Forms.RadioButton();
            this.rad_DangSuaChu = new System.Windows.Forms.RadioButton();
            this.rad_DangHD = new System.Windows.Forms.RadioButton();
            this.cbo_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_DSPhong = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioSau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ThongTin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DSPhong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Phòng Hát";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.Controls.Add(this.groupBox3);
            this.grp_ThongTin.Controls.Add(this.cbo_LoaiPhong);
            this.grp_ThongTin.Controls.Add(this.txt_TenPhong);
            this.grp_ThongTin.Controls.Add(this.label7);
            this.grp_ThongTin.Controls.Add(this.label6);
            this.grp_ThongTin.Controls.Add(this.label2);
            this.grp_ThongTin.Location = new System.Drawing.Point(13, 30);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(548, 103);
            this.grp_ThongTin.TabIndex = 1;
            this.grp_ThongTin.TabStop = false;
            this.grp_ThongTin.Text = "Thông Tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_KhongHD);
            this.groupBox3.Controls.Add(this.rad_DangSuaChu);
            this.groupBox3.Controls.Add(this.rad_DangHD);
            this.groupBox3.Location = new System.Drawing.Point(112, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 43);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // rad_KhongHD
            // 
            this.rad_KhongHD.AutoSize = true;
            this.rad_KhongHD.Location = new System.Drawing.Point(242, 16);
            this.rad_KhongHD.Name = "rad_KhongHD";
            this.rad_KhongHD.Size = new System.Drawing.Size(124, 19);
            this.rad_KhongHD.TabIndex = 1;
            this.rad_KhongHD.TabStop = true;
            this.rad_KhongHD.Text = "Không Hoạt Động";
            this.rad_KhongHD.UseVisualStyleBackColor = true;
            // 
            // rad_DangSuaChu
            // 
            this.rad_DangSuaChu.AutoSize = true;
            this.rad_DangSuaChu.Location = new System.Drawing.Point(128, 16);
            this.rad_DangSuaChu.Name = "rad_DangSuaChu";
            this.rad_DangSuaChu.Size = new System.Drawing.Size(108, 19);
            this.rad_DangSuaChu.TabIndex = 0;
            this.rad_DangSuaChu.TabStop = true;
            this.rad_DangSuaChu.Text = "Đang Sửa Chữa";
            this.rad_DangSuaChu.UseVisualStyleBackColor = true;
            // 
            // rad_DangHD
            // 
            this.rad_DangHD.AutoSize = true;
            this.rad_DangHD.Location = new System.Drawing.Point(6, 16);
            this.rad_DangHD.Name = "rad_DangHD";
            this.rad_DangHD.Size = new System.Drawing.Size(116, 19);
            this.rad_DangHD.TabIndex = 0;
            this.rad_DangHD.TabStop = true;
            this.rad_DangHD.Text = "Đang Hoạt Động";
            this.rad_DangHD.UseVisualStyleBackColor = true;
            // 
            // cbo_LoaiPhong
            // 
            this.cbo_LoaiPhong.FormattingEnabled = true;
            this.cbo_LoaiPhong.Location = new System.Drawing.Point(399, 23);
            this.cbo_LoaiPhong.Name = "cbo_LoaiPhong";
            this.cbo_LoaiPhong.Size = new System.Drawing.Size(143, 23);
            this.cbo_LoaiPhong.TabIndex = 2;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(112, 22);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(175, 22);
            this.txt_TenPhong.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(293, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại Phòng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgv_DSPhong);
            this.groupBox2.Location = new System.Drawing.Point(13, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // Dgv_DSPhong
            // 
            this.Dgv_DSPhong.AllowUserToAddRows = false;
            this.Dgv_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPH,
            this.TenPH,
            this.TinhTrangPhong,
            this.TrangThaiPhong,
            this.TenPhong,
            this.NgayVao,
            this.GioHT,
            this.GioSau});
            this.Dgv_DSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_DSPhong.Location = new System.Drawing.Point(3, 18);
            this.Dgv_DSPhong.Name = "Dgv_DSPhong";
            this.Dgv_DSPhong.Size = new System.Drawing.Size(542, 212);
            this.Dgv_DSPhong.TabIndex = 0;
            this.Dgv_DSPhong.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_DSPhong_CellEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Thoat);
            this.groupBox4.Controls.Add(this.btn_Them);
            this.groupBox4.Controls.Add(this.btn_Xoa);
            this.groupBox4.Controls.Add(this.btn_Luu);
            this.groupBox4.Controls.Add(this.btn_Sua);
            this.groupBox4.Location = new System.Drawing.Point(13, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 43);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(447, 14);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(95, 23);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(7, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(95, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(117, 14);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(95, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(337, 14);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(95, 23);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(227, 14);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(95, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // MaPH
            // 
            this.MaPH.DataPropertyName = "MaPH";
            this.MaPH.HeaderText = "Mã PH";
            this.MaPH.Name = "MaPH";
            this.MaPH.Width = 70;
            // 
            // TenPH
            // 
            this.TenPH.DataPropertyName = "TenPH";
            this.TenPH.HeaderText = "Tên PH";
            this.TenPH.Name = "TenPH";
            // 
            // TinhTrangPhong
            // 
            this.TinhTrangPhong.DataPropertyName = "TinhTrang";
            this.TinhTrangPhong.HeaderText = "Tình Trạng";
            this.TinhTrangPhong.Name = "TinhTrangPhong";
            this.TinhTrangPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TrangThaiPhong
            // 
            this.TrangThaiPhong.DataPropertyName = "TrangThai";
            this.TrangThaiPhong.HeaderText = "Trạng Thái";
            this.TrangThaiPhong.Name = "TrangThaiPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "MaLoai";
            this.TenPhong.HeaderText = "Loại Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenPhong.Width = 130;
            // 
            // NgayVao
            // 
            this.NgayVao.DataPropertyName = "NgayVao";
            this.NgayVao.HeaderText = "Ngày Vào";
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.Visible = false;
            // 
            // GioHT
            // 
            this.GioHT.DataPropertyName = "GioHT";
            this.GioHT.HeaderText = "GioHT";
            this.GioHT.Name = "GioHT";
            this.GioHT.Visible = false;
            // 
            // GioSau
            // 
            this.GioSau.DataPropertyName = "GioSau";
            this.GioSau.HeaderText = "Gio Sau";
            this.GioSau.Name = "GioSau";
            this.GioSau.Visible = false;
            // 
            // Frm_PhongHat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(569, 427);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PhongHat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PhongHat";
            this.Load += new System.EventHandler(this.Frm_PhongHat_Load);
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DSPhong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_LoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgv_DSPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_DangSuaChu;
        private System.Windows.Forms.RadioButton rad_DangHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rad_KhongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioSau;
    }
}