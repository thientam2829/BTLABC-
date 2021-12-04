// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB3_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("NHAP SO THU NHAT : ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("NHAP SO THU HAI : ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("      MENU    ");
			Console.WriteLine("=========================");
			Console.WriteLine("+");
			Console.WriteLine("-");
			Console.WriteLine("*");
			Console.WriteLine("/");
			Console.WriteLine("==========================");
			Console.WriteLine("MOI BAN CHON ");
			string c =Console.ReadLine();
			int d;
			switch(c)
            {
				case "+":
					d = a + b;
					Console.WriteLine("TONG CUA HAI SO LA : "+d);
					break;
				case "-": 
					d = a - b;
					Console.WriteLine("HIEU CUA HAI SO LA :" + d);
					break;
				case"*":
					d = a * b;
					Console.WriteLine("TICH CUA HAI SO LA :" + d);
					break;
				case"/":
					d = a / b;
					Console.WriteLine("THUONG CUA HAI SO LA : " + d);
					break;
					default:Console.WriteLine("BAN DA NHAP SAI PHEP TOAN ");
					break;
            }				
		}
	}
}

