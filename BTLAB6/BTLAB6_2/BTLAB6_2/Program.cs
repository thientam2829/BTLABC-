// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_2
{
    class Program
    {
        static void Main()
        {
            int n, a;
            Console.Write("Nhap a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KET QUA {0} ^ {1} = {2} ", a, n, Power(a, n));
            int x, m;
            Console.Write("Nhap x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KET QUA {0} ^ {1} = {2} ", x, m , Power(x, m));
        }
        static int Power (int num, int exp)
        {
            int ketqua = 1;
            int i;
            for (i = 1; i <= exp; i++)
                ketqua = ketqua * num;
            return ketqua;
           
        }
        
    }
}