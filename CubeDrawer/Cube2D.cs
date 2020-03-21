using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

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

        public Cube2D(Cube3D Cube3d, Coord3D cameraLocation)
        {
            BottomLeftFront = Cube3d.BottomLeftFront.ProjectTo2d(cameraLocation);
            BottomRightFront = Cube3d.BottomRightFront.ProjectTo2d(cameraLocation);
            TopLeftFront = Cube3d.TopLeftFront.ProjectTo2d(cameraLocation);
            TopRightFront = Cube3d.TopRightFront.ProjectTo2d(cameraLocation);

            BottomLeftBack = Cube3d.BottomLeftBack.ProjectTo2d(cameraLocation);
            BottomRightBack = Cube3d.BottomRightBack.ProjectTo2d(cameraLocation);
            TopLeftBack= Cube3d.TopLeftBack.ProjectTo2d(cameraLocation);
            TopRightBack = Cube3d.TopRightBack.ProjectTo2d(cameraLocation);
        }

       
        public void Draw(Graphics graafix)
        {
            Coord2D.DrawLine(graafix, BottomLeftFront, BottomRightFront);
            Coord2D.DrawLine(graafix, BottomLeftFront, TopLeftFront);
           // Coord2D.DrawLine(graafix, BottomRightFront, TopRightFront);
            //Coord2D.DrawLine(graafix, TopLeftFront, TopRightFront);

            Coord2D.DrawLine(graafix, BottomLeftBack, BottomRightBack);
            Coord2D.DrawLine(graafix, BottomLeftBack, TopLeftBack);
            Coord2D.DrawLine(graafix, BottomRightBack, TopRightBack);
            Coord2D.DrawLine(graafix, TopLeftBack, TopRightBack);

            Coord2D.DrawLine(graafix, BottomLeftFront, BottomLeftBack);
            Coord2D.DrawLine(graafix, TopLeftFront, TopLeftBack);
            Coord2D.DrawLine(graafix, BottomRightFront, BottomRightBack);
         //   Coord2D.DrawLine(graafix, TopRightFront, TopRightBack);
        }


    }
}
