using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8_Binary
{
    public static class BinaryUyilities
    {
        public static void WriteBinaryFile(string filePath)
        {
            // Mở file để ghi
            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fileStream);
            // Ghi các dữ liệu nhị phân vào file
            writer.Write(123); // ghi một số nguyên
            writer.Write(3.14); // ghi một số thực
            writer.Write("Hello, world!"); // ghi một chuỗi
            writer.Flush();
            fileStream.Close();

            Console.WriteLine("File nhị phân đã được tạo và ghi dữ liệu thành công.");
        }

        public static void ReadBinaryFile(string filePath)
        {
            // Mở file để đọc
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    // Đọc dữ liệu từ file cho đến khi gặp kết thúc file
                    while (fileStream.Position < fileStream.Length)
                    {
                        // Đọc mỗi dòng dữ liệu và hiển thị ra màn hình
                        string line = reader.ReadString();
                        Console.WriteLine(line);
                    }
                }
            }
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryUyilities.WriteBinaryFile("data.txt");
            Console.ReadLine();

        }
    }
}
