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
                Console.WriteLine("Or: CubeDrawer <CubeWidth> <CubeHeight> <CubeDepth> <ImageFilePath> <ImageFileWidth> <ImageFileHeight>");
                return;
            }

            int cubeWidth = 0, cubeHeight = 0, cubeDepth = 0;
            try
            {
                cubeWidth = ParseDimensionParameter(args[0]);
                cubeHeight = ParseDimensionParameter(args[1]);
                cubeDepth = ParseDimensionParameter(args[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string outputFilepath = args[3];

            int outputfileWidth = 2000;
            int outputfileHeight = 2000;

            if (args.Length == 6)
            {
                outputfileWidth = ParseDimensionParameter(args[4]);
                outputfileHeight = ParseDimensionParameter(args[5]);
            }
       

            using (Bitmap bitmap = new Bitmap(outputfileWidth, outputfileHeight))
            {
                Coord3D cubeorigin = new Coord3D(0, 0, 0);

                Cube3D Cube = new Cube3D(cubeorigin, cubeWidth, cubeHeight, cubeDepth);
                using (Graphics graafix = Graphics.FromImage(bitmap))
                {
                    Cube.Draw(graafix, new Coord2D(outputfileWidth / 2, outputfileHeight / 2), outputfileHeight);
                    try
                    {
                        bitmap.Save(outputFilepath);
                    }
                    catch
                    {
                        Console.WriteLine("Could not write to file \"{0}\"", outputFilepath);
                    }
                }
            }
        }

        private static int ParseDimensionParameter(string dimension)
        {
            try
            {
                int number = Convert.ToInt16(dimension);
                if (number < 1)
                {
                    throw new Exception(string.Format("{0} is not a valid cube- or image-dimension", dimension), null);
                }
                else
                {
                    return number;
                }
            }
            catch
            {
                throw new Exception(string.Format("{0} is not a valid cube- or image-dimension", dimension), null);
            }
        }
    
    }
}
