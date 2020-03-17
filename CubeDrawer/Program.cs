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

            List<Coord3D> coords = new List<Coord3D>();

            //
            Coord3D coord1 = new Coord3D(750, 750, 250);
            Coord3D coord2 = new Coord3D(1000, 750, 250);
            Coord3D coord3 = new Coord3D(750, 1000, 250);
            Coord3D coord4 = new Coord3D(1000, 1000, 250);
            //back
            Coord3D coord5 = new Coord3D(750, 750, 500);
            Coord3D coord6 = new Coord3D(1000, 750, 500);
            Coord3D coord7 = new Coord3D(750, 1000, 500);
            Coord3D coord8 = new Coord3D(1000, 1000, 500);

            using (Bitmap bitmap = new Bitmap(2000, 2000))
            {
                Graphics graafix = Graphics.FromImage(bitmap);

                //front
                Coord3D.DrawLine(graafix, coord1, coord2);
                Coord3D.DrawLine(graafix, coord1, coord3);
                Coord3D.DrawLine(graafix, coord2, coord4);
                Coord3D.DrawLine(graafix, coord3, coord4);
                //back
                Coord3D.DrawLine(graafix, coord5, coord6);
                Coord3D.DrawLine(graafix, coord5, coord7);
                Coord3D.DrawLine(graafix, coord6, coord8);
                Coord3D.DrawLine(graafix, coord7, coord8);
                //sides
                Coord3D.DrawLine(graafix, coord1, coord5);
                Coord3D.DrawLine(graafix, coord3, coord7);
                Coord3D.DrawLine(graafix, coord2, coord6);
                Coord3D.DrawLine(graafix, coord4, coord8);




                bitmap.Save(@"D:\Pepijn\Cube.jpg");
            }


            


        }
    }
}
