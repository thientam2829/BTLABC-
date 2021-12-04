// See https://aka.ms/new-console-template for more information
using System;

public class BTLAB4_6
{
    static public void Main()
    {

        int a = 0, b = 1, c, i, n;
        Console.Write("In day Fibonacci :\n");
        Console.Write("-------------------------");
        Console.Write("\n\n");

        Console.Write("Nhap so can hien thi: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Day Fibonacci gom {0} so la: \n", n);
        Console.Write("{0}    {1}", a, b);

        for (i = 3; i <= n; i++)
        {
            c = a + b;
            Console.Write("  {0}  ", c);
            a = b;
            b = c;
        }
        Console.Write("\n");

        Console.ReadKey();
    }
}

