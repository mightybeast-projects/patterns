using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.strategy
{
    public class VerticalGradientStrategy: IStrategy
    {
        private Shape _shape;

        public VerticalGradientStrategy(Shape shape)
        {
            _shape = shape;
        }

        public void Execute()
        {
            Console.WriteLine("Applying vertical gradient to : " + _shape.GetType());
        }
    }
}