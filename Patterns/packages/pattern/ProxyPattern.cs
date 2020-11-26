using System.Collections.Generic;
using Patterns.packages.entity;
using Patterns.packages.interfaces;
using Patterns.packages.structural.proxy;

namespace Patterns.packages.pattern
{
    public class ProxyPattern: IPattern
    {
        private IShapeLibrary _shapeLibrary;
        private IShapeLibrary _shapeLibraryProxy;
        private List<Shape> _newShapes;
        
        public void Run()
        {
            _shapeLibrary = new VectorShapeLibrary();
            _shapeLibraryProxy = new ShapeLibraryProxy(_shapeLibrary);
            _newShapes = _shapeLibraryProxy.GetShapes();
        }
    }
}