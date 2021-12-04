// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB4_8
{
    class Program
    {
        public static void Main()
        {

            int n, a, b, c = 0, d;
            Console.Write("Chuyen doi nhi phan trong :\n");
            Console.Write("--------------------------------------------\n");
            Console.Write("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            d = n;
            a = 1;
            for (b = n; b > 0; b = b / 2)
            {
               c = c + (n % 2) * a;
                a = a * 10;
                n = n / 2;
            }

            Console.Write("\nSo  nhi phan tuong duong cua so {0} la {1}.\n\n", d, c);

            Console.ReadKey();
        }
    }
}
