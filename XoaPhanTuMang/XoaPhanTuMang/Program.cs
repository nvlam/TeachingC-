using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace XoaPhanTuMang
{
    class Program
    {      public static int soPhanTu = 5;
           public static int[] mangSo = new int[50];
        static void Main(string[] args)
        {
            //KhoiTao(5);
            for (int i = 0; i < soPhanTu; i++)
                mangSo[i] = i;
           // Inmang();

            for (int i = 0; i < soPhanTu; i++)
                Console.Write(mangSo[i] + " ");
            //XoaMang(3);
            int pos = 3;
            for (int i = pos; i < soPhanTu - 1; i++)
                mangSo[i] = mangSo[i + 1];//doi cac phan tu ben phai sang trai ke tu vi tri pos

            --soPhanTu;


            // Inmang();
            Console.WriteLine();

            for (int i = 0; i < soPhanTu; i++)
                Console.Write(mangSo[i] + " ");

            //Xen phan tu moi
           // XenMang(int x, int pos)
            //doi cac phan tu qua ben phai
            int x = 10;
            for (int i = soPhanTu; i >= pos; i--)
                mangSo[i] = mangSo[i - 1];

            //gan gia tri x cho phan tu tai vi tri pos
            mangSo[pos] = x;
            //so phan tu tang 1;
            soPhanTu++;

            Console.WriteLine();

            // Inmang();

            for (int i = 0; i < soPhanTu; i++)
                Console.Write(mangSo[i] + " ");


            /*
            string strNumbers = " 1, 3, 4, 9, 2";
            int[] so = new int[] { 1, 2,3,4,5};

            ArrayList numbers = new ArrayList(strNumbers.Split(new char[] { ',' }));
            numbers.RemoveAt(2);

            ArrayList arrSo = new ArrayList(so);//Doi tu mang sang ArrayList (danh sach mang)
            arrSo.Remove(5);

            foreach (var n in numbers)
            {
                Console.Write(n);
                //Response.Write(n);
               
            }
            Console.WriteLine();
            foreach (var n in arrSo)
            {
                Console.Write(n+" ");
                //Response.Write(n);


            }
            
          */ 
            
            Console.ReadLine();
        }

        public void KhoiTao(int spt) {
            for (int i = 0; i < soPhanTu; i++)
                mangSo[i] = i;
        }

        public void Inmang()
        {
            for (int i = 0; i < soPhanTu; i++)
                Console.Write(mangSo[i] + " ");
        }
        public void XoaMang(int pos)
        {
            for (int i = pos; i < soPhanTu - 1; i++)
                mangSo[i] = mangSo[i + 1];//doi cac phan tu ben phai sang trai ke tu vi tri pos

            --soPhanTu;
        }

        public void XenMang(int x, int pos){
            //doi cac phan tu qua ben phai
            for (int i = soPhanTu; i >= pos; i--)
                mangSo[i] = mangSo[i - 1];

            //gan gia tri x cho phan tu tai vi tri pos
            mangSo[pos] = x;
            //so phan tu tang 1;
            soPhanTu++;

    }
    }
}
