using System;
using System.Collections.Generic;
using System.Drawing;

namespace CubeDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine("Draws a cube to specified image-file");
                Console.WriteLine("Usage: CubeDrawer <CubeWidth> <CubeHeight> <CubeDepth> <ImageFilePath>");
                return;
            }

            int cubeWidth = 0, cubeHeight = 0, cubeDepth = 0;
            try
            {
                cubeWidth = ParseCubeDimensionParameter(args[0]);
                cubeHeight = ParseCubeDimensionParameter(args[1]);
                cubeDepth = ParseCubeDimensionParameter(args[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

           
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

        private static int ParseCubeDimensionParameter(string dimension)
        {
            try
            {
                int number = Convert.ToInt16(dimension);
                if (number < 1)
                {
                    throw new Exception(string.Format("{0} is not a valid cube-dimension", dimension), null);
                }
                else
                {
                    return number;
                }
            }
            catch
            {
                throw new Exception(string.Format("{0} is not a valid cube-dimension", dimension), null);
            }
        }
    
    }
}
