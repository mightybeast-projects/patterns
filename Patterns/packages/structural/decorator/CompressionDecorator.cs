using System;
using Patterns.packages.entity;

namespace Patterns.packages.structural.decorator
{
    public class CompressionDecorator: ShapeDataSourceDecorator
    {

        public CompressionDecorator(IShapeDataSource shapeDataSource)
        {
            _shapeDataSource = shapeDataSource;
        }

        public override void WriteData(Shape shape)
        {
            base.WriteData(shape);
            Console.WriteLine("Compressing and writing shape data");
        }

        public override void ReadData()
        {
            base.ReadData();
            Console.WriteLine("Reading and decompressing shape data");
        }
    }
}