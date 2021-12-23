
using System;

namespace BTLAB8_1
{
    class Program
    {
        public static void Main()
        {
            String chuoi;
            int count = 0;

            Console.WriteLine("Nhap vao Chuoi ");
            chuoi = Console.ReadLine();
            Console.WriteLine("Nhap vao Ky tu");
            char kyTu = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < chuoi.Length; i++)
            {

                if (chuoi[i] == kyTu)

                {
                    count++;
                }


            }
            Console.WriteLine("So lan xuat hien cua ki tu " + kyTu + " trong chuoi " + chuoi + " = " + count);
        }
        
    }
}
