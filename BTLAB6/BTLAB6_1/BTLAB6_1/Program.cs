// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NHAP a : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("NHAP b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c :");
            float c = float.Parse(Console.ReadLine());
            giaiPTBac2(a, b, c);

            static void giaiPTBac2(float a, float b, float c)
            {
                float delta = b * b - 4 * a * c;
                float x1;
                float x2;
                if (delta > 0)
                {
                    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Phương trình có 2 nghiệm là: " + "x1 = " + x1 + " và x2 = " + x2);

                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.WriteLine("Phương trình có nghiệm kép: " + "x1 = x2 = " + x1);

                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
                return;
            }
        }
    }
}
