// See https://aka.ms/new-console-template for more information
using System;
namespace BT11
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("MOI NHAP SO n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double a = 0, b = 1;
            for (i = 1; i <= n; i++)
            {
                b = b * i;
                a = a + b;
            }
            Console.WriteLine("TONG CUA BIEU THUC TREN LA : {0} ", a);
        }
    }
}