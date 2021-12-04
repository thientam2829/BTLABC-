// See https://aka.ms/new-console-template for more information
using System;

namespace BT7
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("MOI NHAP SO n :");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 0, i = 1;
            for (i = 1; i <= n; i++)
            {
                a = a + i / (i + 1);
            }
            Console.WriteLine("TONG LA {0}",a);
        }
    }
}

