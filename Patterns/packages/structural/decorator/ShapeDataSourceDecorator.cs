using Patterns.packages.entity;

namespace Patterns.packages.structural.decorator
{
    public abstract class ShapeDataSourceDecorator: IShapeDataSource
    {
        protected IShapeDataSource _shapeDataSource;

        public virtual void WriteData(Shape shape)
        {
            _shapeDataSource.WriteData(shape);
        }

        public virtual void ReadData()
        {
            _shapeDataSource.ReadData();   
        }
    }
}