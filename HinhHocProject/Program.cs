using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHocProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape hcn = new HinhChuNhat(3,5);
            //hcn.Chuvi();
            //hcn.DienTich();

            Shape ht = new HinhTron(4);
            ht.Chuvi();
            ht.DienTich();
            ht.ToString();
            Console.ReadLine();

            
        }
    }
}
