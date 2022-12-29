using System;
using System.Diagnostics;
using System.IO;

namespace sangEratosthenes
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch tEra = new Stopwatch();
			Stopwatch tSun = new Stopwatch();
			/*int n;
			n = int.Parse(Console.ReadLine());*/
			string[] inp = File.ReadAllLines("dauVao.txt");

			for (int f = 0; f < inp.Length; f++)
			{
				//Thời gian bắt đầu thực hiện giải thuật Sàng Eratosthenes
				tEra.Start();

				//Khởi tạo mảng kiểm tra ban đầu đều là số nguyên tố
				bool[] a = new bool[int.Parse(inp[f]) + 1];
				for (int i = 2; i <= int.Parse(inp[f]); i++)
					a[i] = true;

				//Tìm số nguyên tố
				for (int i = 2; i < Math.Sqrt(int.Parse(inp[f])); i++)
				{
					if (a[i] == true)
					{
						int j = (int)2 * i; ;
						while (j <= int.Parse(inp[f]))
						{
							a[j] = false;
							j = j + i;
						}
					}
				}

				Console.WriteLine(f + ". ");

				//In ra các số nguyên tố
				Console.WriteLine("Eratosthenes: ");
				for (int i = 2; i <= int.Parse(inp[f]); i++)
					if (a[i] == true)
						Console.Write("{0} ", i);

				// Thời gian kết thúc
				tEra.Stop();

				//Tổng thời gian thực hiện 
				string t1 = string.Format("\nTime of Eratosthenes: {0} ticks = {1}s", tEra.ElapsedTicks, Math.Round(1.0 * (tEra.ElapsedTicks * 0.00000001), 4));
				File.WriteAllText("dauRa.txt",t1);

				//In ra file
				string o1 = File.ReadAllText("dauRa.txt");
				Console.WriteLine(o1);

				tSun.Start();

				//Khởi tạo mảng ban đầu đều là số nguyên tố
				bool[] b = new bool[int.Parse(inp[f]) + 1];
				for (int i = 1; i <= int.Parse(inp[f]); i++)
					a[i] = true;

				for (int i = 1; i < (int.Parse(inp[f]) - 2) / 2; i++)
					for (int j = 2; (i + j + 2 * i * j) <= int.Parse(inp[f]); j++)
						a[i + j + 2 * i * j] = false;

				Console.WriteLine("Sundaram: ");

				if (int.Parse(inp[f]) > 2)
					Console.Write(2 + " ");

				for (int i = 1; i < (int.Parse(inp[f]) - 2) / 2; i++)
					if (a[i] == true)
						Console.Write(2 * i + 1 + " ");

				tSun.Stop();

				//Tổng thời gian thực hiện 
				string t2 = string.Format("\nTime of Sundaram: {0} ticks = {1}s", tSun.ElapsedTicks, Math.Round(1.0 * (tSun.ElapsedTicks * 0.00000001), 4));
				File.WriteAllText("dauRa.txt", t2);

				//In ra file
				string o2 = File.ReadAllText("dauRa.txt");
				Console.WriteLine(o2);
			}
			Console.ReadKey();
		}
	}
}
