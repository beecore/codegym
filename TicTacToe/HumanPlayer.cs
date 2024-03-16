using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    [Serializable]
    class HumanPlayer : Player
    {
        public HumanPlayer(char marker)
        {
            this.marker = marker;
        }

        public override void MakeMove(Board board)
        {
            int row, col;
            do
            {
                Console.Write("Enter row: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter column: ");
                col = Convert.ToInt32(Console.ReadLine());
            } while (!board.PlaceMarker(row, col, marker));
        }
    }
}
