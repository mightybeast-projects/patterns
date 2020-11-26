using System;
using Patterns.packages.entity;

namespace Patterns.packages.structural.decorator
{
    public class EncryptionDecorator: ShapeDataSourceDecorator
    {
        public EncryptionDecorator(IShapeDataSource shapeDataSource)
        {
            _shapeDataSource = shapeDataSource;
        }

        public override void WriteData(Shape shape)
        {
            base.WriteData(shape);
            Console.WriteLine("Encrypting and writing shape data");
        }

        public override void ReadData()
        {
            base.ReadData();
            Console.WriteLine("Reading and decrypting shape data");
        }
    }
}