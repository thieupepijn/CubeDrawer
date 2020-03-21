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

        public Coord3D Add(double x, double y, double z)
        {
            return new Coord3D(X + x, Y + y, Z + z);
        }

        public Coord2D ProjectTo2d(Coord3D cameraLocation)
        {
            double distanceFromCamera = Pythogoras(this, cameraLocation);

            double x = X / (distanceFromCamera / Z);
            double y = Y / (distanceFromCamera / Z);
            return new Coord2D(x, y);

        }

        public static void DrawLine(Graphics graafix, Coord3D cameraLocation, Coord3D coord1, Coord3D coord2)
        {
            Coord2D.DrawLine(graafix, coord1.ProjectTo2d(cameraLocation), coord2.ProjectTo2d(cameraLocation));
        }

        private static double Pythogoras(Coord3D coord1, Coord3D coord2)
        {
            double deltaX = coord1.X - coord2.X;
            double deltaY = coord1.Y - coord2.Y;
            double deltaZ = coord1.Z - coord2.Z;

            double pythogoras = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));
            return pythogoras;
        }

    }
}
