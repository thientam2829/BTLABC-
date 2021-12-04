// See https://aka.ms/new-console-template for more information
using System;
namespace BT9
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("MOI NHAP SO n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1, i = 1;
            for (i = 1; i <= n; i++)
            {
                a = a * i;
            }    
            Console.WriteLine("TICH 1*2*...*{0}  LA {1} ",n,a);
                      
        }
    }
}

