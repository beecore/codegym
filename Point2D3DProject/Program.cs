using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D3DProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(2, 4);
            Console.WriteLine(point2D);
            Point3D point3D = new Point3D(12, 4,6);
            Console.WriteLine(point3D);
            Console.ReadLine();
        }
    }
}
