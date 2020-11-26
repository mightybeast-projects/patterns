using System.Collections.Generic;
using Patterns.packages.interfaces;

namespace Patterns.packages.behavioral.iterator
{
    public class DrawableCollection: IIterableCollection
    {
        private IIterator _iterator;
        private List<IDrawable> _drawables;

        public List<IDrawable> drawables
        {
            get => _drawables;
            set => _drawables = value;
        }

        public DrawableCollection(List<IDrawable> drawables)
        {
            _drawables = drawables;
        }

        public IIterator CreateIterator()
        {
            _iterator = new ListIterator(this);
            return _iterator;
        }
    }
}