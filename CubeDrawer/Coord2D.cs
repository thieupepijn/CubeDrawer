using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubeDrawer
{ 
    public class Coord2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public string Code { get; private set; }

        public Coord2D(double x, double y, string code)
        {
            X = x;
            Y = y;
            Code = code;
        }

        public Coord2D Add(double x, double y)
        {
            return new Coord2D(X + x, Y + y, Code);
        }

        private List<Coord2D> Connected(List<Coord2D> all)
        {
            return null;
        }


        //private bool Connected(Coord2D other)
       // {
        //}

        public static void DrawLine(Graphics graafix, Coord2D coord1, Coord2D coord2)
        {
            Pen pen = new Pen(Brushes.Red, 5);
            graafix.DrawLine(pen, (int)coord1.X, (int)coord1.Y, (int)coord2.X, (int)coord2.Y);
        }

    }
}
