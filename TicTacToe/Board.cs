using System;

namespace TicTacToe
{
    [Serializable]
    internal class Board
    {
        private char[,] board = new char[3, 3];

        public Board()
        {
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        public void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool PlaceMarker(int row, int col, char marker)
        {
            if (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != '-')
            {
                return false;
            }
            board[row, col] = marker;
            return true;
        }

        public char CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '-')
                {
                    return board[i, 0];
                }
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != '-')
                {
                    return board[0, i];
                }
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '-')
            {
                return board[0, 0];
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '-')
            {
                return board[0, 2];
            }

            return '-';
        }

        public bool IsBoardFull()
        {
            foreach (char marker in board)
            {
                if (marker == '-')
                {
                    return false;
                }
            }
            return true;
        }
    }
}