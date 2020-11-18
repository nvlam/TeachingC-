namespace Mang2Chieu
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
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblGiaTriLonNhat = new System.Windows.Forms.Label();
            this.btnLonNhat = new System.Windows.Forms.Button();
            this.lblGiaTriNhoNhat = new System.Windows.Forms.Label();
            this.btnHienThiNhoNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(12, 36);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(94, 13);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "Cac phan tu mang";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(316, 36);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hien thi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblGiaTriLonNhat
            // 
            this.lblGiaTriLonNhat.AutoSize = true;
            this.lblGiaTriLonNhat.Location = new System.Drawing.Point(12, 115);
            this.lblGiaTriLonNhat.Name = "lblGiaTriLonNhat";
            this.lblGiaTriLonNhat.Size = new System.Drawing.Size(78, 13);
            this.lblGiaTriLonNhat.TabIndex = 2;
            this.lblGiaTriLonNhat.Text = "Gia tri lon nhat:";
            // 
            // btnLonNhat
            // 
            this.btnLonNhat.Location = new System.Drawing.Point(316, 81);
            this.btnLonNhat.Name = "btnLonNhat";
            this.btnLonNhat.Size = new System.Drawing.Size(75, 47);
            this.btnLonNhat.TabIndex = 3;
            this.btnLonNhat.Text = "Hien thi Lon Nhat";
            this.btnLonNhat.UseVisualStyleBackColor = true;
            this.btnLonNhat.Click += new System.EventHandler(this.btnLonNhat_Click);
            // 
            // lblGiaTriNhoNhat
            // 
            this.lblGiaTriNhoNhat.AutoSize = true;
            this.lblGiaTriNhoNhat.Location = new System.Drawing.Point(15, 155);
            this.lblGiaTriNhoNhat.Name = "lblGiaTriNhoNhat";
            this.lblGiaTriNhoNhat.Size = new System.Drawing.Size(82, 13);
            this.lblGiaTriNhoNhat.TabIndex = 4;
            this.lblGiaTriNhoNhat.Text = "Gia tri nho nhat:";
            // 
            // btnHienThiNhoNhat
            // 
            this.btnHienThiNhoNhat.Location = new System.Drawing.Point(316, 155);
            this.btnHienThiNhoNhat.Name = "btnHienThiNhoNhat";
            this.btnHienThiNhoNhat.Size = new System.Drawing.Size(75, 58);
            this.btnHienThiNhoNhat.TabIndex = 5;
            this.btnHienThiNhoNhat.Text = "Hien thi nho nhat";
            this.btnHienThiNhoNhat.UseVisualStyleBackColor = true;
            this.btnHienThiNhoNhat.Click += new System.EventHandler(this.btnHienThiNhoNhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.btnHienThiNhoNhat);
            this.Controls.Add(this.lblGiaTriNhoNhat);
            this.Controls.Add(this.btnLonNhat);
            this.Controls.Add(this.lblGiaTriLonNhat);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lblHienThi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblGiaTriLonNhat;
        private System.Windows.Forms.Button btnLonNhat;
        private System.Windows.Forms.Label lblGiaTriNhoNhat;
        private System.Windows.Forms.Button btnHienThiNhoNhat;
    }
}

