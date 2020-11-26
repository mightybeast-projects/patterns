using System;
using Patterns.packages.interfaces;

namespace Patterns.packages.entity
{
    public class RasterCircle: Shape, IRasterShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }

        public void DrawRaster()
        {
            Console.WriteLine("Draw raster circle");
        }
    }
}