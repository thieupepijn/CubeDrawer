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
                Cube3D Cube = new Cube3D(new Coord3D(10, 10, 10), 300, 300, 300);
                Coord3D cameraLocation = new Coord3D(400, 400, -400);

                using (Graphics graafix = Graphics.FromImage(bitmap))
                {
                    Cube.Draw(graafix, cameraLocation);
                    bitmap.Save(@"D:\Pepijn\Cube.jpg");
                }
            }


            


        }
    }
}
