namespace NguyenTrongDuy_2201130001
{
    partial class Frm_LoaiDV
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_LoaiDV = new System.Windows.Forms.TextBox();
            this.txt_TenDV = new System.Windows.Forms.TextBox();
            this.lbl_LoaiDV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_DichVu = new System.Windows.Forms.DataGridView();
            this.MaLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.Gpb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DichVu)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh Sách Từng Loại Dịch Vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox5.Size = new System.Drawing.Size(218, 115);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
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
            // Gpb_ThongTin
            // 
            this.Gpb_ThongTin.Controls.Add(this.txt_LoaiDV);
            this.Gpb_ThongTin.Controls.Add(this.txt_TenDV);
            this.Gpb_ThongTin.Controls.Add(this.lbl_LoaiDV);
            this.Gpb_ThongTin.Controls.Add(this.label1);
            this.Gpb_ThongTin.Location = new System.Drawing.Point(12, 33);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.Gpb_ThongTin.Size = new System.Drawing.Size(298, 115);
            this.Gpb_ThongTin.TabIndex = 13;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông Tin";
            // 
            // txt_LoaiDV
            // 
            this.txt_LoaiDV.Location = new System.Drawing.Point(131, 62);
            this.txt_LoaiDV.Name = "txt_LoaiDV";
            this.txt_LoaiDV.Size = new System.Drawing.Size(151, 22);
            this.txt_LoaiDV.TabIndex = 1;
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.Location = new System.Drawing.Point(131, 26);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Size = new System.Drawing.Size(151, 22);
            this.txt_TenDV.TabIndex = 1;
            // 
            // lbl_LoaiDV
            // 
            this.lbl_LoaiDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoaiDV.Location = new System.Drawing.Point(7, 64);
            this.lbl_LoaiDV.Name = "lbl_LoaiDV";
            this.lbl_LoaiDV.Size = new System.Drawing.Size(118, 20);
            this.lbl_LoaiDV.TabIndex = 0;
            this.lbl_LoaiDV.Text = "Loại Dịch Vụ :";
            this.lbl_LoaiDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Dịch Vụ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGV_DichVu
            // 
            this.DGV_DichVu.AllowUserToAddRows = false;
            this.DGV_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiDV,
            this.TenLoaiDV,
            this.LoaiDV});
            this.DGV_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DichVu.Location = new System.Drawing.Point(3, 18);
            this.DGV_DichVu.Name = "DGV_DichVu";
            this.DGV_DichVu.Size = new System.Drawing.Size(514, 203);
            this.DGV_DichVu.TabIndex = 0;
            this.DGV_DichVu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DichVu_CellEnter);
            // 
            // MaLoaiDV
            // 
            this.MaLoaiDV.DataPropertyName = "MaLoaiDV";
            this.MaLoaiDV.HeaderText = "Mã Loại DV";
            this.MaLoaiDV.Name = "MaLoaiDV";
            this.MaLoaiDV.Width = 120;
            // 
            // TenLoaiDV
            // 
            this.TenLoaiDV.DataPropertyName = "TenLoaiDV";
            this.TenLoaiDV.HeaderText = "Tên Dịch Vụ";
            this.TenLoaiDV.Name = "TenLoaiDV";
            this.TenLoaiDV.Width = 150;
            // 
            // LoaiDV
            // 
            this.LoaiDV.DataPropertyName = "LoaiDV";
            this.LoaiDV.HeaderText = "Loại Dịch Vụ";
            this.LoaiDV.Name = "LoaiDV";
            this.LoaiDV.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_DichVu);
            this.groupBox4.Location = new System.Drawing.Point(12, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 224);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Loại Phòng";
            // 
            // Frm_LoaiDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(542, 388);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Gpb_ThongTin);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LoaiDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Dịch Vụ";
            this.Load += new System.EventHandler(this.Frm_LoaiDV_Load);
            this.groupBox5.ResumeLayout(false);
            this.Gpb_ThongTin.ResumeLayout(false);
            this.Gpb_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DichVu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private System.Windows.Forms.TextBox txt_TenDV;
        private System.Windows.Forms.Label lbl_LoaiDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_DichVu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
    }
}