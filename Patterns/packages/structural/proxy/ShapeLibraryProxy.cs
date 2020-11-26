using System.Collections.Generic;
using Patterns.packages.entity;

namespace Patterns.packages.structural.proxy
{
    public class ShapeLibraryProxy: IShapeLibrary
    {
        private IShapeLibrary _shapeLibrary;
        private List<Shape> _cachedShapes;

        public ShapeLibraryProxy(IShapeLibrary shapeLibrary)
        {
            _shapeLibrary = shapeLibrary;
        }

        public List<Shape> GetShapes()
        {
            if (_cachedShapes == null)
                _cachedShapes = _shapeLibrary.GetShapes();
            return _cachedShapes;
        }
    }
}