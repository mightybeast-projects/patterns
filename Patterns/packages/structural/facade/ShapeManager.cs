using Patterns.packages.creational.factory;
using Patterns.packages.entity;

namespace Patterns.packages.structural.facade
{
    public class ShapeManager
    {
        public void DrawSquareAndCircle()
        {
            Shape square = CreateNewShape(new SquareFactory());
            Shape circle = CreateNewShape(new CircleFactory());
            square.Draw();
            circle.Draw();
        }

        public void DrawTwoCircles()
        {
            ShapeFactory circleFactory = new CircleFactory();
            Shape circle1 = CreateNewShape(circleFactory);
            Shape circle2 = CreateNewShape(circleFactory);
            circle1.Draw();
            circle2.Draw();
        }

        private Shape CreateNewShape(ShapeFactory shapeFactory)
        {
            shapeFactory.CreateShape();
            return shapeFactory.GetShape();
        }
    }
}