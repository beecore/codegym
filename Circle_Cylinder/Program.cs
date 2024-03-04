using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(34, "red");
            Console.WriteLine(circle);
            Cylinder cylinder = new Cylinder(34, "red",34.9);
            Console.WriteLine(cylinder);
            Console.ReadLine();
        }
    }
}
