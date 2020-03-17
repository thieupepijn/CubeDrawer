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


        public Coord3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Coord2D ProjectTo2d()
        {
            double x = X / (Z / 80);
            double y = Y / (Z / 80);
            return new Coord2D(x, y);

        }

        public static void DrawLine(Graphics graafix, Coord3D coord1, Coord3D coord2)
        {
            Coord2D.DrawLine(graafix, coord1.ProjectTo2d(), coord2.ProjectTo2d());
        }

    }
}
