using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrSoChanLe
{
    public partial class Form1 : Form
    {
        public int[] a=new int[]{1,3,6,8,56,43,85,54,76,43};
        public int soPTa = 10;
        public int [] soChan=new int[100];
        public int soPTChan = 0;

        public int[] soLe = new int[100];
        public int soPTLe = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void TachChanLe()
        {
            for (int i = 0; i < soPTa; i++)
                if (a[i] % 2 == 0) // so chan
                    soChan[soPTChan++] = a[i];
                else
                    soLe[soPTLe++] = a[i];
                
        }

        public void HienThiMang(int[] arr, int soPhanTu, Label lbl)
        {
            for (int i = 0; i < soPhanTu; ++i)
                lbl.Text += arr[i].ToString() + " ";

            lbl.Text += "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            TachChanLe();

            lblPhanTuMang.Text = "";

            HienThiMang(a, soPTa, lblPhanTuMang);

            lblPhanTuChan.Text = "";

            HienThiMang(soChan, soPTChan, lblPhanTuChan);

            lblPhanTuLe.Text = "";

            HienThiMang(soLe, soPTLe, lblPhanTuLe);

        }
    }
}
