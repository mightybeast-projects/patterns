using Patterns.packages.creational.factory;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class FactoryPattern: IPattern
    {
        private ShapeFactory _shapeFactory;
        private IDrawable _shape;

        public void Run()
        {
            DrawShapeAfterCreatingIn(new SquareFactory());
            DrawShapeAfterCreatingIn(new CircleFactory());
        }

        private void DrawShapeAfterCreatingIn(ShapeFactory shapeFactory)
        {
            CreateShapeIn(shapeFactory);
            _shape.Draw();
        }

        private void CreateShapeIn(ShapeFactory shapeFactory)
        {
            _shapeFactory = new SquareFactory();
            _shapeFactory.CreateShape();
            _shape = shapeFactory.GetShape();
        }
    }
}