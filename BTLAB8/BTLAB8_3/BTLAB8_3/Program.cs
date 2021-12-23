// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB8_3
{
    class Program
    {
        public static void Main()
        {
            string chuoi;
            string dem = string.Empty;

            Console.WriteLine("NHAP VAO CHUOI : ");
            chuoi = Console.ReadLine();
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                dem += chuoi[i];
            }

            if (chuoi == dem)
            {
                Console.WriteLine("{0} la chuoi PALINDROME.",chuoi);
            }
            else
            {
                Console.WriteLine("{0} khong phai la chuoi PALINDORME. ",chuoi);
            }
            Console.ReadKey();
        }
    }
}


