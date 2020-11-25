namespace ArrSoChanLe
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
            this.lblPhanTuChan = new System.Windows.Forms.Label();
            this.lblPhanTuLe = new System.Windows.Forms.Label();
            this.lblPhanTuMang = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhanTuChan
            // 
            this.lblPhanTuChan.AutoSize = true;
            this.lblPhanTuChan.Location = new System.Drawing.Point(41, 45);
            this.lblPhanTuChan.Name = "lblPhanTuChan";
            this.lblPhanTuChan.Size = new System.Drawing.Size(89, 13);
            this.lblPhanTuChan.TabIndex = 0;
            this.lblPhanTuChan.Text = "So phan tu chan:";
            // 
            // lblPhanTuLe
            // 
            this.lblPhanTuLe.AutoSize = true;
            this.lblPhanTuLe.Location = new System.Drawing.Point(44, 88);
            this.lblPhanTuLe.Name = "lblPhanTuLe";
            this.lblPhanTuLe.Size = new System.Drawing.Size(35, 13);
            this.lblPhanTuLe.TabIndex = 1;
            this.lblPhanTuLe.Text = "label1";
            // 
            // lblPhanTuMang
            // 
            this.lblPhanTuMang.AutoSize = true;
            this.lblPhanTuMang.Location = new System.Drawing.Point(47, 13);
            this.lblPhanTuMang.Name = "lblPhanTuMang";
            this.lblPhanTuMang.Size = new System.Drawing.Size(35, 13);
            this.lblPhanTuMang.TabIndex = 2;
            this.lblPhanTuMang.Text = "label1";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(397, 24);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(69, 57);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "button1";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 262);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lblPhanTuMang);
            this.Controls.Add(this.lblPhanTuLe);
            this.Controls.Add(this.lblPhanTuChan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhanTuChan;
        private System.Windows.Forms.Label lblPhanTuLe;
        private System.Windows.Forms.Label lblPhanTuMang;
        private System.Windows.Forms.Button btnHienThi;
    }
}

