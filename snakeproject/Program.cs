using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWith = 15;
            int minHeight = 15;
            DrawGame(maxWith, minHeight);

            Console.BackgroundColor = ConsoleColor.Black;
            int middleX = 2;
            int middleY = 2;
            Console.SetCursorPosition(middleX, middleY);
            Console.Write("O");
            int currentX = middleX;
            int currentY = middleY;

           // Console.Write(" ");
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentY--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        currentX--;
                        break;
                    case ConsoleKey.RightArrow:
                        currentX++;
                        break;

                }
                
                Console.SetCursorPosition(currentX, currentY);
                Console.Write("O");
                if (currentX == 0 || currentX >= maxWith || currentY >= minHeight || currentY == 0)
                {
                    break;
                }

            }

            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
        static void DrawGame(int maxWith, int minHeight)
        {
            for (int i=0;i<=maxWith;i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("#");

                Console.SetCursorPosition(i,maxWith);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("#");


            }

            for (int i = 0; i < minHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("#");

                Console.SetCursorPosition(minHeight, i);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("#");


            }

        }
    }


}
