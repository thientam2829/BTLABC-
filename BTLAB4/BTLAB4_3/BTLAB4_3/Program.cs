// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB4_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("NHAP VAO SO m = ");
			int m = int.Parse(Console.ReadLine());
			Console.WriteLine("Nhap vao so n =");
			int n = int.Parse(Console.ReadLine());
			for (int i = m; i <= n; i++)
			{
				if (i % 7 == 0)
				{
					Console.WriteLine("CAC SO CHIA HET CHO 7 :" + i);
				}
			}
		}
	}
}
