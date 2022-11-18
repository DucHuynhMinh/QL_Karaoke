namespace PhucHien_MinhDuc
{
    partial class Frm_LoaiPhong
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
            this.grp_thongtin = new System.Windows.Forms.GroupBox();
            this.txt_GioBT = new System.Windows.Forms.TextBox();
            this.txt_GioCD = new System.Windows.Forms.TextBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGV_DSLP = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_thongtin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DSLP)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_thongtin
            // 
            this.grp_thongtin.Controls.Add(this.txt_GioBT);
            this.grp_thongtin.Controls.Add(this.txt_GioCD);
            this.grp_thongtin.Controls.Add(this.txt_TenLoai);
            this.grp_thongtin.Controls.Add(this.label4);
            this.grp_thongtin.Controls.Add(this.label2);
            this.grp_thongtin.Controls.Add(this.label1);
            this.grp_thongtin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_thongtin.Location = new System.Drawing.Point(13, 38);
            this.grp_thongtin.Name = "grp_thongtin";
            this.grp_thongtin.Size = new System.Drawing.Size(320, 123);
            this.grp_thongtin.TabIndex = 1;
            this.grp_thongtin.TabStop = false;
            this.grp_thongtin.Text = "Thông Tin";
            // 
            // txt_GioBT
            // 
            this.txt_GioBT.Location = new System.Drawing.Point(139, 87);
            this.txt_GioBT.Name = "txt_GioBT";
            this.txt_GioBT.Size = new System.Drawing.Size(93, 22);
            this.txt_GioBT.TabIndex = 1;
            this.txt_GioBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GioBT_KeyPress);
            // 
            // txt_GioCD
            // 
            this.txt_GioCD.Location = new System.Drawing.Point(139, 56);
            this.txt_GioCD.Name = "txt_GioCD";
            this.txt_GioCD.Size = new System.Drawing.Size(93, 22);
            this.txt_GioCD.TabIndex = 1;
            this.txt_GioCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GioCD_KeyPress);
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(139, 25);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(151, 22);
            this.txt_TenLoai.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giờ Bình Thường";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giờ Cao Điểm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại Phòng : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_DSLP);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 224);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Loại Phòng";
            // 
            // DGV_DSLP
            // 
            this.DGV_DSLP.AllowUserToAddRows = false;
            this.DGV_DSLP.AllowUserToDeleteRows = false;
            this.DGV_DSLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DSLP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.GioCD,
            this.GioBT});
            this.DGV_DSLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DSLP.Location = new System.Drawing.Point(3, 18);
            this.DGV_DSLP.Name = "DGV_DSLP";
            this.DGV_DSLP.ReadOnly = true;
            this.DGV_DSLP.Size = new System.Drawing.Size(498, 203);
            this.DGV_DSLP.TabIndex = 0;
            this.DGV_DSLP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DSLP_CellEnter);
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenPhong";
            this.TenLoai.HeaderText = "Tên Loại";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            this.TenLoai.Width = 130;
            // 
            // GioCD
            // 
            this.GioCD.DataPropertyName = "GioCD";
            this.GioCD.HeaderText = "Giờ CD";
            this.GioCD.Name = "GioCD";
            this.GioCD.ReadOnly = true;
            // 
            // GioBT
            // 
            this.GioBT.DataPropertyName = "GioBT";
            this.GioBT.HeaderText = "Giờ BT";
            this.GioBT.Name = "GioBT";
            this.GioBT.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Luu);
            this.groupBox5.Controls.Add(this.btn_Thoat);
            this.groupBox5.Controls.Add(this.btn_Sua);
            this.groupBox5.Controls.Add(this.btn_Xoa);
            this.groupBox5.Controls.Add(this.btn_Them);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(339, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 128);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(7, 54);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(88, 87);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(88, 54);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(88, 21);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(7, 21);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
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
            this.label6.Size = new System.Drawing.Size(526, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh Sách Từng Loại Phòng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(526, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grp_thongtin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Phòng";
            this.Load += new System.EventHandler(this.Frm_LoaiPhong_Load);
            this.grp_thongtin.ResumeLayout(false);
            this.grp_thongtin.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DSLP)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_thongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.TextBox txt_GioCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGV_DSLP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_GioBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioBT;
    }
}