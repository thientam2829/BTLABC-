// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
namespace BTLAB4_7
{
    class Program
    {
        static int SoNguyento(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            int i;
            int a = (int)Math.Sqrt(n);
            for (i = 2; i <= a; i++)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} so nguyen to dau tien la: \n", n);
            int dem = 0; 
            int i = 2;   
            while (dem < n)
            {
                if (SoNguyento(i) == 1)
                {
                    Console.Write("{0} ", i);
                    dem++;
                }
                i++;
                Console.ReadKey();  
            }
        }
    }
}
