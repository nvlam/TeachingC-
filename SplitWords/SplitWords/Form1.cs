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
    }
}
