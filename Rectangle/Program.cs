using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input width:");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Input height:");
            double height = Double.Parse(Console.ReadLine());
            Rec rec = new Rec(width, height);

            Console.WriteLine("Your Rectangle " + rec.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rec.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rec.GetArea());
            Console.ReadLine();
        }
    }
}
