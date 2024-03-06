using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableproject
{
    public class RectComparator : IComparer<Rectangle>
    {
        public int Compare(Rectangle c1, Rectangle c2)
        {
            if (c1.getArea() > c2.getArea() ) return 1;
            else if (c1.getArea() < c2.getArea()) return -1;
            else return 0;
        }
    }
}
