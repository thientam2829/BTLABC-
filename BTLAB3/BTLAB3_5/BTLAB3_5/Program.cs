// See https://aka.ms/new-console-template for more information
using System;

namespace BTLAB3_5
{
    class Program
    {
        public static void Main(string[]args)
        {
                Console.WriteLine("NHAP SO KM: ");
                String km = Console.ReadLine();
                int Km = Convert.ToInt32(km);
                int Gia1 = 15000, Gia2 = 13500, Gia3 = 11000;
                if (Km < 1)
                {
                    int S = Gia1;
                    Console.WriteLine("So Tien Phai Tra La : {0}", S + " Vnđ");
                }
                else if (1 <= Km & Km < 5)
                {
                    int S = Gia1 + (Km - 1) * Gia2;
                    Console.WriteLine("So Tien Phai Tra La: {0}", S + " Vnđ");
                }
                else if (5 <= Km & Km < 120)
                {
                    int S = Gia1 + 3 * Gia2 + (Km - 4) * Gia3;
                    Console.WriteLine("So Tien Phai Tra La : {0}", S + " Vnđ");
                }
                else if (Km >= 120)
                {
                    int S1 = Gia1 + 3 * Gia2 + (Km - 4) * Gia3;
                    int S2 = S1 - S1 * (20 / 100);
                    Console.WriteLine("So Tien Phai Tra La : {0}", S2 + " Vnđ");
                }
                Console.ReadLine();
            }
        }
    }


