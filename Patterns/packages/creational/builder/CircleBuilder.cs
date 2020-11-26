using Patterns.packages.entity;

namespace Patterns.packages.creational.builder
{
    public class CircleBuilder: IShapeBuilder
    {
        private Circle _circle;

        public CircleBuilder()
        {
            Reset();
        }
        
        public void Reset()
        {
            _circle = new Circle();
        }

        public void SetEdgesCount()
        {
            _circle.edgesCount = 1;
        }

        public void SetVerticiesCount()
        {
            _circle.verticiesCount = 0;
        }

        public Shape GetShape()
        {
            return _circle;
        }
    }
}