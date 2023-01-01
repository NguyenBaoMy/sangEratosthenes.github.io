using System;
using System.Diagnostics;

namespace sangSoNguyenTo
{
    class sangEratosthenes
    {
        static void Main(string[] args)
        {
            //tạo mới một đối tượng Stopwatch để đo thời gian thực hiện giải thuật
            Stopwatch tEra = new Stopwatch();
            tEra.Start();

            //nhập n số cần kiểm tra từ bàn phím
            int n = int.Parse(Console.ReadLine());

            //tạo mảng bool a[] lưu giá trị các phần từ
            bool[] a = new bool[n + 1];

            //mảng a[] gồm những giá trị là số nguyên tố
            for (int i = 1; i <= n; i++)
                a[i] = true;

            //kiểm tra điều kiện loại bỏ những số có dạng i + j + 2 * i * j
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (a[i] == true)
                {
                    int j = (int)2 * i; ;
                    while (j <= n)
                    {
                        a[j] = false;
                        j = j + i;
                    }
                }
            }

            //in ra dãy các số nguyên tố từ những phần tử có giá trị true của a[i]
            for (int i = 2; i <= n; i++)
                if (a[i] == true)
                    Console.Write("{0} ", i);

            //Dừng việc đo thời gian
            tEra.Stop();

            //Tổng thời gian thực hiện 
            Console.WriteLine("Total time of Sundaram: {0} ticks = {1}s", tEra.ElapsedTicks, Math.Round(1.0 * (tEra.ElapsedTicks * Math.Pow(10, -8)), 4));

            Console.ReadKey();
        }
    }
}
