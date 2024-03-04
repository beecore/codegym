using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D3DProject
{
    public class Point2D
    {
        private float x;
        private float y;
        public Point2D() { }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetXY(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            return new float[] { x, y };
        }
        public override String ToString()
        {
            return "X: " + x + " and  Y: " + y;
        }

    }
}
