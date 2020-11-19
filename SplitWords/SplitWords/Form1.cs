using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplitWords
{
    public partial class Form1 : Form
    {
        string[] strArr=new string[50];
        int[] intArr=new int[50];
        int soPT = 0;

        public Form1()
        {
            InitializeComponent();
        }

        int GiaTriLonNhat()
        {
            int intLonNhat = intArr[0];
            for (int i = 1; i < soPT; ++i)
                if (intLonNhat < intArr[i])
                    intLonNhat = intArr[i];//thay phan tu lon nhat
            return intLonNhat;

        }
        int GiaTriNhoNhat()
        {
            int intNhoNhat = intArr[0];

            for (int i = 1; i < soPT; ++i)
                if (intArr[i] < intNhoNhat)
                    intNhoNhat = intArr[i];//thay phan tu nho nhat

            return intNhoNhat;
        }

        int TongMang()
        {
            int tong = 0;
            for (int i = 0; i < soPT; ++i)
                tong += intArr[i];
            return tong;
        }

        double TrungBinhCong()
        {
            return (double)TongMang()/soPT;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strArr = txtInput.Text.ToString().Trim().Split(' ');// tach tu dua vao khoang trong
            
            lblOutPut.Text = string.Empty;
            
            for (int i = 0; i < strArr.Length; i++)
            {
                lblOutPut.Text += strArr[i] + " ";// hien thi
                //doi thanh so nguyen va luu vao mang intArr cac so nguyen
                intArr[soPT++] = int.Parse(strArr[i]); // doi thanh so nguyen

            }
        }

        public void HienThiMang()
        {
            lblOutPut.Text = "Cac phan tu mang: \n";
            for(int i=0;i<soPT;i++)
            {
                lblOutPut.Text += intArr[i].ToString() + " ";
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            lblTong.Text = "Tong: \n";
            lblTong.Text += TongMang();

        }

        private void btnTrungBinh_Click(object sender, EventArgs e)
        {
            lblTrungBinh.Text = "Trung binh cong: \n";
            lblTrungBinh.Text+= TrungBinhCong().ToString("#.##");
        }

        private void btnLonNhat_Click(object sender, EventArgs e)
        {
            lblLonNhat.Text = "Gia tri lon nhat: " + GiaTriLonNhat();
        }

        private void btnNhoNhat_Click(object sender, EventArgs e)
        {
            lblNhoNhat.Text="Gia tri nho nhat: " + GiaTriNhoNhat();
        }

        public void Them(int x, int pos)
        {
            //doi cac phan tu qua phai
            for (int i = soPT; i > pos; i--)
            {
                intArr[i] = intArr[i - 1];
            }
            intArr[pos] = x;
            soPT++;
        }

        public void Xoa(int pos) { 
        // doi qua trai de len vi tri muo xoa
            for (int i = pos; i < soPT-1; i++)
                intArr[i] = intArr[i + 1];
            //giam so phan tu 1
            --soPT;
        }

        public int TimKiem(int x)
        {
            int vitri = -1;
            for (int i = 0; i < soPT; i++)
                if (intArr[i] == x)
                {
                    vitri = i;
                    break;//thoat khoi vong lap
                }

            return vitri;
        }
        public void XoaPT(int x)
    {
        int pos = TimKiem(x);
            if(pos!=-1)
                Xoa(pos);
    }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int ptMoi = int.Parse(txtPhanTuCanThem.Text.ToString().Trim());
            int pos=int.Parse(txtViTriThem.Text.ToString().Trim());
            Them(ptMoi, pos);
            HienThiMang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtPhanTuXoa.Text.ToString().Trim());
            XoaPT(x);
            HienThiMang();
        }
    }
}
