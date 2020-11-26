using Patterns.packages.creational.factory;
using Patterns.packages.entity;
using Patterns.packages.interfaces;
using Patterns.packages.structural.bridge;

namespace Patterns.packages.pattern
{
    public class BridgePattern: IPattern
    {
        private ShapeFactory _shapeFactory;
        private Shape _shape;
        
        public void Run()
        {
            CreateNewShape();
            TestNewMaterial(new WoodMaterial());
            TestNewMaterial(new MetalMaterial());
        }

        private void CreateNewShape()
        {
            _shapeFactory = new SquareFactory();
            _shapeFactory.CreateShape();
            _shape = _shapeFactory.GetShape();
        }

        private void TestNewMaterial(IShapeMaterial shapeMaterial)
        {
            _shape.shapeMaterial = shapeMaterial;
            _shape.shapeMaterial.ApplyMaterial();
        }
    }
}