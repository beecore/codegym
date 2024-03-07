using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIColorableProject
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Shape[] shapes = new Shape[3];
            shapes[0] = new Square(5);
            shapes[1] = new Circle(3);
            shapes[2] = new Rectangle(2,4);

           
            Square square = shapes[0] as Square;
            Circle circle = shapes[1] as Circle;
            Rectangle rectangle = shapes[2] as Rectangle;

            Console.WriteLine("---- Area");
            Console.WriteLine(circle.getArea());
            Console.WriteLine(rectangle.getArea());
            Console.WriteLine(square.getArea());

            square.HowToColor();
           



            Console.WriteLine();

        }
    }
}
