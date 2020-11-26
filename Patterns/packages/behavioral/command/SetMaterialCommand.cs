using Patterns.packages.entity;
using Patterns.packages.structural.bridge;

namespace Patterns.packages.behavioral.command
{
    public class SetMaterialCommand: IShapeCommand
    {
        private Shape _shape;
        private IShapeMaterial _shapeMaterial;

        public SetMaterialCommand(Shape shape, IShapeMaterial shapeMaterial)
        {
            _shape = shape;
            _shapeMaterial = shapeMaterial;
        }

        public void Execute()
        {
            _shape.shapeMaterial = _shapeMaterial;
        }
    }
}