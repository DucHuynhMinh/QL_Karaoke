namespace PhucHien_MinhDuc.QLNguoiDung
{
    partial class Frm_DoiMatMa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_matma = new System.Windows.Forms.Button();
            this.txt_nhaplaimatma = new System.Windows.Forms.TextBox();
            this.txt_matmamoi = new System.Windows.Forms.TextBox();
            this.txt_matmahientai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_matma);
            this.groupBox1.Controls.Add(this.txt_nhaplaimatma);
            this.groupBox1.Controls.Add(this.txt_matmamoi);
            this.groupBox1.Controls.Add(this.txt_matmahientai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_HoTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(318, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(223, 153);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(79, 23);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_matma
            // 
            this.btn_matma.Location = new System.Drawing.Point(129, 153);
            this.btn_matma.Name = "btn_matma";
            this.btn_matma.Size = new System.Drawing.Size(89, 23);
            this.btn_matma.TabIndex = 2;
            this.btn_matma.Text = "Đổi Mật Mã";
            this.btn_matma.UseVisualStyleBackColor = true;
            this.btn_matma.Click += new System.EventHandler(this.btn_matma_Click);
            // 
            // txt_nhaplaimatma
            // 
            this.txt_nhaplaimatma.Location = new System.Drawing.Point(129, 121);
            this.txt_nhaplaimatma.Name = "txt_nhaplaimatma";
            this.txt_nhaplaimatma.PasswordChar = '^';
            this.txt_nhaplaimatma.Size = new System.Drawing.Size(173, 23);
            this.txt_nhaplaimatma.TabIndex = 1;
            // 
            // txt_matmamoi
            // 
            this.txt_matmamoi.Location = new System.Drawing.Point(129, 90);
            this.txt_matmamoi.Name = "txt_matmamoi";
            this.txt_matmamoi.PasswordChar = '^';
            this.txt_matmamoi.Size = new System.Drawing.Size(173, 23);
            this.txt_matmamoi.TabIndex = 1;
            // 
            // txt_matmahientai
            // 
            this.txt_matmahientai.Location = new System.Drawing.Point(129, 59);
            this.txt_matmahientai.Name = "txt_matmahientai";
            this.txt_matmahientai.PasswordChar = '^';
            this.txt_matmahientai.Size = new System.Drawing.Size(173, 23);
            this.txt_matmahientai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Lại Mật Mã";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Mã Mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Mã Hiện Tại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên Nhân Viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_HoTen.Location = new System.Drawing.Point(129, 31);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(173, 20);
            this.lbl_HoTen.TabIndex = 0;
            this.lbl_HoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_DoiMatMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 196);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DoiMatMa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.Frm_DoiMatMa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_matma;
        private System.Windows.Forms.TextBox txt_nhaplaimatma;
        private System.Windows.Forms.TextBox txt_matmamoi;
        private System.Windows.Forms.TextBox txt_matmahientai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label label4;
    }
}