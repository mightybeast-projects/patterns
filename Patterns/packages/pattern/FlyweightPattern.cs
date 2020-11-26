using Patterns.packages.creational.factory;
using Patterns.packages.interfaces;
using Patterns.packages.structural.flyweight;

namespace Patterns.packages.pattern
{
    public class FlyweightPattern: IPattern
    {
        private ShapeFactoryFlyweight _shapeFactoryFlyweight;
        
        public void Run()
        {
            _shapeFactoryFlyweight = new ShapeFactoryFlyweight(new SquareFactory());
            _shapeFactoryFlyweight.DrawHundredShapes();
        }
    }
}