using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.chain_of_responsibility
{
    public class CircleChecker: ShapeChecker
    {
        public override void Check(Shape shape)
        {
            if(shape is Circle)
                Console.WriteLine("Shape is circle");
            if(_next != null)
                _next.Check(shape);
        }
    }
}