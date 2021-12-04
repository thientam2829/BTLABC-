// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_5
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Nhap n : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (checknumber(n))
            {
                Console.WriteLine(n + " la so nguyen to ");
            }
            else
            {
                Console.WriteLine(n + " khong phai la so nguyen to");
            }
            int[] arr = new int[100];
            int b, a;
            a = 10;
            Console.Write("Nhap {0} phan tu :\n", a);
            for (b = 0; b < n; b++)
            {
                Console.Write("Phan tu {0}: ", b);
                arr[b] = Convert.ToInt32(Console.ReadLine());
            }
                checknumber(arr[b]);
                if (checknumber(arr[b]))
                {
                    Console.WriteLine(arr[b] + " LA SO NGUYEN TO ");
                }
            
        }
        static bool checknumber(int n)
        {
            
            if (n < 2)
            {
                return false;
            }
            int squareRoot = (int)Math.Sqrt(n);
            for (int i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

