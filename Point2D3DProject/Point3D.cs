using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D3DProject
{
    public class Point3D : Point2D
    {
        private float z;
        public Point3D() { }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { GetX(), GetY(),z };
        }
        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y);
            this.z = z;
        }
        public override String ToString()
        {
            return "X: " + GetX() + " and  Y: " + GetY()+" and Z: "+z;
        }
    }
    }
