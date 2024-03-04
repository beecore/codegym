using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Cylinder
{
    public class Cylinder : Circle
    {
        private double height;
        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }
        public double GetHeight()

        {
            return height;
        }

        public void SetHeght(double height)

        {
            this.height = height;
        }
        public double Volume()
        {
            return GetRadius() * GetRadius() * Math.PI*this.height;
        }
        public override String ToString()

        {
            return "A Circle with color of " + GetColor() + " and  radius: " + GetRadius()+ "and "+ GetHeight();
        }
    }
}
