using System;
namespace BTLAB4_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int tong = 0,m;
            Console.WriteLine("NHAP so n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                tong = tong + m;
                n = n / 10;
            }
            Console.WriteLine("Tong cac chu so cua so la : " + tong);
            Console.ReadKey();

        }
    }
}

