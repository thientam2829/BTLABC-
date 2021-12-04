// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB3_2
{
    class Program
    {
        static void Main()
        {

            int a, b, c;
            double delta, x1, x2;
            Console.Write("\n");
            Console.Write("Giai phuong trinh bac hai :\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n\n");

            Console.Write("Nhap gia tri cua a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua c = ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("Phuong Trinh vo nghiem.\n");
            }
            else if (delta == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Nghiem cua phuong trinh la = {0}\n", x1);
            }
            else if (delta > 0)
            {
                Console.Write("Phuong trinh co hai nghiem phan biet\n");

                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.Write("Nghiem thu nhat: x1 = {0}\n", x1);
                Console.Write("Nghiem thu nhat: x2 = {0}\n", x2);
            }
            else
                Console.Write("Phuong trinh vo nghiem\n\n");

            Console.ReadKey();
        }
    }
}
