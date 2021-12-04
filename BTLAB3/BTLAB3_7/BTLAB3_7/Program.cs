// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB3_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("MENU ");
            Console.WriteLine("===================================");
            Console.WriteLine("1.CF");
            Console.WriteLine("2.C");
            Console.WriteLine("3.HDJ");
            Console.WriteLine("4.DREAMWEAVERS");
            Console.WriteLine("5.RDBMS");
            Console.WriteLine("6.LEARN JAVA FOR EXAMPLE");
            Console.WriteLine("===================================");
            Console.WriteLine("CHON : ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1: Console.WriteLine("BAN CHON CF");
                    break;
                case 2: Console.WriteLine("BAN CHON C");
                    break;
                case 3: Console.WriteLine("BAN CHON HDJ");
                    break;
                case 4: Console.WriteLine("BAN CHON DREAMWEAVERS");
                    break;
                case 5: Console.WriteLine("BAN CHON RDBMS");
                    break;
                case 6: Console.WriteLine("BAN CHON LEARN JAVA FOR EXAMPLE");
                    break;
                    default: Console.WriteLine("BAN VUI LONG CHON LAI");
                    break;
            }    
                
          

           
               









        }
    }
}
