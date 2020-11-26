using Patterns.packages.entity;
using Patterns.packages.interfaces;
using Patterns.packages.structural.composite;

namespace Patterns.packages.pattern
{
    public class CompositePattern: IPattern
    {
        private ShapeGroup _shapeGroup1, _shapeGroup2, _shapeGroup3;

        public void Run()
        {
            InitializeFirstShapeGroup();
            InitializeSecondShapeGroup();
            InitializeThirdShapeGroup();

            _shapeGroup3.GroupAll();
        }

        private void InitializeThirdShapeGroup()
        {
            _shapeGroup3 = new ShapeGroup();
            _shapeGroup3.AddChild(_shapeGroup1);
            _shapeGroup3.AddChild(_shapeGroup2);
        }

        private void InitializeSecondShapeGroup()
        {
            Shape square1 = new Square();
            Shape square2 = new Square();
            Shape circle3 = new Circle();

            _shapeGroup2 = new ShapeGroup();
            _shapeGroup2.AddChild(square1);
            _shapeGroup2.AddChild(square2);
            _shapeGroup2.AddChild(circle3);
        }

        private void InitializeFirstShapeGroup()
        {
            Shape circle1 = new Circle();
            Shape circle2 = new Circle();

            _shapeGroup1 = new ShapeGroup();
            _shapeGroup1.AddChild(circle1);
            _shapeGroup1.AddChild(circle2);
        }
    }
}