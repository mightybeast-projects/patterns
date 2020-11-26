namespace Patterns.packages.behavioral.command
{
    public class ShapeCommandInvoker
    {
        private IShapeCommand _shapeCommand;

        public void SetCommand(IShapeCommand shapeCommand)
        {
            _shapeCommand = shapeCommand;
        }

        public void ExecuteCommand()
        {
            _shapeCommand.Execute();
        }
    }
}