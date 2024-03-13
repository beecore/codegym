using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(char character)
        {
            this.character = character;
        }

        public override void MakeMove(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
