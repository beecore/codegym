using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe Game");
            Game game = null;
            while (true)
            {
                Console.WriteLine("\n1. New Game\n2. Load Game\n3. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        game = new Game();
                        game.StartGame();
                        game.SaveGame();
                        break;
                    case 2:
                        game = Game.LoadGame();
                        if (game != null)
                        {
                            game.StartGame();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}
