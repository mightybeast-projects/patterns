using System.Drawing;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.command
{
    public class SetColorCommand: IShapeCommand
    {
        private Shape _shape;
        private Color _color;

        public SetColorCommand(Shape shape, Color color)
        {
            _shape = shape;
            _color = color;
        }

        public void Execute()
        {
            _shape.color = _color;
        }
    }
}