// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB3_4
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("KIEM TRA SO CO PHAI LA CANH CUA TAM GIAC \n ");

			Console.WriteLine("NHAP SO THU 1: ");
			int a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("NHAP SO THU 2: ");
			int b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("NHAP SO THU 3: ");
			int c = Convert.ToInt32(Console.ReadLine());

			if ((a * a < b * b + c * c) && (b * b < a * a + c * c) && (c * c < b * b + a * a))
			{
				Console.WriteLine("DAY LA BA  CANH CUA TAM GIAC ");

			}	
			else 
				Console.WriteLine("DAY KHONG PHAI LA BA CANH CUA TAM GIAC ");
			Console.ReadKey();
		}
	}
}
