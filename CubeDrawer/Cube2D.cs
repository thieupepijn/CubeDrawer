using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace CubeDrawer
{
    public class Cube2D
    {

        public List<Coord2D> Corners { get; private set; }

        public Cube2D(Cube3D cube3d, Coord3D cameraLocation)
        {
            Corners = new List<Coord2D>();
            foreach(Coord3D coord3D in cube3d.Corners)
            {
                Coord2D coord2D = coord3D.ProjectTo2d(cameraLocation);
                Corners.Add(coord2D);
            }           
        }
         
        public void Draw(Graphics graafix, Coord2D middle)
        {
            Center(middle);
            Corners.ForEach(c => c.DrawLines(graafix, Corners));
        }

        private void Center(Coord2D middle)
        {
            Coord2D average = AverageCoordinate();
            double deltaX = middle.X - average.X;
            double deltaY = middle.Y - average.Y;
            Corners.ForEach(c => c.Add(deltaX, deltaY));
        }

        private Coord2D AverageCoordinate()
        {
            double averageX = Corners.Average(c => c.X);
            double averageY = Corners.Average(c => c.Y);
            return new Coord2D(averageX, averageY);
        }

    }
}
