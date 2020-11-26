using Patterns.packages.interfaces;

namespace Patterns.packages.creational.abstract_factory
{
    public interface IAbstractShapeFactory
    {
        IRasterShape CreateRasterShape();
        IVectorShape CreateVectorShape();
    }
}