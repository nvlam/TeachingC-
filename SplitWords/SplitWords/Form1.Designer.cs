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
            this.lblOutPut.Size = new System.Drawing.Size(35, 13);
            this.lblOutPut.TabIndex = 1;
            this.lblOutPut.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(434, 31);
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
            this.btnTong.Location = new System.Drawing.Point(434, 88);
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
            this.btnTrungBinh.Location = new System.Drawing.Point(434, 134);
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
            this.btnLonNhat.Location = new System.Drawing.Point(413, 170);
            this.btnLonNhat.Name = "btnLonNhat";
            this.btnLonNhat.Size = new System.Drawing.Size(96, 23);
            this.btnLonNhat.TabIndex = 10;
            this.btnLonNhat.Text = "PT Lon Nhat";
            this.btnLonNhat.UseVisualStyleBackColor = true;
            this.btnLonNhat.Click += new System.EventHandler(this.btnLonNhat_Click);
            // 
            // btnNhoNhat
            // 
            this.btnNhoNhat.Location = new System.Drawing.Point(434, 205);
            this.btnNhoNhat.Name = "btnNhoNhat";
            this.btnNhoNhat.Size = new System.Drawing.Size(75, 23);
            this.btnNhoNhat.TabIndex = 11;
            this.btnNhoNhat.Text = "PT Nho nhat";
            this.btnNhoNhat.UseVisualStyleBackColor = true;
            this.btnNhoNhat.Click += new System.EventHandler(this.btnNhoNhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 262);
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
    }
}

