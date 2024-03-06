using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(1);
            shapes[1] = new Rectangle(3,4);
            shapes[2] = new Square(4);

            Random random = new Random();
            double number = random.Next(1, 100);

            Circle circle = shapes[0] as Circle;
            Rectangle rectangle = shapes[1] as Rectangle;
            Square square = shapes[2] as Square;

            Console.WriteLine("---- Before");
            Console.WriteLine(circle.getArea());
            Console.WriteLine(rectangle.getArea());
            Console.WriteLine(square.getArea());
            Console.WriteLine("----After");
            circle.Resize(number);      
            rectangle.Resize(number); 
            square.Resize(number);
            Console.WriteLine(circle.getArea());
            Console.WriteLine(rectangle.getArea());
            Console.WriteLine(square.getArea());




        }
    }
}
