using Patterns.packages.entity;

namespace Patterns.packages.behavioral.template
{
    public class CircleGrid: GridTemplate
    {
        protected override void InitializeNewTileShape()
        {
            _gridTileShape = new Circle();
        }
    }
}