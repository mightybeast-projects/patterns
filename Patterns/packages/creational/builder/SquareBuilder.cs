using Patterns.packages.entity;

namespace Patterns.packages.creational.builder
{
    public class SquareBuilder: IShapeBuilder
    {
        private Square _square;
        
        public SquareBuilder()
        {
            Reset();
        }
        
        public void Reset()
        {
            _square = new Square();
        }

        public void SetEdgesCount()
        {
            _square.edgesCount = 4;
        }

        public void SetVerticiesCount()
        {
            _square.verticiesCount = 4;
        }

        public Shape GetShape()
        {
            return _square;
        }
    }
}