// See https://aka.ms/new-console-template for more information
using System;

namespace BT8
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
                a = a +(2 * i + 1) / (2 * i + 2);
            }
            Console.WriteLine("TONG LA {0}",a);   
            Console.ReadKey();
        }
    }
}