// See https://aka.ms/new-console-template for more information
using System;

namespace BT2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("MOI NHAP VAO SO n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, i = 1;
            for ( i = 1; i <= n; i++)
            {
                a = a + i * i;
            }
            Console.WriteLine("TONG CUA 1^2+2^2+.....+{0}^2 la {1}",n,a);
            Console.ReadKey();
        }
    }
}

