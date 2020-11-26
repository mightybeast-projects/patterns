using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.creational.abstract_factory
{
    public class SquareFactory: IAbstractShapeFactory
    {
        public IRasterShape CreateRasterShape()
        {
            return new RasterSquare();
        }

        public IVectorShape CreateVectorShape()
        {
            return new VectorSquare();
        }
    }
}