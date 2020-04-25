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

        public bool Hidden { get; private set; }

        public Coord2D(double x, double y, string code, bool hidden)
        {
            X = x;
            Y = y;
            Code = code;
            Hidden = hidden;
        }

        public Coord2D(double x, double y)
        {
            X = x;
            Y = y;
            Code = string.Empty;
            Hidden = false;
        }

        public void Add(double x, double y)
        {
            X = X + x;
            Y = Y + y;
        }

        public void Draw(Graphics graafix, List<Coord2D> coords)
        {
            if (!Hidden)
            {
                DrawLines(graafix, coords);
              //  graafix.DrawString(Code, new Font("Arial", 25), Brushes.Black, new PointF((float)X, (float)Y)); 
            }
        }

       

        private void DrawLines(Graphics graafix, List<Coord2D> coords)
        {
            if (!Hidden)
            {
                List<Coord2D> connected = Connected(coords);
                connected.ForEach(c => DrawLine(graafix, c));
            }
        }

        private void DrawLine(Graphics graafix, Coord2D other)
        {
            if (!other.Hidden)
            {
                Pen pen = new Pen(Brushes.Red, 5);
                graafix.DrawLine(pen, (int)X, (int)Y, (int)other.X, (int)other.Y);
            }
        }

        private List<Coord2D> Connected(List<Coord2D> coords)
        {
            List<Coord2D> connected = new List<Coord2D>();
            foreach(Coord2D coord in coords)
            {
                if (Connected(coord))
                {
                    connected.Add(coord);
                }
            }
            return connected;
        }


        private bool Connected(Coord2D other)
        {
            if (UtilString.NumberOfCharactersEqual(Code, other.Code) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       



    }
}
