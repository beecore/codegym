using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession3_ThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai4();

            Console.ReadKey();
        }

        static void Bai1()
        {
            // Nhập tuổi từ người dùng
            Console.Write("Nhập tuổi của người: ");
            int tuoi = int.Parse(Console.ReadLine());

            // Kiểm tra và đưa ra kết luận về lứa tuổi
            if (tuoi > 0 && tuoi <= 2)
            {
                Console.WriteLine("Trẻ sơ sinh");
            }
            else if (tuoi > 2 && tuoi <= 10)
            {
                Console.WriteLine("Nhi đồng");
            }
            else if (tuoi > 10 && tuoi <= 17 )
            {
                Console.WriteLine("là vị thành niên");
            }
            else if (tuoi > 17 && tuoi <= 39)
            {
                Console.WriteLine("là thanh niên");
            }
            else if (tuoi > 39 && tuoi <= 50)
            {
                Console.WriteLine("là trung niên");
            }
            else
            {
                Console.WriteLine("là cao niên.");
            }
        }

        static void Bai2()
        {

            Console.Write("Nhập năm sản xuất: ");
            int nam = int.Parse(Console.ReadLine());
            if (nam>=15)
            {
                Console.WriteLine("Thay thế");
            }
            else if (nam >= 10 && nam <= 15)
            {
                Console.WriteLine("Bao trì");
            }
            
            else
            {
                Console.WriteLine("Không có đề xuất");
            }
        }
        static void Bai3()
        {
            Console.Write("Nhập điểm trung bình: ");
            int diem = int.Parse(Console.ReadLine());
            if (diem >= 9)
            {
                Console.WriteLine("Học bổng 5000000");
            }
            else if (diem >= 8 && diem<9)
            {
                Console.WriteLine("Học bổng 3000000");
            }
            else if (diem >= 7 && diem < 8)
            {
                Console.WriteLine("Học bổng 1000000");
            }
            else
            {
                Console.WriteLine("Học bổng 0");
            }
        }
        static void Bai4()
        {
            Console.Write("Nhập giờ làm việc: ");
            float gio = float.Parse(Console.ReadLine());
            Console.Write("Nhập lương: ");
            double luong = double.Parse(Console.ReadLine());
            if (gio >= 200)
            {
                Console.WriteLine("Thưởng "+20 * luong / 100);
            }
            else if (gio >= 100 && gio < 200)
            {
                Console.WriteLine("Thưởng " + 10 * luong / 100);
            }
            else
            {
                Console.WriteLine("Thưởng 0");
            }
        }
        static void Bai5()
        {
            Console.Write("Nhập số từ bàn phím: ");
            double number = double.Parse(Console.ReadLine());
            if (number - (int)number==0)
            {
                Console.WriteLine(number +" là số nguyên");
            }else
            {
                Console.WriteLine(number + " không  là số nguyên");
            }

            if (number %2==0)
            {
                Console.WriteLine(number + " là số chẵn");
            }
            else
            {
                Console.WriteLine(number + " là số lẻ");
            }

            if (number % 2 == 0 && number>0)
            {
                Console.WriteLine(number + " là số chẵn dương");
            }
            else
            {
                Console.WriteLine(number + " không phải là số chẵn dương");
            }

            if (number % 2 != 0 && number < 0)
            {
                Console.WriteLine(number + " là số lẻ âm");
            }
            else
            {
                Console.WriteLine(number + " không phải là số lẻ âm");
            }

            int soa =(int) Math.Sqrt(number);
            if (soa*soa==number)
            {
                Console.WriteLine(number + " là số chính phương");
            }
            else
            {
                Console.WriteLine(number + " không phải số chính phương");
            }

        }
    }
}
