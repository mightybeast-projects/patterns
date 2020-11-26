using Patterns.packages.creational.abstract_factory;
using Patterns.packages.interfaces;
using CircleFactory = Patterns.packages.creational.abstract_factory.CircleFactory;
using SquareFactory = Patterns.packages.creational.abstract_factory.SquareFactory;

namespace Patterns.packages.pattern
{
    public class AbstractFactoryPattern: IPattern
    {
        private IAbstractShapeFactory _shapeFactory;
        private IRasterShape _rasterShape;
        private IVectorShape _vectorShape;
        
        public void Run()
        {
            TestShapeFactory(new SquareFactory());
            TestShapeFactory(new CircleFactory());
        }

        private void DrawShapes()
        {
            _rasterShape.DrawRaster();
            _vectorShape.DrawVector();
        }

        private void TestShapeFactory(IAbstractShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
            _rasterShape = _shapeFactory.CreateRasterShape();
            _vectorShape = _shapeFactory.CreateVectorShape();
            
            DrawShapes();
        }
    }
}