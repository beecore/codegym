using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    abstract class Player
    {
        protected char character;
        protected char Character { get { return character; } }
        public abstract void MakeMove(Board board);
    }
}
