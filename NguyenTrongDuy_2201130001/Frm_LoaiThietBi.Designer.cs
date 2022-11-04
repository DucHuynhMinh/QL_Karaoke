namespace NguyenTrongDuy_2201130001
{
    partial class Frm_LoaiThietBi
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGV_LoaiThietBi = new System.Windows.Forms.DataGridView();
            this.MaLoaiTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_XuatXu = new System.Windows.Forms.TextBox();
            this.txt_TenLoaiTB = new System.Windows.Forms.TextBox();
            this.lbl_LoaiDV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LoaiThietBi)).BeginInit();
            this.Gpb_ThongTin.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_LoaiThietBi);
            this.groupBox4.Location = new System.Drawing.Point(12, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 224);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Loại Thiết Bị";
            // 
            // DGV_LoaiThietBi
            // 
            this.DGV_LoaiThietBi.AllowUserToAddRows = false;
            this.DGV_LoaiThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LoaiThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiTB,
            this.TenLoaiTB,
            this.XuatXu});
            this.DGV_LoaiThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_LoaiThietBi.Location = new System.Drawing.Point(3, 19);
            this.DGV_LoaiThietBi.Name = "DGV_LoaiThietBi";
            this.DGV_LoaiThietBi.Size = new System.Drawing.Size(514, 192);
            this.DGV_LoaiThietBi.TabIndex = 0;
            this.DGV_LoaiThietBi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LoaiThietBi_CellEnter);
            // 
            // MaLoaiTB
            // 
            this.MaLoaiTB.DataPropertyName = "MaLoaiTB";
            this.MaLoaiTB.HeaderText = "Mã Loại TB";
            this.MaLoaiTB.Name = "MaLoaiTB";
            this.MaLoaiTB.Width = 120;
            // 
            // TenLoaiTB
            // 
            this.TenLoaiTB.DataPropertyName = "TenLoaiTB";
            this.TenLoaiTB.HeaderText = "Tên Loại TB";
            this.TenLoaiTB.Name = "TenLoaiTB";
            this.TenLoaiTB.Width = 150;
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất Xứ";
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.Width = 150;
            // 
            // Gpb_ThongTin
            // 
            this.Gpb_ThongTin.Controls.Add(this.txt_XuatXu);
            this.Gpb_ThongTin.Controls.Add(this.txt_TenLoaiTB);
            this.Gpb_ThongTin.Controls.Add(this.lbl_LoaiDV);
            this.Gpb_ThongTin.Controls.Add(this.label1);
            this.Gpb_ThongTin.Location = new System.Drawing.Point(12, 33);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.Gpb_ThongTin.Size = new System.Drawing.Size(298, 131);
            this.Gpb_ThongTin.TabIndex = 17;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông Tin";
            // 
            // txt_XuatXu
            // 
            this.txt_XuatXu.Location = new System.Drawing.Point(131, 62);
            this.txt_XuatXu.Name = "txt_XuatXu";
            this.txt_XuatXu.Size = new System.Drawing.Size(151, 23);
            this.txt_XuatXu.TabIndex = 1;
            // 
            // txt_TenLoaiTB
            // 
            this.txt_TenLoaiTB.Location = new System.Drawing.Point(131, 26);
            this.txt_TenLoaiTB.Name = "txt_TenLoaiTB";
            this.txt_TenLoaiTB.Size = new System.Drawing.Size(151, 23);
            this.txt_TenLoaiTB.TabIndex = 1;
            // 
            // lbl_LoaiDV
            // 
            this.lbl_LoaiDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoaiDV.Location = new System.Drawing.Point(7, 64);
            this.lbl_LoaiDV.Name = "lbl_LoaiDV";
            this.lbl_LoaiDV.Size = new System.Drawing.Size(118, 20);
            this.lbl_LoaiDV.TabIndex = 0;
            this.lbl_LoaiDV.Text = "Xuất Xứ";
            this.lbl_LoaiDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại Thiết Bị :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(7, 49);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Luu);
            this.groupBox5.Controls.Add(this.btn_Thoat);
            this.groupBox5.Controls.Add(this.btn_Sua);
            this.groupBox5.Controls.Add(this.btn_Xoa);
            this.groupBox5.Controls.Add(this.btn_Them);
            this.groupBox5.Location = new System.Drawing.Point(314, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 131);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(107, 49);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 23);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(107, 81);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 23);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(107, 18);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(7, 18);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Danh Sách Thiết Bị";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_LoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(542, 402);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Gpb_ThongTin);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LoaiThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Thiết Bị";
            this.Load += new System.EventHandler(this.Frm_LoaiThietBi_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LoaiThietBi)).EndInit();
            this.Gpb_ThongTin.ResumeLayout(false);
            this.Gpb_ThongTin.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGV_LoaiThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private System.Windows.Forms.TextBox txt_XuatXu;
        private System.Windows.Forms.TextBox txt_TenLoaiTB;
        private System.Windows.Forms.Label lbl_LoaiDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
    }
}