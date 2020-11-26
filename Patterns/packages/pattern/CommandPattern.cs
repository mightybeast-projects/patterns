using System.Drawing;
using Patterns.packages.behavioral.command;
using Patterns.packages.entity;
using Patterns.packages.interfaces;
using Patterns.packages.structural.bridge;

namespace Patterns.packages.pattern
{
    public class CommandPattern: IPattern
    {
        private Shape _shape;
        private ShapeCommandInvoker _commandInvoker;
        private IShapeCommand _shapeCommand;
        
        public void Run()
        {
            _shape = new Square();
            _commandInvoker = new ShapeCommandInvoker();
            
            TextShapeCommand(new SetColorCommand(_shape, Color.Aqua));
            TextShapeCommand(new SetMaterialCommand(_shape, new MetalMaterial()));
        }

        private void TextShapeCommand(IShapeCommand shapeCommand)
        {
            _shapeCommand = shapeCommand;
            _commandInvoker.SetCommand(_shapeCommand);
            _commandInvoker.ExecuteCommand();
        }
    }
}