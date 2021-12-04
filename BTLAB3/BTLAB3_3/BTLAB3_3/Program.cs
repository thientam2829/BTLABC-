// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB3_3

{
    class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("TIM MIN MAX \n ");

            Console.WriteLine("NHAP SO THU 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NHAP SO THU 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NHAP SO THU 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NHAP SO THU 4: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int max = a;


            if (max < b)
            {
                max = b;

            }
            if (max < c)
            {
                max = c;

            }

            if (max < d)
            {
                max = (d);

            }
            Console.WriteLine("MAX = {0} ", max);

            int min = a;
            min = a < c ? a < b ? a < d ? a : c : b : d;


            Console.WriteLine("MIN = {0} ", min);

            Console.ReadKey();
        }
    }
}
