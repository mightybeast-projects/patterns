using Patterns.packages.entity;

namespace Patterns.packages.behavioral.chain_of_responsibility
{
    public interface IShapeChecker
    {
        void SetNext(IShapeChecker shapeChecker);
        void Check(Shape shape);
    }
}