using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace CubeDrawer
{
    public class Cube3D
    {
        public List<Coord3D> Corners { get; private set; }

        public Cube3D(Coord3D bottomLeftOrigin, double width, double height, double depth)
        {
            Corners = new List<Coord3D>();
            Corners.Add(bottomLeftOrigin.Add(0, 0, 0, "LBF", false)); //Left Bottom Front
            Corners.Add(bottomLeftOrigin.Add(width, 0, 0, "RBF", false)); //Right Bottom Front
            Corners.Add(bottomLeftOrigin.Add(0, height, 0, "LTF", false)); //Left Top Front
            Corners.Add(bottomLeftOrigin.Add(width, height, 0, "RTF", false)); //Right Top Front
            Corners.Add(bottomLeftOrigin.Add(0, 0, depth, "LBB", false)); //Left Bottom Back
            Corners.Add(bottomLeftOrigin.Add(width, 0, depth, "RBB", true)); //Right Bottom Back
            Corners.Add(bottomLeftOrigin.Add(0, height, depth, "LTB", false)); //Left Top Back
            Corners.Add(bottomLeftOrigin.Add(width, height, depth, "RTB", false)); //Right Top Back
        }

        public void Draw(Graphics graafix, Coord2D middle, double canvasHeight)
        {
            double averageY = AverageCoordinate().Y;
            Corners.ForEach(c => c.MirrorY(averageY));
            Cube2D cube2D = ProjectTo2D();
            cube2D.Draw(graafix, middle);
        }


        private Cube2D ProjectTo2D()
        {
            return new Cube2D(this);      
        }

        private Coord3D AverageCoordinate()
        {
            double averageX = Corners.Average(c => c.X);
            double averageY = Corners.Average(c => c.Y);
            double averageZ = Corners.Average(c => c.Y);
            return new Coord3D(averageX, averageY, averageZ);
        }



    }
}
