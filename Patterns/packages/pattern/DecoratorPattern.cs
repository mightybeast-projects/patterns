using Patterns.packages.entity;
using Patterns.packages.interfaces;
using Patterns.packages.structural.decorator;

namespace Patterns.packages.pattern
{
    public class DecoratorPattern: IPattern
    {
        private Shape _shape;
        private IShapeDataSource _shapeDataSource;
        
        public void Run()
        {
            _shape = new Circle();
            TestShapeDataSource(new FileDataSource());
            TestShapeDataSource(new EncryptionDecorator(_shapeDataSource));
            TestShapeDataSource(new CompressionDecorator(_shapeDataSource));
        }

        private void TestShapeDataSource(IShapeDataSource shapeDataSource)
        {
            _shapeDataSource = shapeDataSource;
            _shapeDataSource.WriteData(_shape);
        }
    }
}