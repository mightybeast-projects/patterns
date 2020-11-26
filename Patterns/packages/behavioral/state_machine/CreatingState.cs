using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.state_machine
{
    public class CreatingState: IState
    {
        private Shape _shape;

        public CreatingState(Shape shape)
        {
            _shape = shape;
        }

        public void Apply()
        {
            Console.WriteLine("Creating shape : " + _shape.GetType());
        }
    }
}