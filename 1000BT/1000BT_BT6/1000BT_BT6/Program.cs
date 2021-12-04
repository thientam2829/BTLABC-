// See https://aka.ms/new-console-template for more information
using System;

namespace BT6
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("MOI NHAP SO n :");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 0;
            int i = 1;
            while (i <= n) 
            {
                a = a + 1.0 / (i * (i + 1));

                i++;
            }
            Console.WriteLine("Tong 1/1*2 + 1/2*3 +.....+1/{0} la {1}",n,a);    
            Console.ReadKey();
                
        }
    }
}