using System;

namespace Lession6_Mang
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] mang = { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };

            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Nhập vị trí cần chèn ");
            int pos = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập gia tri cần chèn ");
            int value = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            if (pos > mang.Length - 1)
            {
                Console.WriteLine("Vượt giới hạn của mảng");
                return;
            }

            for (int i = mang.Length - 1; i > pos; i--)
            {
                mang[i] = mang[i - 1];
            }
            mang[pos] = value;

            Console.WriteLine();
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.ReadKey();
        }
    }
}