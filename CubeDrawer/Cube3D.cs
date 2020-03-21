using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubeDrawer
{
    public class Cube3D
    {
        public Coord3D BottomLeftFront { get; private set; } 
        public Coord3D BottomRightFront { get; private set; } 
        public Coord3D TopLeftFront { get; private set; }
        public Coord3D TopRightFront { get; private set; }
        public Coord3D BottomLeftBack { get; private set; }
        public Coord3D BottomRightBack { get; private set; }
        public Coord3D TopLeftBack { get; private set; }
        public Coord3D TopRightBack { get; private set; }

        public Cube3D(Coord3D bottomLeftOrigin, double width, double height, double depth)
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

        public Cube2D ProjectTo2D(Coord3D cameraLocation)
        {
            return new Cube2D(this, cameraLocation);
        }
        

        public void Draw(Graphics graafix, Coord3D cameraLocation)
        {

            Cube2D cube2D = ProjectTo2D(cameraLocation);
            cube2D.Draw(graafix);
        }


    }
}
