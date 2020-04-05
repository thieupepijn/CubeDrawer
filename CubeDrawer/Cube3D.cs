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
            Corners.Add(bottomLeftOrigin.Add(0, 0, 0, "LBF")); //Left Bottom Front
            Corners.Add(bottomLeftOrigin.Add(width, 0, 0, "RBF")); //Right Bottom Front
            Corners.Add(bottomLeftOrigin.Add(0, -height, 0, "LTF")); //Left Top Front
            Corners.Add(bottomLeftOrigin.Add(width, -height, 0, "RTF")); //Right Top Front
            Corners.Add(bottomLeftOrigin.Add(0, 0, depth, "LBB")); //Left Bottom Back
            Corners.Add(bottomLeftOrigin.Add(width, 0, depth, "RBB")); //Right Bottom Back
            Corners.Add(bottomLeftOrigin.Add(0, -height, depth, "LTB")); //Left Top Back
            Corners.Add(bottomLeftOrigin.Add(width, -height, depth, "RTB")); //Right Top Back
        }

        public void Draw(Graphics graafix, Coord2D middle)
        {
            Corners[4].Hidden = true;
            Cube2D cube2D = ProjectTo2D();
            cube2D.Draw(graafix, middle);
        }


        private Cube2D ProjectTo2D()
        {
            return new Cube2D(this);
        }
        

        


    }
}
