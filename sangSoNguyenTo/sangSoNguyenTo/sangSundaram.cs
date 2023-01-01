using System;
using System.Diagnostics;

namespace sangSoNguyenTo
{
    class sangSundaram
    {
        static void Main(string[] args)
        {
            //tạo mới một đối tượng Stopwatch để đo thời gian thực hiện giải thuật
            Stopwatch tSun = new Stopwatch();
            tSun.Start();

            //nhập n số cần kiểm tra từ bàn phím
            int n = int.Parse(Console.ReadLine());
            
            //tạo mảng bool a[] lưu giá trị các phần từ
            bool[] a = new bool[n + 1];

            //mảng a[] gồm những giá trị không phải số nguyên tố
            for (int i = 1; i <= n; i++)
                a[i] = false;

            //kiểm tra điều kiện loại bỏ những số có dạng i + j + 2 * i * j
            for (int i = 1; i < (n - 2) / 2; i++)
                for (int j = i; (i + j + 2 * i * j) <= n; j++)
                    a[i + j + 2 * i * j] = true;

            //2 là số nguyên tố
            if (n > 2)
                Console.Write(2 + " ");

            //in ra dãy các số nguyên tố từ những phần tử có giá trị false của a[i] có dạng 2 * i + 1
            for (int i = 1; i <= (n - 2) / 2; i++)
                if (a[i] == false)
                    Console.Write(2 * i + 1 + " ");

            //Dừng việc đo thời gian
            tSun.Stop();

            //Tổng thời gian thực hiện 
            Console.WriteLine("Total time of Sundaram: {0} ticks = {1}s", tSun.ElapsedTicks, Math.Round(1.0 * (tSun.ElapsedTicks * Math.Pow(10,-8)), 4));

            Console.ReadKey();
        }
    }
}
