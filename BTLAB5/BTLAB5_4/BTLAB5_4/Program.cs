// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB5_4
{
    class Program
    {
        public static void Main()
        {

            int[] arr1 = new int[100];
            int i, max, min, n;
            int dem = 0, dem2 = 0;           
            n = 10;
            Console.Write("Nhap {0} gia tri :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Gia tri {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr1[0];
            min = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            for (i = 0; i < n; i++)
            {
                if (arr1[i] == max)
                {
                    dem++;
                }
                if (arr1[i] == min)
                {
                    dem2++;
                }    
            }
            Console.Write("GIA TRI LON NHAT LA : {0}\n", max);
            Console.Write("SO LAN XUAT HIEN LA : {0}\n", dem);
            Console.Write("GIA TRI NHO NHAT LA : {0}\n", min);
            Console.Write("SO LAN XUAT HIEN LA : {0}\n", dem2);
            Console.ReadKey(); 
        }
    }
}
