using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.chain_of_responsibility
{
    public class SquareChecker: ShapeChecker
    {
        public override void Check(Shape shape)
        {
            if(shape is Square)
                Console.WriteLine("Shape is square");
            if(_next != null)
                _next.Check(shape);
        }
    }
}