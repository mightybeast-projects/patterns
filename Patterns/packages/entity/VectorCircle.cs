using System;
using Patterns.packages.interfaces;

namespace Patterns.packages.entity
{
    public class VectorCircle: Shape, IVectorShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }

        public void DrawVector()
        {
            Console.WriteLine("Draw vector circle");
        }
    }
}