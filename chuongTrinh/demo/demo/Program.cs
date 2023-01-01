using System;
using System.Diagnostics;
using System.IO;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
			Stopwatch tEra = new Stopwatch();
			Stopwatch tSun = new Stopwatch();
			
			string[] inp = File.ReadAllLines("dauVao.txt");

			for (int f = 0; f < inp.Length; f++)
			{
				tEra.Start();

				bool[] a = new bool[int.Parse(inp[f]) + 1];

				for (int i = 2; i <= int.Parse(inp[f]); i++)
					a[i] = true;

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

				Console.WriteLine("Eratosthenes: ");

				for (int i = 2; i <= int.Parse(inp[f]); i++)
					if (a[i] == true)
						Console.Write("{0} ", i);

				tEra.Stop();

				string t1 = string.Format("\nTotal time of Eratosthenes {0}: {1} ticks = {2}s", f, tEra.ElapsedTicks, Math.Round(1.0 * (tEra.ElapsedTicks * Math.Pow(10,-8)), 4));
				File.AppendAllText("dauRa.txt", t1);

				tSun.Start();

				bool[] b = new bool[int.Parse(inp[f]) + 1];

				for (int i = 1; i <= int.Parse(inp[f]); i++)
					a[i] = true;

				for (int i = 1; i < (int.Parse(inp[f]) - 2) / 2; i++)
					for (int j = 2; (i + j + 2 * i * j) <= int.Parse(inp[f]); j++)
						a[i + j + 2 * i * j] = false;

				Console.WriteLine("\nSundaram: ");

				if (int.Parse(inp[f]) > 2)
					Console.Write(2 + " ");

				for (int i = 1; i < (int.Parse(inp[f]) - 2) / 2; i++)
					if (a[i] == true)
						Console.Write(2 * i + 1 + " ");

				tSun.Stop();

				string t2 = string.Format("\nTotal time of Sundaram {0}: {1} ticks = {2}s", f, tSun.ElapsedTicks, Math.Round(1.0 * (tSun.ElapsedTicks * Math.Pow(10,-8)), 4));
				File.AppendAllText("dauRa.txt", t2);

				string oup = File.ReadAllText("dauRa.txt");
				Console.WriteLine(oup);
			}
			Console.ReadKey();
		}
    }
}
