namespace SplitWords
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.btnTrungBinh = new System.Windows.Forms.Button();
            this.lblLonNhat = new System.Windows.Forms.Label();
            this.lblNhoNhat = new System.Windows.Forms.Label();
            this.btnLonNhat = new System.Windows.Forms.Button();
            this.btnNhoNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhanTuCanThem = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.lblViTriThem = new System.Windows.Forms.Label();
            this.txtViTriThem = new System.Windows.Forms.TextBox();
            this.lblNhapPTXoa = new System.Windows.Forms.Label();
            this.txtPhanTuXoa = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(47, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(337, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.Location = new System.Drawing.Point(46, 69);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(72, 13);
            this.lblOutPut.TabIndex = 1;
            this.lblOutPut.Text = "Hien thi mang";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(638, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Luu vao mang";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(47, 120);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(38, 13);
            this.lblTong.TabIndex = 3;
            this.lblTong.Text = "Tong: ";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(638, 78);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 23);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tinh tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Location = new System.Drawing.Point(47, 154);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(143, 13);
            this.lblTrungBinh.TabIndex = 6;
            this.lblTrungBinh.Text = "Trung binh cong cua day so:";
            // 
            // btnTrungBinh
            // 
            this.btnTrungBinh.Location = new System.Drawing.Point(638, 124);
            this.btnTrungBinh.Name = "btnTrungBinh";
            this.btnTrungBinh.Size = new System.Drawing.Size(75, 23);
            this.btnTrungBinh.TabIndex = 7;
            this.btnTrungBinh.Text = "Tinh Trung binh";
            this.btnTrungBinh.UseVisualStyleBackColor = true;
            this.btnTrungBinh.Click += new System.EventHandler(this.btnTrungBinh_Click);
            // 
            // lblLonNhat
            // 
            this.lblLonNhat.AutoSize = true;
            this.lblLonNhat.Location = new System.Drawing.Point(47, 181);
            this.lblLonNhat.Name = "lblLonNhat";
            this.lblLonNhat.Size = new System.Drawing.Size(49, 13);
            this.lblLonNhat.TabIndex = 8;
            this.lblLonNhat.Text = "Lon nhat";
            // 
            // lblNhoNhat
            // 
            this.lblNhoNhat.AutoSize = true;
            this.lblNhoNhat.Location = new System.Drawing.Point(47, 216);
            this.lblNhoNhat.Name = "lblNhoNhat";
            this.lblNhoNhat.Size = new System.Drawing.Size(51, 13);
            this.lblNhoNhat.TabIndex = 9;
            this.lblNhoNhat.Text = "Nho nhat";
            // 
            // btnLonNhat
            // 
            this.btnLonNhat.Location = new System.Drawing.Point(617, 160);
            this.btnLonNhat.Name = "btnLonNhat";
            this.btnLonNhat.Size = new System.Drawing.Size(96, 23);
            this.btnLonNhat.TabIndex = 10;
            this.btnLonNhat.Text = "PT Lon Nhat";
            this.btnLonNhat.UseVisualStyleBackColor = true;
            this.btnLonNhat.Click += new System.EventHandler(this.btnLonNhat_Click);
            // 
            // btnNhoNhat
            // 
            this.btnNhoNhat.Location = new System.Drawing.Point(638, 195);
            this.btnNhoNhat.Name = "btnNhoNhat";
            this.btnNhoNhat.Size = new System.Drawing.Size(75, 23);
            this.btnNhoNhat.TabIndex = 11;
            this.btnNhoNhat.Text = "PT Nho nhat";
            this.btnNhoNhat.UseVisualStyleBackColor = true;
            this.btnNhoNhat.Click += new System.EventHandler(this.btnNhoNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phan tu can them:";
            // 
            // txtPhanTuCanThem
            // 
            this.txtPhanTuCanThem.Location = new System.Drawing.Point(161, 253);
            this.txtPhanTuCanThem.Name = "txtPhanTuCanThem";
            this.txtPhanTuCanThem.Size = new System.Drawing.Size(100, 20);
            this.txtPhanTuCanThem.TabIndex = 13;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(638, 249);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 14;
            this.btnThemMoi.Text = "Them moi";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // lblViTriThem
            // 
            this.lblViTriThem.AutoSize = true;
            this.lblViTriThem.Location = new System.Drawing.Point(300, 259);
            this.lblViTriThem.Name = "lblViTriThem";
            this.lblViTriThem.Size = new System.Drawing.Size(53, 13);
            this.lblViTriThem.TabIndex = 15;
            this.lblViTriThem.Text = "Vi tri them";
            // 
            // txtViTriThem
            // 
            this.txtViTriThem.Location = new System.Drawing.Point(389, 259);
            this.txtViTriThem.Name = "txtViTriThem";
            this.txtViTriThem.Size = new System.Drawing.Size(100, 20);
            this.txtViTriThem.TabIndex = 16;
            // 
            // lblNhapPTXoa
            // 
            this.lblNhapPTXoa.AutoSize = true;
            this.lblNhapPTXoa.Location = new System.Drawing.Point(50, 302);
            this.lblNhapPTXoa.Name = "lblNhapPTXoa";
            this.lblNhapPTXoa.Size = new System.Drawing.Size(116, 13);
            this.lblNhapPTXoa.TabIndex = 17;
            this.lblNhapPTXoa.Text = "Nhap phan tu can xoa:";
            // 
            // txtPhanTuXoa
            // 
            this.txtPhanTuXoa.Location = new System.Drawing.Point(194, 302);
            this.txtPhanTuXoa.Name = "txtPhanTuXoa";
            this.txtPhanTuXoa.Size = new System.Drawing.Size(100, 20);
            this.txtPhanTuXoa.TabIndex = 18;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(638, 298);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 515);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtPhanTuXoa);
            this.Controls.Add(this.lblNhapPTXoa);
            this.Controls.Add(this.txtViTriThem);
            this.Controls.Add(this.lblViTriThem);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtPhanTuCanThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhoNhat);
            this.Controls.Add(this.btnLonNhat);
            this.Controls.Add(this.lblNhoNhat);
            this.Controls.Add(this.lblLonNhat);
            this.Controls.Add(this.btnTrungBinh);
            this.Controls.Add(this.lblTrungBinh);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Button btnTrungBinh;
        private System.Windows.Forms.Label lblLonNhat;
        private System.Windows.Forms.Label lblNhoNhat;
        private System.Windows.Forms.Button btnLonNhat;
        private System.Windows.Forms.Button btnNhoNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhanTuCanThem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Label lblViTriThem;
        private System.Windows.Forms.TextBox txtViTriThem;
        private System.Windows.Forms.Label lblNhapPTXoa;
        private System.Windows.Forms.TextBox txtPhanTuXoa;
        private System.Windows.Forms.Button btnXoa;
    }
}

