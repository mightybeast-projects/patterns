using Patterns.packages.entity;

namespace Patterns.packages.creational.builder
{
    public interface IShapeBuilder
    {
        void Reset();
        void SetEdgesCount();
        void SetVerticiesCount();
        Shape GetShape();
    }
}