using System;

namespace ShapeProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Square square = new Square();

            Console.WriteLine(square);

            square = new Square(2.3);

            Console.WriteLine(square);

            square = new Square(5.8, "red", true);

            Console.WriteLine(square);
        }
    }
}