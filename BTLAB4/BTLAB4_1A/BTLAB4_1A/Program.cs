// See https://aka.ms/new-console-template for more information
using System;

namespace BTLA4_1A
{
    class Program
    {
        public static void Main()
        {

            int a;

            Console.Write("Nhap mot so : ");
            a = Convert.ToInt32(Console.ReadLine());
            
                for (int i = 1; i <= a; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine("Cac so chan : " + i);
                }

         


            Console.ReadKey();
        }
    }
}
