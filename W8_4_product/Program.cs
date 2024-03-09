using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8_4_product
{
    class Program
    {
        static string filePath= "products.csv";
      
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Chọn một tùy chọn:");
                Console.WriteLine("1. Thêm sản phẩm");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm");
                Console.WriteLine("3. Tìm kiếm sản phẩm");
                Console.WriteLine("4. Thoát");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên từ 1 đến 4.");
                    
                }

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        SearchProduct();
                        break;
                    case 4:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Not Valid");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Nhập thông tin sản phẩm:");

            Console.Write("Mã sản phẩm: ");
            string code = Console.ReadLine();

            Console.Write("Tên sản phẩm: ");
            string name = Console.ReadLine();

            Console.Write("Hãng sản xuất: ");
            string manufacturer = Console.ReadLine();

            Console.Write("Giá: ");
            decimal price;


            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Vui lòng nhập một số.");
            }

            Console.Write("Mô tả: ");
            string description = Console.ReadLine();

            
            // Ghi thông tin sản phẩm vào tệp
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{code},{name},{manufacturer},{price},{description}");
            }

            Console.WriteLine("Sản phẩm đã được thêm thành công.");
        }

        static void DisplayProducts()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Không có sản phẩm nào được lưu.");
                return;
            }
            StreamReader reader = new StreamReader(filePath);
            // Đọc và hiển thị thông tin sản phẩm từ tệp
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(',');
                foreach (var value in values)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }

        static void SearchProduct()
        {
            Console.Write("Nhập mã sản phẩm cần tìm kiếm: ");
            string searchCode = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Không có sản phẩm nào được lưu.");
                return;
            }

            StreamReader reader = new StreamReader(filePath);
            // Đọc và hiển thị thông tin sản phẩm từ tệp
            // Tìm kiếm sản phẩm theo mã sản phẩm
            bool found = false;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(',');

                if (values[0] == searchCode)
                {
                    Console.WriteLine("Thông tin sản phẩm:");
                    Console.WriteLine(line);
                    found = true;
                    break;
                }
                Console.WriteLine();
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sản phẩm với mã sản phẩm đã nhập.");
            }
        }
    }
}
