namespace NguyenTrongDuy_2201130001
{
    partial class Frm_QuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyDichVu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_PhongDaDat = new System.Windows.Forms.RadioButton();
            this.rad_PhongCoKhach = new System.Windows.Forms.RadioButton();
            this.rad_PhongTrong = new System.Windows.Forms.RadioButton();
            this.rad_TatCa = new System.Windows.Forms.RadioButton();
            this.lst_Phong = new System.Windows.Forms.ListView();
            this.Img_ListHinh = new System.Windows.Forms.ImageList(this.components);
            this.grp_Menu = new System.Windows.Forms.GroupBox();
            this.btn_GoiDV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trv_DichVu = new System.Windows.Forms.TreeView();
            this.Time_DongHo = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.grp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Dịch Vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_PhongDaDat);
            this.groupBox2.Controls.Add(this.rad_PhongCoKhach);
            this.groupBox2.Controls.Add(this.rad_PhongTrong);
            this.groupBox2.Controls.Add(this.rad_TatCa);
            this.groupBox2.Controls.Add(this.lst_Phong);
            this.groupBox2.Location = new System.Drawing.Point(14, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(618, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // rad_PhongDaDat
            // 
            this.rad_PhongDaDat.AutoSize = true;
            this.rad_PhongDaDat.Location = new System.Drawing.Point(346, 23);
            this.rad_PhongDaDat.Name = "rad_PhongDaDat";
            this.rad_PhongDaDat.Size = new System.Drawing.Size(101, 20);
            this.rad_PhongDaDat.TabIndex = 61;
            this.rad_PhongDaDat.TabStop = true;
            this.rad_PhongDaDat.Text = "Phòng đã đặt";
            this.rad_PhongDaDat.UseVisualStyleBackColor = true;
            this.rad_PhongDaDat.CheckedChanged += new System.EventHandler(this.rad_PhongDaDat_CheckedChanged);
            // 
            // rad_PhongCoKhach
            // 
            this.rad_PhongCoKhach.AutoSize = true;
            this.rad_PhongCoKhach.Location = new System.Drawing.Point(212, 23);
            this.rad_PhongCoKhach.Name = "rad_PhongCoKhach";
            this.rad_PhongCoKhach.Size = new System.Drawing.Size(115, 20);
            this.rad_PhongCoKhach.TabIndex = 60;
            this.rad_PhongCoKhach.TabStop = true;
            this.rad_PhongCoKhach.Text = "Phòng có khách";
            this.rad_PhongCoKhach.UseVisualStyleBackColor = true;
            this.rad_PhongCoKhach.CheckedChanged += new System.EventHandler(this.rad_PhongCoKhach_CheckedChanged);
            // 
            // rad_PhongTrong
            // 
            this.rad_PhongTrong.AutoSize = true;
            this.rad_PhongTrong.Location = new System.Drawing.Point(98, 23);
            this.rad_PhongTrong.Name = "rad_PhongTrong";
            this.rad_PhongTrong.Size = new System.Drawing.Size(95, 20);
            this.rad_PhongTrong.TabIndex = 59;
            this.rad_PhongTrong.TabStop = true;
            this.rad_PhongTrong.Text = "Phòng trống";
            this.rad_PhongTrong.UseVisualStyleBackColor = true;
            this.rad_PhongTrong.CheckedChanged += new System.EventHandler(this.rad_PhongTrong_CheckedChanged);
            // 
            // rad_TatCa
            // 
            this.rad_TatCa.AutoSize = true;
            this.rad_TatCa.Location = new System.Drawing.Point(17, 23);
            this.rad_TatCa.Name = "rad_TatCa";
            this.rad_TatCa.Size = new System.Drawing.Size(62, 20);
            this.rad_TatCa.TabIndex = 58;
            this.rad_TatCa.TabStop = true;
            this.rad_TatCa.Text = "Tất cả";
            this.rad_TatCa.UseVisualStyleBackColor = true;
            this.rad_TatCa.CheckedChanged += new System.EventHandler(this.rad_TatCa_CheckedChanged);
            // 
            // lst_Phong
            // 
            this.lst_Phong.GridLines = true;
            this.lst_Phong.LargeImageList = this.Img_ListHinh;
            this.lst_Phong.Location = new System.Drawing.Point(8, 53);
            this.lst_Phong.Name = "lst_Phong";
            this.lst_Phong.Size = new System.Drawing.Size(595, 172);
            this.lst_Phong.TabIndex = 57;
            this.lst_Phong.UseCompatibleStateImageBehavior = false;
            // 
            // Img_ListHinh
            // 
            this.Img_ListHinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_ListHinh.ImageStream")));
            this.Img_ListHinh.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_ListHinh.Images.SetKeyName(0, "PhongTrong.png");
            this.Img_ListHinh.Images.SetKeyName(1, "PhongCoKhach.png");
            this.Img_ListHinh.Images.SetKeyName(2, "PhongDaDat.jpg");
            // 
            // grp_Menu
            // 
            this.grp_Menu.Controls.Add(this.btn_GoiDV);
            this.grp_Menu.Controls.Add(this.button2);
            this.grp_Menu.Controls.Add(this.btn_Thoat);
            this.grp_Menu.Controls.Add(this.btn_TinhTien);
            this.grp_Menu.Controls.Add(this.txt_SoLuong);
            this.grp_Menu.Controls.Add(this.txt_DonGia);
            this.grp_Menu.Controls.Add(this.lbl_Time);
            this.grp_Menu.Controls.Add(this.label2);
            this.grp_Menu.Controls.Add(this.label5);
            this.grp_Menu.Controls.Add(this.trv_DichVu);
            this.grp_Menu.Location = new System.Drawing.Point(14, 288);
            this.grp_Menu.Name = "grp_Menu";
            this.grp_Menu.Size = new System.Drawing.Size(618, 213);
            this.grp_Menu.TabIndex = 4;
            this.grp_Menu.TabStop = false;
            this.grp_Menu.Text = "Menu";
            // 
            // btn_GoiDV
            // 
            this.btn_GoiDV.Location = new System.Drawing.Point(498, 112);
            this.btn_GoiDV.Name = "btn_GoiDV";
            this.btn_GoiDV.Size = new System.Drawing.Size(105, 23);
            this.btn_GoiDV.TabIndex = 66;
            this.btn_GoiDV.Text = "Gọi Dịch Vụ";
            this.btn_GoiDV.UseVisualStyleBackColor = true;
            this.btn_GoiDV.Click += new System.EventHandler(this.btn_GoiDV_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(497, 171);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(106, 23);
            this.btn_Thoat.TabIndex = 64;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Location = new System.Drawing.Point(497, 141);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(106, 24);
            this.btn_TinhTien.TabIndex = 63;
            this.btn_TinhTien.Text = "&Tính Tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(497, 52);
            this.txt_SoLuong.MaxLength = 2;
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(106, 23);
            this.txt_SoLuong.TabIndex = 62;
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(497, 23);
            this.txt_DonGia.MaxLength = 2;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(106, 23);
            this.txt_DonGia.TabIndex = 62;
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Time.Location = new System.Drawing.Point(378, 78);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(225, 30);
            this.lbl_Time.TabIndex = 61;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(408, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(408, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Đơn Giá";
            // 
            // trv_DichVu
            // 
            this.trv_DichVu.Location = new System.Drawing.Point(8, 23);
            this.trv_DichVu.Name = "trv_DichVu";
            this.trv_DichVu.Size = new System.Drawing.Size(345, 184);
            this.trv_DichVu.TabIndex = 0;
            this.trv_DichVu.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trv_DichVu_BeforeSelect);
            this.trv_DichVu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_DichVu_AfterSelect);
            // 
            // Time_DongHo
            // 
            this.Time_DongHo.Interval = 1000;
            this.Time_DongHo.Tick += new System.EventHandler(this.Time_DongHo_Tick);
            // 
            // Frm_QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(644, 513);
            this.Controls.Add(this.grp_Menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_QuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.Frm_QuanLyDichVu_Load);
            this.Leave += new System.EventHandler(this.Frm_QuanLyDichVu_Leave);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_Menu.ResumeLayout(false);
            this.grp_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lst_Phong;
        private System.Windows.Forms.GroupBox grp_Menu;
        private System.Windows.Forms.TreeView trv_DichVu;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TinhTien;
        private System.Windows.Forms.ImageList Img_ListHinh;
        private System.Windows.Forms.RadioButton rad_PhongDaDat;
        private System.Windows.Forms.RadioButton rad_PhongCoKhach;
        private System.Windows.Forms.RadioButton rad_PhongTrong;
        private System.Windows.Forms.RadioButton rad_TatCa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Timer Time_DongHo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_GoiDV;
    }
}