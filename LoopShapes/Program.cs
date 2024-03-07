using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopShapes
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        PrintRectangle();
                        break;
                    case 2:
                        PrintSquareTriangleBottomLeft();
                        break;
                    case 3:
                        PrintSquareTriangleTopLeft();
                        break;
                    case 4:
                        PrintIsoscelesTriangle();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 5);
        }

        static int Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (The corner is square at bottom-left)");
            Console.WriteLine("3. Print the square triangle (The corner is square at top-left)");
            Console.WriteLine("4. Print the isosceles triangle");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintRectangle()
        {
            Console.WriteLine("Print the rectangle");
            int width, height;
            Console.Write("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSquareTriangleBottomLeft()
        {
            Console.WriteLine("Print the square triangle (The corner is square at bottom-left)");
            int n;
            Console.Write("Enter the number of lines: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSquareTriangleTopLeft()
        {
            Console.WriteLine("Print the square triangle (The corner is square at top-left)");
            int n;
            Console.Write("Enter the number of lines: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintIsoscelesTriangle()
        {
            Console.WriteLine("Print the isosceles triangle");
            int n;
            Console.Write("Enter the number of lines: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}
