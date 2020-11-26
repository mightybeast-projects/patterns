using Patterns.packages.entity;

namespace Patterns.packages.structural.decorator
{
    public interface IShapeDataSource
    {
        void WriteData(Shape shape);
        void ReadData();
    }
}