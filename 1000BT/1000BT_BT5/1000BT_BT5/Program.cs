// See https://aka.ms/new-console-template for more information
using System;

namespace BT5
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
                a = a + 1.0 / (2 * i - 1);
            }
            Console.WriteLine("TONG 1 + 1/3 + 1/5 +.......... +1/{0} LA {1} ",((n*2)-1),a);
            Console.ReadKey();  
        }
    }
}
