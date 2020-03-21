using System;
using System.Collections.Generic;
using System.Drawing;

namespace CubeDrawer
{
    class Program
    {
        static void Main(string[] args)
        {

            //int cubeWidth = Convert.ToInt16(args[0]);
            // int cubeHeight = Convert.ToInt16(args[1]);
            //  int cubeDepth = Convert.ToInt16(args[2]);



            using (Bitmap bitmap = new Bitmap(2000, 2000))
            {
                Cube3D Cube = new Cube3D(new Coord3D(100, 0, 100), 200, 200, 200);
                Coord3D cameraLocation = new Coord3D(0, 0, 0);

                using (Graphics graafix = Graphics.FromImage(bitmap))
                {
                    Cube.Draw(graafix, cameraLocation, new Coord2D(1000, 1000));
                    bitmap.Save(@"D:\Pepijn\Cube.jpg");
                }
            }


            


        }
    }
}
