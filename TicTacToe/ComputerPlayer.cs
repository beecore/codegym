using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    [Serializable]
    class ComputerPlayer : Player
    {
        public ComputerPlayer(char marker)
        {
            this.marker = marker;
        }

        public override void MakeMove(Board board)
        {
            Random rand = new Random();
            int row, col;
            do
            {
                row = rand.Next(0, 3);
                col = rand.Next(0, 3);
            } while (!board.PlaceMarker(row, col, marker));
        }
    }
}
