using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.state_machine
{
    public class SavingState: IState
    {
        private Shape _shape;

        public SavingState(Shape shape)
        {
            _shape = shape;
        }

        public void Apply()
        {
            Console.WriteLine("Saving shape: " + _shape.GetType());
        }
    }
}