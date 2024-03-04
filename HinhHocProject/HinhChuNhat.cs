using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHocProject
{
    public class HinhChuNhat : Shape
    {
        public HinhChuNhat(double chieuDai, double chieuRong) :base()
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        private double chieuDai;
        private double chieuRong;
        public double ChieuDai
        {

            get { return chieuDai; }
            set {
                chieuDai = value;
            }
        }
        public double ChieuRong
        {

            get { return chieuRong; }
            set
            {
                chieuRong = value;
            }
        }
        public override void Chuvi()
        {
            Console.WriteLine("chu vi hinh chu nhat " + (chieuDai + chieuRong) * 2);
        }

        public override void DienTich()
        {
            Console.WriteLine("dien tich hinh chu nhat  " + (chieuDai * chieuRong));
        }
    }
}
