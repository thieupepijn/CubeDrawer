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
                Coord3D cubeorigin = new Coord3D(400, 400, 400);
                double width = 200;
                double height = 200;
                double depth = 200;

                Cube3D Cube = new Cube3D(cubeorigin , width, height, depth);
                Coord3D cameraLocation = new Coord3D(500, 300, -800);

                using (Graphics graafix = Graphics.FromImage(bitmap))
                {
                    Cube.Draw(graafix, cameraLocation, new Coord2D(1000, 1000));
                    bitmap.Save(@"D:\Pepijn\Cube.jpg");
                }
            }


            


        }
    }
}
