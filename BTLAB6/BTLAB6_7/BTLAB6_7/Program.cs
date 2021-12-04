// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB6_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            MENU();
            int i = 0;
            Chon (i);
        }     
        static void MENU()
        {
            Console.WriteLine("+----------------------------------------------------------------+");
            Console.WriteLine("|                            MENU                                |");
            Console.WriteLine("+----------------------------------------------------------------+");
            Console.WriteLine("| 1 . Menu 1                                                     |");
            Console.WriteLine("| 2 . Menu 2                                                     |");
            Console.WriteLine("| 3 . Menu 3                                                     |");
            Console.WriteLine("| 4 . Menu 4                                                     |");
            Console.WriteLine("| 5 . EXIT                                                       |");
            Console.WriteLine("+----------------------------------------------------------------+");
            Console.WriteLine("PLEASE CHOOSE : ");

        }
            
        static void Chon(int i)
        {
            Console.WriteLine("PLEASE CHOOSE : ");
            i=Convert.ToInt32(Console.ReadLine());
            do
            {

                switch (i)
                {
                    case 1:
                        Console.WriteLine("DOING MENU 1 .......");
                        break;
                    case 2:
                        Console.WriteLine("DOING MENU 2........");
                        break;
                    case 3:
                        Console.WriteLine("DOING MENU 3........");
                        break;
                    case 4:
                        Console.WriteLine("DOING MENU 4.........");
                        break;
                    case 5:
                        Console.WriteLine("EXIT.................");
                        break;
                    default:
                        Console.WriteLine("ENTERED CORRECTLY PLEASE REINPUT " +i);
                        break;
                }
            }
            while (i != 5);
        }
       
       
    }
}




