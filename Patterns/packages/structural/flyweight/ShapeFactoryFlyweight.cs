using Patterns.packages.creational.factory;
using Patterns.packages.entity;

namespace Patterns.packages.structural.flyweight
{
    public class ShapeFactoryFlyweight
    {
        private ShapeFactory _shapeFactory;
        private Shape _shape;

        public ShapeFactoryFlyweight(ShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        public void DrawHundredShapes()
        {
            CreateNewShape();
            
            for (int i = 0; i < 100; i++)
                _shape.Draw();
        }

        private void CreateNewShape()
        {
           _shapeFactory.CreateShape();
           _shape = _shapeFactory.GetShape();
        }
    }
}