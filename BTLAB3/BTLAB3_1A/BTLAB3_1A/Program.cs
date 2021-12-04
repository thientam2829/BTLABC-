// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB3_1A
{
    class Program
    {
        public static void Main()
        {
            float C = 0;
            Console.WriteLine("INPUT A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INPUT B :");
            int B = Convert.ToInt32(Console.ReadLine());
            if (B == 0)
                Console.WriteLine("ERROR : DEVIDE BY ZERO");
            else
                C = (float) A / B;
                Console.WriteLine("RESULT C : " + C);
            Console.ReadKey();







        }
    }
}
