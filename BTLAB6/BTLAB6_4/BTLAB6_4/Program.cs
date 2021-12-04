// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_4
{
    class Program
    {
        static double Quydiem(double a)
        {
            if (a <= 10 && a >= 8.5)
            {
                Console.WriteLine ("A");

            }
            else if (a <= 8.4 && a >= 7)
            {
                Console.WriteLine("B");
            }
            else if (a <= 6.9 && a >= 5.5)
            {
                Console.WriteLine("C");
            }
            else if (a <= 5.4 && a >= 4)
            {
                Console.WriteLine("D");
            }
            else if (a <= 3.9 && a >= 0)
            {
               Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("E");
            }
            return a;
        }
        static void Main()
        {
          
            Console.WriteLine("NHAP VAO GIA TRI DIEM SO : ");
            double n = Convert.ToDouble(Console.ReadLine());
            Quydiem(n);
            
        }


    }
}
