using System;
using Patterns.packages.creational.builder;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class BuilderPattern: IPattern
    {
        private IShapeBuilder _shapeBuilder;
        private Shape _shape;
        public void Run()
        {
            TestShapeBuilder(new SquareBuilder());
            TestShapeBuilder(new CircleBuilder());
        }

        private void TestShapeBuilder(IShapeBuilder shapeBuilder)
        {
            _shapeBuilder = shapeBuilder;
            _shapeBuilder.SetEdgesCount();
            _shapeBuilder.SetVerticiesCount();
            _shape = _shapeBuilder.GetShape();
            Console.WriteLine(_shape.verticiesCount);
        }
    }
}