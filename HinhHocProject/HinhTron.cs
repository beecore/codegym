using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHocProject
{
    public class HinhTron : Shape
    {
        private double banKinh;
        private const double RADIUS = 3.14;
        public HinhTron(double banKinh) :base()
        {
            this.banKinh = banKinh;
        }
        public double BanKinh
        {

            get { return banKinh; }
            set
            {
                banKinh = value;
            }
        }

        public override void Chuvi()
        {
            Console.WriteLine("chu vi hinh tron " + (banKinh*2*RADIUS));
        }

        public override void DienTich()
        {
            Console.WriteLine("dien tich hinh tron " + (banKinh*banKinh  * RADIUS));
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
