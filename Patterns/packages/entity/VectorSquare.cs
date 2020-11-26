using System;
using Patterns.packages.interfaces;

namespace Patterns.packages.entity
{
    public class VectorSquare: Shape, IVectorShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw square");
        }

        public void DrawVector()
        {
            Console.WriteLine("Draw vector square");
        }
    }
}