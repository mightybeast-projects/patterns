using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.creational.abstract_factory
{
    public class CircleFactory: IAbstractShapeFactory
    {
        public IRasterShape CreateRasterShape()
        {
            return new RasterCircle();
        }

        public IVectorShape CreateVectorShape()
        {
            return new VectorCircle();
        }
    }
}