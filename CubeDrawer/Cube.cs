using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubeDrawer
{
    public class Cube
    {
        public Coord3D BottomLeftFront { get; private set; } 
        public Coord3D BottomRightFront { get; private set; } 
        public Coord3D TopLeftFront { get; private set; }
        public Coord3D TopRightFront { get; private set; }
        public Coord3D BottomLeftBack { get; private set; }
        public Coord3D BottomRightBack { get; private set; }
        public Coord3D TopLeftBack { get; private set; }
        public Coord3D TopRightBack { get; private set; }

        public Cube(Coord3D bottomLeftOrigin, double width, double height, double depth)
        {
            BottomLeftFront = bottomLeftOrigin;
            BottomRightFront = bottomLeftOrigin.Add(width, 0, 0);
            TopLeftFront = bottomLeftOrigin.Add(0, height, 0);
            TopRightFront = bottomLeftOrigin.Add(width, height, 0);

            BottomLeftBack = bottomLeftOrigin.Add(0, 0, depth);
            BottomRightBack = bottomLeftOrigin.Add(width, 0, depth);
            TopLeftBack = bottomLeftOrigin.Add(0, height, depth);
            TopRightBack = bottomLeftOrigin.Add(width, height, depth);
        }

        public void Draw(Graphics graafix, Coord3D cameraLocation)
        {
            Coord3D.DrawLine(graafix, cameraLocation, BottomLeftFront, BottomRightFront);
            Coord3D.DrawLine(graafix, cameraLocation, BottomLeftFront, TopLeftFront);
            Coord3D.DrawLine(graafix, cameraLocation, BottomRightFront, TopRightFront);
            Coord3D.DrawLine(graafix, cameraLocation, TopLeftFront, TopRightFront);

            Coord3D.DrawLine(graafix, cameraLocation, BottomLeftBack, BottomRightBack);
            Coord3D.DrawLine(graafix, cameraLocation, BottomLeftBack, TopLeftBack);
            Coord3D.DrawLine(graafix, cameraLocation, BottomRightBack, TopRightBack);
            Coord3D.DrawLine(graafix, cameraLocation, TopLeftBack, TopRightBack);

            Coord3D.DrawLine(graafix, cameraLocation, BottomLeftFront, BottomLeftBack);
            Coord3D.DrawLine(graafix, cameraLocation, TopLeftFront, TopLeftBack);
            Coord3D.DrawLine(graafix, cameraLocation, BottomRightFront, BottomRightBack);
            Coord3D.DrawLine(graafix, cameraLocation, TopRightFront, TopRightBack);







        }


    }
}
