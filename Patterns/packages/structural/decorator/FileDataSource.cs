using System;
using Patterns.packages.entity;

namespace Patterns.packages.structural.decorator
{
    public class FileDataSource: IShapeDataSource
    {
        public void WriteData(Shape shape)
        {
            Console.WriteLine("Writing data to file source");
        }

        public void ReadData()
        {
            Console.WriteLine("Reading data from file source");
        }
    }
}