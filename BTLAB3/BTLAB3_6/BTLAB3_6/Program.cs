// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB3_6

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KIEM TRA KY TU ALPHABET");
            Console.WriteLine("MOI BAN NHAP KY TU : ");
            char a = Convert.ToChar(Console.ReadLine());
            if (a >= 'a' && a <= 'z')
                Console.WriteLine("KY TU VUA NHAP THUOC BANG CHU CAI ALPHABET");
            else if (a >= 'A' && a <= 'Z')
                Console.WriteLine("KY TU VUA NHAP THUOC BANG CHU CAI ALPHABET ");
            else
                Console.WriteLine("KY TU BAN VUA NHAP KHONG THUOC BANG CHU CAI");
            switch (a)
            {
                case 'a':                  
                case 'A':                    
                case 'e':                    
                case 'E':
                case 'i':
                case 'o':
                case 'u':
                case 'U':
                case 'I':
                case 'O':
                    Console.WriteLine("KY TU VUA NHAP LA NGUYEN AM ");
                    break;
                default:
                    Console.WriteLine("KY TU VUA NHAP LA PHU AM ");
                    break ;


            }


        }
    }
}





       