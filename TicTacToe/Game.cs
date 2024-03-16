using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TicTacToe
{
    [Serializable]
    class Game
    {
        private Board board;
        private Player player1, player2;

        public Game()
        {
            board = new Board();
            player1 = new HumanPlayer('X');
            player2 = new ComputerPlayer('O');
        }

        public void StartGame()
        {
            int turn = 0;
            char winner = '-';
            board.InitializeBoard();
            while (winner == '-' && !board.IsBoardFull())
            {
                board.DrawBoard();
                if (turn % 2 == 0)
                {
                    Console.WriteLine("Player 1's turn (X):");
                    player1.MakeMove(board);
                }
                else
                {
                    Console.WriteLine("Player 2's turn (O):");
                    player2.MakeMove(board);
                }
                winner = board.CheckWinner();
                turn++;
            }
            board.DrawBoard();
            if (winner == '-')
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("Player " + winner + " wins!");
            }
        }

        public void SaveGame()
        {
            try
            {
                FileStream fs = new FileStream("game.csv", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
                fs.Close();
                Console.WriteLine("Game saved successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error saving game: " + e.Message);
            }
        }

        public static Game LoadGame()
        {
            try
            {
                FileStream fs = new FileStream("game.csv", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Game game = (Game)formatter.Deserialize(fs);
                fs.Close();
                Console.WriteLine("Game loaded successfully.");
                return game;
            }
            catch (IOException e)
            {
                Console.WriteLine("Error loading game: " + e.Message);
                return null;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Error loading game: " + e.Message);
                return null;
            }
        }
    }
}
