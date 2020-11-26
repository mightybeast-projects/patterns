using System.Collections.Generic;
using Patterns.packages.entity;

namespace Patterns.packages.structural.proxy
{
    public class VectorShapeLibrary : IShapeLibrary
    {
        public List<Shape> GetShapes()
        {
            //return new List<VectorShape>;
            return new List<Shape>();
        }
    }
}