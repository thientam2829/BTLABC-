// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB5_5
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = new int[100];
            int i, n;

            n = 10;
            Console.WriteLine("Nhap vao gia tri x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} gia tri :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Gia tri {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int dem = 0;
            for (i = 0; i < n; i++)
            {
                if (x == arr1[i]) ;

                Console.WriteLine("X thuoc mang");

                for (i = 0; i < n; i++)
                {
                    if (arr1[i] == x)
                    {
                        dem++;
                    }
                }
                Console.Write("SO LAN XUAT HIEN LA : {0}\n", dem);
            }
        }
    }
}

