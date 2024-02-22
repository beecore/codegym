using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5_CauTrucLap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Tinh tong từ 1-->n
            //Console.Write("nhap n:");
            //int n = int.Parse(Console.ReadLine());
            //int i=0, sum = 0;
            //for (i = 1; i <= n; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("tong " + sum);
            #endregion

            #region uoc so
            //Console.Write("Nhập n:");
            //int n = int.Parse(Console.ReadLine());
            //String kq = "";
            //for(int i = 1; i <= n/2; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        kq += i+" ";
            //    }
            //}
            //Console.WriteLine("Ước số của {0} là: {1} ",n,kq);
            #endregion

            #region Bảng cửu chương
            Console.Write("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Bảng cửu chương " + n);
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ",n , i , i*n );
            }

            #endregion
            Console.ReadKey();
        }
    }
}
