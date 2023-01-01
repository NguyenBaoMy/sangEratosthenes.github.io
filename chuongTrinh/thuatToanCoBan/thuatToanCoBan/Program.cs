using System;

namespace thuatToanCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhập n từ bàn phím
            int n = int.Parse(Console.ReadLine());

            //lưu trạng thái của giá trị vừa nhập
            bool soNguyenTo = true;

            //những số nhỏ hơn 2 không phải là số nguyên tố
            if (n < 2)
            {
                soNguyenTo = false;
            }

            //nếu n chia hết cho một trong những số trong đoạn từ [2;n-1] thì không phải là số nguyên tố
            for (int i = 2; i <= n - 1; i++)
                if (n % i == 0)
                {
                    soNguyenTo = false;
                    break;
                }

            //in ra thông báo
            if (soNguyenTo)
                Console.Write($"{n} la so nguyen to.");
            else
                Console.Write($"{n} khong phai so nguyen to.");

            Console.ReadKey();
        }
    }
}
