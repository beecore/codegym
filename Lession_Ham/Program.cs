using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_Ham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int count = 4;
            //for(int i = 0; i < 4; i++)
            //{
            //    for(int j = 0; j < count; j++)
            //    {
            //        Console.SetCursorPosition(i, j);
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.Write("0");
            //    }
            //    count--;
            //}

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("O");
                }

            }
            int x = 0;
            int y = 3;
            Console.SetCursorPosition(x,y);

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow && y>0)
                {

                    y--;

                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow && x>0)
                {
                    x--;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                Console.SetCursorPosition(x, y);
            }

        }
        static void HamdemSoChan(int[]arr)
        {
            int counNum = 0;
            foreach(int num in arr)
            {
                if (num % 2 == 0)
                {
                    counNum++;

                }
            }
            Console.WriteLine("So lan xuất hien " + counNum);
        }
    }
}
