using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            // Bước 1: Khai báo và gán giá trị cho chuỗi
            string str = "Chuỗi ví dụ để đếm số lần xuất hiện của ký tự";

            // Bước 2: Nhập giá trị ký tự từ bàn phím
            Console.WriteLine("Nhập vào một ký tự để đếm số lần xuất hiện trong chuỗi:");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Xuống dòng

            // Bước 3: Khai báo và khởi tạo biến đếm
            int count = 0;

            // Bước 4: Duyệt từng ký tự trong chuỗi và đếm số lần xuất hiện của ký tự đã nhập
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }

            // Bước 5: In ra số lần xuất hiện của ký tự đã nhập
            Console.WriteLine($"Số lần xuất hiện của ký tự '{character}' trong chuỗi là: {count}");

        }
    }
}
