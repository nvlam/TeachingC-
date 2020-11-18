using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mang2Chieu
{
    public partial class Form1 : Form
    {
        //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        const int soDong = 4;
        const int soCot = 5;
        int[,] int2Arr=new int[,] {{4,5,8,12,10},
        {6,8,1,4,6},
        {8,12,6,3,5},
        {12, 15, 18, 22, 13}
        };
        string[,] s2Arr = new string[4, 5];

        public void ChepMang()
        {
            for(int i=0;i<soDong;i++)
                for (int j = 0; j < soCot; j++)
                {
                    s2Arr[i, j] = int2Arr[i, j].ToString();
                }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void KhoiTaoMang()
        {
            for(int i=0;i<4;i++)
                for (int j = 0; j < 5; j++)
                {
                    int2Arr[i, j] = i + j;
                    s2Arr[i, j] = (i + j).ToString();
                }
        }

        public void HienThiMang2Chieu(int soDong, int soCot) {
            lblHienThi.Text = "Cac phan tu mang 2 chieu: \n";
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                    lblHienThi.Text += s2Arr[i, j]+" ";

                lblHienThi.Text += "\n";
            }
        }

        int GiaTriLonNhat(int soDong,int soCot) { 
            int giaTriLonNhat=int2Arr[0,0];
            for (int i = 1; i < soDong; i++)
                for (int j = 1; j < soCot; j++)
                    if (giaTriLonNhat < int2Arr[i, j])
                        giaTriLonNhat = int2Arr[i, j];
            return giaTriLonNhat;
        }

        int GiaTriNhoNhat(int soDong, int soCot)
        {
            int giaTriNhoNhat = int2Arr[0, 0];
            for (int i = 1; i < soDong; i++)
                for (int j = 1; j < soCot; j++)
                    if (int2Arr[i, j] < giaTriNhoNhat)
                        giaTriNhoNhat = int2Arr[i, j];
            return giaTriNhoNhat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // KhoiTaoMang();
            ChepMang();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThiMang2Chieu(4, 5);
        }

        public int Tong2Chieu()
        {
            int tong = 0;
            foreach (int e in int2Arr) // doi voi moi phan tu e trong mang 2 chieu int2Arr
                tong += e;
            return tong;
        }
        public double TBCong2Chieu() {
            return Tong2Chieu() / (4 * 5); // co the lay so phan tu mang 2 chieu int2Arr.Length
        }

        private void btnLonNhat_Click(object sender, EventArgs e)
        {
            lblGiaTriLonNhat.Text = "Gia tri lon nhat: \n";
            lblGiaTriLonNhat.Text += GiaTriLonNhat(4, 5).ToString();
        }

        private void btnHienThiNhoNhat_Click(object sender, EventArgs e)
        {

            lblGiaTriNhoNhat.Text = "Gia tri nho nhat: \n";
            int nhoNhat = GiaTriNhoNhat(4,5);
            lblGiaTriNhoNhat.Text += nhoNhat.ToString();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            lblTong.Text = Tong2Chieu().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTrungBinh.Text = TBCong2Chieu().ToString("#.##");
        }

        private void btnInChanLe_Click(object sender, EventArgs e)
        {
            
            lblChan.Text="So chan: \n";
            lblLe.Text="So le: \n";
            foreach(int e in int2Arr)
                if (e % 2 == 0)
                    lblChan.Text += e.ToString();
                else
                    lblLe.Text += e.ToString();

        }
    }
}
