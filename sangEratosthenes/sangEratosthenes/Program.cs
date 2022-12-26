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
			/*int n;
			n = int.Parse(Console.ReadLine());*/
			string[] inp = File.ReadAllLines("dauVao.txt");
			for (int f = 0; f < inp.Length; f++)
			{
				//Thời gian bắt đầu
				tEra.Start();
				//Khởi tạo mảng khởi tạo ban đầu đều là số nguyên tố
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
				/*for (int i = 2; i <= int.Parse(inp[f]); i++)
					if (a[i] == true)
						Console.Write("{0} ", i);*/

				// Thời gian kết thúc
				tEra.Stop();

				//Tổng thời gian thực hiện 
				string t = string.Format("\nTime: {0}", tEra.ElapsedTicks);
				File.WriteAllText("dauRa.txt", t);

				//In ra file
				string o = File.ReadAllText("dauRa.txt");
				Console.WriteLine(o);
			}
			Console.ReadKey();
		}
	}
}
