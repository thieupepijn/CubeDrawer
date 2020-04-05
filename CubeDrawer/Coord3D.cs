using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubeDrawer
{
    public class Coord3D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        public string Code { get; private set; }

        public bool Hidden { get; set; }


        public Coord3D(double x, double y, double z, string code)
        {
            X = x;
            Y = y;
            Z = z;
            Code = code;
            Hidden = false;
        }

        public Coord3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            Code = string.Empty;
            Hidden = false;
        }

        public Coord3D Add(double x, double y, double z, string code)
        {
            return new Coord3D(X + x, Y + y, Z + z, code);
        }

        public Coord2D ProjectTo2d()
        {
            double x = X +  Math.Sqrt(Z * Z / 4);
            double y = Y - Math.Sqrt(Z * Z / 4);
            return new Coord2D(x, y, Code, Hidden);

        }




    }
}
