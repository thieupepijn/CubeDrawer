using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubeDrawer
{
    public class Cube3D
    {
        public Coord3D LeftBottomFront { get; private set; } 
        public Coord3D RightBottomFront { get; private set; } 
        public Coord3D LeftTopFront { get; private set; }
        public Coord3D RightTopFront { get; private set; }
        public Coord3D LeftBottomBack { get; private set; }
        public Coord3D RightBottomBack { get; private set; }
        public Coord3D LeftTopBack { get; private set; }
        public Coord3D RightTopBack { get; private set; }


        public Cube3D(Coord3D bottomLeftOrigin, double width, double height, double depth)
        {
            LeftBottomFront = bottomLeftOrigin.Add(0, 0, 0, "LBF");
            RightBottomFront = bottomLeftOrigin.Add(width, 0, 0, "RBF");
            LeftTopFront = bottomLeftOrigin.Add(0, -height, 0, "LTF");
            RightTopFront = bottomLeftOrigin.Add(width, -height, 0, "RTF");

            LeftBottomBack = bottomLeftOrigin.Add(0, 0, depth, "LBB");
            RightBottomBack = bottomLeftOrigin.Add(width, 0, depth, "RBB");
            LeftTopBack = bottomLeftOrigin.Add(0, -height, depth, "LTB");
            RightTopBack = bottomLeftOrigin.Add(width, -height, depth, "RTB");
        }

        public Cube2D ProjectTo2D(Coord3D cameraLocation)
        {
            return new Cube2D(this, cameraLocation);
        }
        

        public void Draw(Graphics graafix, Coord3D cameraLocation, Coord2D middle)
        {

            Cube2D cube2D = ProjectTo2D(cameraLocation);
            cube2D.Draw(graafix, middle);
        }


    }
}
