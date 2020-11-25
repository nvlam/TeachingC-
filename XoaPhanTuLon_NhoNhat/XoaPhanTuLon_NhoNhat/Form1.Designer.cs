namespace XoaPhanTuLon_NhoNhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoPhanTu = new System.Windows.Forms.TextBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.txtMangSauXoa = new System.Windows.Forms.TextBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnXoaSoLonNhat = new System.Windows.Forms.Button();
            this.btnXoaSoNhoNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "So phan tu mang:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xuat ket qua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ket qua:";
            // 
            // txtSoPhanTu
            // 
            this.txtSoPhanTu.Location = new System.Drawing.Point(143, 20);
            this.txtSoPhanTu.Name = "txtSoPhanTu";
            this.txtSoPhanTu.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhanTu.TabIndex = 3;
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(143, 51);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(443, 20);
            this.txtMang.TabIndex = 4;
            // 
            // txtMangSauXoa
            // 
            this.txtMangSauXoa.Location = new System.Drawing.Point(143, 93);
            this.txtMangSauXoa.Name = "txtMangSauXoa";
            this.txtMangSauXoa.Size = new System.Drawing.Size(443, 20);
            this.txtMangSauXoa.TabIndex = 5;
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(39, 145);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(75, 46);
            this.btnXuatMang.TabIndex = 6;
            this.btnXuatMang.Text = "&Xuat mang";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnXoaSoLonNhat
            // 
            this.btnXoaSoLonNhat.Location = new System.Drawing.Point(143, 145);
            this.btnXoaSoLonNhat.Name = "btnXoaSoLonNhat";
            this.btnXoaSoLonNhat.Size = new System.Drawing.Size(75, 46);
            this.btnXoaSoLonNhat.TabIndex = 7;
            this.btnXoaSoLonNhat.Text = "Xoa so &lon nhat";
            this.btnXoaSoLonNhat.UseVisualStyleBackColor = true;
            this.btnXoaSoLonNhat.Click += new System.EventHandler(this.btnXoaSoLonNhat_Click);
            // 
            // btnXoaSoNhoNhat
            // 
            this.btnXoaSoNhoNhat.Location = new System.Drawing.Point(241, 145);
            this.btnXoaSoNhoNhat.Name = "btnXoaSoNhoNhat";
            this.btnXoaSoNhoNhat.Size = new System.Drawing.Size(75, 46);
            this.btnXoaSoNhoNhat.TabIndex = 8;
            this.btnXoaSoNhoNhat.Text = "Xoa so &nho nhat";
            this.btnXoaSoNhoNhat.UseVisualStyleBackColor = true;
            this.btnXoaSoNhoNhat.Click += new System.EventHandler(this.btnXoaSoNhoNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(342, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "&Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 262);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaSoNhoNhat);
            this.Controls.Add(this.btnXoaSoLonNhat);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.txtMangSauXoa);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.txtSoPhanTu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoPhanTu;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.TextBox txtMangSauXoa;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnXoaSoLonNhat;
        private System.Windows.Forms.Button btnXoaSoNhoNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}

