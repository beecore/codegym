using System;
using System.Text;

namespace Lession2
{
     class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine("Câu hỏi điều kiện");

            #region DIEUKIEN

            //int a = 19, b = 3;

            //if (a % b == 0)
            //{
            //    Console.WriteLine("a {0} chia hết cho b {1}", a, b);
            //}
            //else
            //{
            //    Console.WriteLine("a {0} không chia hết cho b {1}", a, b);
            //}

            #endregion DIEUKIEN

            #region Giai PT AX+B=C

            int soA = 0, soB = 0, soC = 0;

            Console.Write("Nhập số a: ");
            string aString = Console.ReadLine();
            soA = int.Parse(aString);

            Console.Write("Nhập số b: ");
            string bString = Console.ReadLine();
            soB = int.Parse(bString);

            Console.Write("Nhập số c: ");
            string cString = Console.ReadLine();
            soC = int.Parse(cString);



            Console.WriteLine("Giải phương trình {0}x+{1}={2}", soA, soB, soC);

            if (soA == 0 && soB != soC)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (soA == 0 && soB == soC)
            {
                Console.WriteLine("Phương trình vô số nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình có nghiệm x = {0} ",((soC - soB) /(float)soA));
            }

            #endregion Giai PT AX+B=C

            Console.ReadKey();
        }
    }
}