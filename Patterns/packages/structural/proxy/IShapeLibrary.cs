using System.Collections.Generic;
using Patterns.packages.entity;

namespace Patterns.packages.structural.proxy
{
    public interface IShapeLibrary
    {
        List<Shape> GetShapes();
    }
}