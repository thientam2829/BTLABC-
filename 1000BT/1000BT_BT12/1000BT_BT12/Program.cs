// See https://aka.ms/new-console-template for more information
using System;
namespace BT12
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("MOI NHAP x :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MOI NHAP n");
            int n = Convert.ToInt32(Console.ReadLine());
            float a = 0, b = 1;
            int i = 1;
            for (i = 1; i <= n; i++)
            {
                b = (float) b * x;
                a = (float) a + b;
            }
            Console.WriteLine("TONG LA : {0} ", a);
        }
    }
}