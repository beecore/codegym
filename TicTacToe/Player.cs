using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    [Serializable]
    abstract class Player
    {
        protected char marker;

        public char Marker { get { return marker; } }

        public abstract void MakeMove(Board board);
    }
}
