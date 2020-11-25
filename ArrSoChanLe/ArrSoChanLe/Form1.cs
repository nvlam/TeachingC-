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
        public int[] a = new int[100];//{1,3,6,8,56,43,85,54,76,43};
        public int soPTa = 0;
        public int [] soChan=new int[100];
        public int soPTChan = 0;

        public int[] soLe = new int[100];
        public int soPTLe = 0;

        Random rd = new Random();

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

        public void HienThiMang(int[] arr, int soPhanTu, TextBox txt)
        {
            txt.Text = "";
            for (int i = 0; i < soPhanTu; ++i)
                txt.Text += arr[i].ToString() + " ";

           // lbl.Text += "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            TachChanLe();
                 
                   

            HienThiMang(soChan, soPTChan, txtChan);

            

            HienThiMang(soLe, soPTLe, txtLe);

        }

        private void btnSinhNgauNhien_Click(object sender, EventArgs e)
        {
            soPTa = int.Parse(txtSoPhanTu.Text.ToString().Trim());
            for (int i = 0; i < soPTa; i++)
                a[i] = rd.Next(1, 99);

            HienThiMang(a, soPTa, txtPhanTu);

        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            Array.Sort(a, 0, soPTa);
            HienThiMang(a, soPTa, txtTang);
        }

        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            Array.Reverse(a, 0, soPTa);
            HienThiMang(a, soPTa, txtGiam);

        }
    }
}
