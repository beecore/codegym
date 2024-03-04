using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Cylinder
{
   public class Circle
    {
        private double radius;
        private string color;

        public Circle(double radius, string color)

        {
            this.radius = radius;

            this.color = color;
        }

        public double GetRadius()

        {
            return radius;
        }

        public void SetRadius(double radius)

        {
            this.radius = radius;
        }
        public String GetColor()

        {
            return color;
        }

        public void SetColor(String color)

        {
            this.color = color;
        }

        public double Perimeter()
        {
            return this.radius * 2 * Math.PI;
        }
        public double Acreage()
        {
            return this.radius * radius * Math.PI;
        }
        public override String ToString()

        {
            return "A Circle with color " + GetColor() + " and  radius: " +GetRadius();
        }
    }
}
