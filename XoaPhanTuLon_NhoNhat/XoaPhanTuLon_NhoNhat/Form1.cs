using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XoaPhanTuLon_NhoNhat
{

    public partial class Form1 : Form
    {
        int[] mang = new int[100];
        int sopt = 0;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public void HienThiMang(int[] a, int SoPhanTu, TextBox txt)
        {
            txt.Text = "";
            for (int i = 0; i < SoPhanTu; i++)
                txt.Text += a[i] + " ";
        }

        public void Xoa(int p, ref int[] a, ref int SoPhanTu) {
            for (int i = p; i < SoPhanTu; i++)
                a[i] = a[i + 1];

            --SoPhanTu;
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            sopt = int.Parse(txtSoPhanTu.Text.ToString().Trim());
            for (int i = 0; i < sopt; i++)
                mang[i] = rd.Next(1, 99);

            HienThiMang(mang, sopt, txtMang);
        }

        public int TimLonNhat(int[] a, int SoPhanTu)
        {
            int max = a[0];
            int vitriLonNhat = 0;
            for(int i=1;i<SoPhanTu;i++)
                if (a[i] > max)
                {
                    max = a[i];
                    vitriLonNhat = i;
                }

            return vitriLonNhat;

        }

        public int TimLonNhoNhat(int[] a, int SoPhanTu)
        {
            int min = a[0];
            int vitriNhoNhat = 0;
            for (int i = 1; i < SoPhanTu; i++)
                if (a[i] < min)
                {
                    min = a[i];
                    vitriNhoNhat = i;
                }

            return vitriNhoNhat;

        }

        private void btnXoaSoLonNhat_Click(object sender, EventArgs e)
        {
            int p = TimLonNhat(mang,sopt);
            
            Xoa(p, ref mang, ref sopt);
            HienThiMang(mang, sopt, txtMangSauXoa);

        }

        private void btnXoaSoNhoNhat_Click(object sender, EventArgs e)
        {
            int p = TimLonNhoNhat(mang, sopt);

            Xoa(p, ref mang, ref sopt);
            HienThiMang(mang, sopt, txtMangSauXoa);
        }
    }
}
