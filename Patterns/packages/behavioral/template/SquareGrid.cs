using Patterns.packages.entity;

namespace Patterns.packages.behavioral.template
{
    public class SquareGrid: GridTemplate
    {
        protected override void InitializeNewTileShape()
        {
            _gridTileShape = new Square();
        }
    }
}