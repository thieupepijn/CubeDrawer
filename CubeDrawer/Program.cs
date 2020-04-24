using System;
using System.Collections.Generic;
using System.Drawing;

namespace CubeDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubeWidth = Convert.ToInt16(args[0]);
            int cubeHeight = Convert.ToInt16(args[1]);
            int cubeDepth = Convert.ToInt16(args[2]);

            string outputFilepath = args[3];

            using (Bitmap bitmap = new Bitmap(2000, 2000))
            {
                Coord3D cubeorigin = new Coord3D(0, 0, 0);

                Cube3D Cube = new Cube3D(cubeorigin, cubeWidth, cubeHeight, cubeDepth);
                using (Graphics graafix = Graphics.FromImage(bitmap))
                {
                    Cube.Draw(graafix, new Coord2D(1000, 1000), 2000);
                    bitmap.Save(outputFilepath);
                }
            }

        }
    }
}
