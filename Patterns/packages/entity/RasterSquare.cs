using System;
using Patterns.packages.creational.factory;
using Patterns.packages.interfaces;

namespace Patterns.packages.entity
{
    public class RasterSquare: Shape, IRasterShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw square");
        }

        public void DrawRaster()
        {
            Console.WriteLine("Draw raster square");
        }
    }
}