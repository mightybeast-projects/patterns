using System.Collections.Generic;
using Patterns.packages.behavioral.iterator;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class IteratorPattern: IPattern
    {
        private List<IDrawable> _drawables;
        private IIterableCollection _iterableCollection;
        private IIterator _iterator;
        
        public void Run()
        {
            InitializeDrawablesList();
            TestIterator();
        }

        private void TestIterator()
        {
            _iterableCollection = new DrawableCollection(_drawables);
            _iterator = _iterableCollection.CreateIterator();
            while (_iterator.HasMore())
                _iterator.GetNext().Draw();
        }

        private void InitializeDrawablesList()
        {
            _drawables = new List<IDrawable>
            {
                new Circle(),
                new Square(),
                new RasterCircle(),
                new RasterSquare(),
                new VectorCircle(),
                new VectorSquare()
            };

        }
    }
}