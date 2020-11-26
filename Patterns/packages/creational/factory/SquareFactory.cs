using Patterns.packages.entity;

namespace Patterns.packages.creational.factory
{
    public class SquareFactory: ShapeFactory
    {
        public override void CreateShape()
        {
            _shape = new Square();
        }
    }
}