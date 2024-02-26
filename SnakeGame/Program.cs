using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeGame
{
    class Program
    {

        static int wallWidth = 20;
        static int wallHeight =20;
        static Random random = new Random();
        static int score = 0;
        static bool gameOver = false;
        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
        //sử dụng hàng đợi
        static Queue<Position> snake = new Queue<Position>();
        static Position food;
        static Direction direction = Direction.Right;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
          
            Initialize();
           
            while (!gameOver)
            {

                Draw();
                Input();
                Logic();
            }
              
            Console.SetCursorPosition(wallWidth / 2-4 , wallHeight / 2);
            Console.Write("Game Over!");
            Console.ReadLine();
        }
        static void Input()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.Right;
                    break;
            }
        
    }
        static void Logic()
        {
            var head = snake.Last();
            Position newHead;

            switch (direction)
            {
                case Direction.Up:
                    newHead = new Position(head.X, head.Y - 1);
                    break;
                case Direction.Down:
                    newHead = new Position(head.X, head.Y + 1);
                    break;
                case Direction.Left:
                    newHead = new Position(head.X - 1, head.Y);
                    break;
                case Direction.Right:
                    newHead = new Position(head.X + 1, head.Y);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (newHead.X < 0 || newHead.X >= wallWidth || newHead.Y < 0 || newHead.Y >= wallHeight || snake.Contains(newHead))
            {
                gameOver = true;
                return;
            }

            snake.Enqueue(newHead);
            if (newHead.X == food.X && newHead.Y == food.Y)
            {
                score++;
                food = GenerateFoodPosition();
            }
            else
            {
              
                snake.Dequeue();

            }
        }
        //khởi tạo giá trị
        static void Initialize()
        {
            snake.Clear();
            score = 0;
            gameOver = false;

            int x = wallWidth / 2;
            int y = wallHeight / 2;

            Position position = new Position();
            position.X = x;
            position.Y = y;
            snake.Enqueue(position);

            food = GenerateFoodPosition();
        }
        //Tạo ví tri ngẫu nhiên
        static Position GenerateFoodPosition()
        {
            int x = random.Next(1,wallWidth);
            int y = random.Next(1,wallHeight);
            Position position = new Position();
            position.X = x;
            position.Y = y;
            return position;
        }
        static void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
          
            //vẽ màn hình
            for (int i = 0; i <= wallWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");

                Console.SetCursorPosition(i, wallWidth);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");
            }

            for (int i = 0; i < wallHeight; i++)
            {
                Console.SetCursorPosition(0,i);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");

                Console.SetCursorPosition(wallHeight, i);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");

            }

            //Vẽ mồi
            Console.SetCursorPosition(food.X, food.Y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("@");

            //Vẽ rắn
            foreach (var position in snake)
            {
                Console.SetCursorPosition(position.X, position.Y);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("O");
            }

            Console.SetCursorPosition(0, wallHeight + 2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"Score: {score}");

        }

    }
}
