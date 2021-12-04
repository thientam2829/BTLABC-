// See https://aka.ms/new-console-template for more information
using System;

namespace BT3
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("MOI NHAP SO n :");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 0;
            int i = 1;
            for (i = 1; i <= n; i++)
            {
                a = a + 1.0 / i;
            }
            Console.WriteLine("Tong 1+1/2+1/3+.....1/{0} la {1}",n,a);
            Console.ReadKey();

        }
    }
}
