using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace CubeDrawer
{
    public class Cube2D
    {

        public Coord2D BottomLeftFront { get; private set; }
        public Coord2D BottomRightFront { get; private set; }
        public Coord2D TopLeftFront { get; private set; }
        public Coord2D TopRightFront { get; private set; }
        public Coord2D BottomLeftBack { get; private set; }
        public Coord2D BottomRightBack { get; private set; }
        public Coord2D TopLeftBack { get; private set; }
        public Coord2D TopRightBack { get; private set; }

        public List<Coord2D> All { get; private set; }

        public Cube2D(Cube3D Cube3d, Coord3D cameraLocation)
        {
            BottomLeftFront = Cube3d.LeftBottomFront.ProjectTo2d(cameraLocation);
            BottomRightFront = Cube3d.RightBottomFront.ProjectTo2d(cameraLocation);
            TopLeftFront = Cube3d.LeftTopFront.ProjectTo2d(cameraLocation);
            TopRightFront = Cube3d.RightTopFront.ProjectTo2d(cameraLocation);

            BottomLeftBack = Cube3d.LeftBottomBack.ProjectTo2d(cameraLocation);
            BottomRightBack = Cube3d.RightBottomBack.ProjectTo2d(cameraLocation);
            TopLeftBack= Cube3d.LeftTopBack.ProjectTo2d(cameraLocation);
            TopRightBack = Cube3d.RightTopBack.ProjectTo2d(cameraLocation);

            All = new List<Coord2D>();
            All.Add(BottomLeftFront);
            All.Add(BottomRightFront);
            All.Add(TopLeftFront);
            All.Add(TopRightFront);
            All.Add(BottomLeftBack);
            All.Add(BottomRightBack);
            All.Add(TopLeftBack);
            All.Add(TopRightBack);
        }

            
        public void Draw(Graphics graafix, Coord2D middle)
        {
            Center(middle);
            All.ForEach(c => c.DrawLines(graafix, All));
        }

        private void Center(Coord2D middle)
        {
            Coord2D average = AverageCoordinate();
            double deltaX = middle.X - average.X;
            double deltaY = middle.Y - average.Y;
            All.ForEach(c => c.Add(deltaX, deltaY));
        }

        private Coord2D AverageCoordinate()
        {
            double averageX = All.Average(c => c.X);
            double averageY = All.Average(c => c.Y);
            return new Coord2D(averageX, averageY, "Average");
        }

    }
}
