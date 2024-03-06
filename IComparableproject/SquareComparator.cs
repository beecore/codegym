using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableproject
{
    public class SquareComparator : IComparer<Square>
    {
        public int Compare(Square c1, Square c2)
        {
            if (c1.getSide() > c2.getSide()) return 1;
            else if (c1.getSide() < c2.getSide()) return -1;
            else return 0;
        }
    }
}
