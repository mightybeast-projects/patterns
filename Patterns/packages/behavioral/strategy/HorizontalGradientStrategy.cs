using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.strategy
{
    public class HorizontalGradientStrategy: IStrategy
    {
        private Shape _shape;

        public HorizontalGradientStrategy(Shape shape)
        {
            _shape = shape;
        }

        public void Execute()
        {
            Console.WriteLine("Applying horizontal gradient to : " + _shape.GetType());
        }
    }
}