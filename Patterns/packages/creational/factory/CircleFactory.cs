using Patterns.packages.entity;

namespace Patterns.packages.creational.factory
{
    public class CircleFactory: ShapeFactory
    {
        public override void CreateShape()
        {
            _shape = new Circle();
        }
    }
}