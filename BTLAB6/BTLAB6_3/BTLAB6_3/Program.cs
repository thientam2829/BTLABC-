// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_3
{
    class Program
    {
        
        public static long Fibo(long n1)
        {
            if (n1 <= 2)
                return 1;
            else
                return Fibo(n1 - 1) + Fibo(n1 - 2);
        }

        public static void Main()
        {
            int n;
            Console.Write("Nhap so nguyen n : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n So Fibonacci thu {0} la: {1} \n", n, Fibo(n));
            Console.ReadKey();
        }
    }
}
