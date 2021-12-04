// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_6
{
    class Program
    {
        static bool check (int a)
        {
            int sum = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                    sum += i;
            }

                if (sum == a) 
                return true;
                return false;
        }
        static void Main()
        {
            Console.WriteLine("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (check(n))
            {
                Console.WriteLine("So da nhap la so hoan hao ");

            }
            else
            {
                Console.WriteLine("So da nhap khong phai la so hoan hao");
            }
            return;
        }
       
        
    }
}




