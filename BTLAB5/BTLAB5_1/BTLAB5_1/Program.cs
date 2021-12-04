// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB5_1
{
    class Program
    {
        public static void Main()
        {
            int[] arr = new int[] { 56, 2, 3, 4, 5, 6, 7, 8,10,25,11 };
            int i = 0;
            while(i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i+=2;
            }                               
             
        }
    }
}
                                              