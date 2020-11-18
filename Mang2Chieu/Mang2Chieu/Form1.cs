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
        int[,] int2Arr=new int[4,5];
        string[,] s2Arr = new string[4, 5];

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
