using Patterns.packages.interfaces;

namespace Patterns.packages.behavioral.iterator
{
    public class ListIterator: IIterator
    {
        private DrawableCollection _drawableCollection;
        private int _index;

        public ListIterator(DrawableCollection drawableCollection)
        {
            _drawableCollection = drawableCollection;
        }

        public IDrawable GetNext()
        {
            IDrawable drawable = _drawableCollection.drawables[_index];
            _index++;
            return drawable;
        }

        public bool HasMore()
        {
            return _drawableCollection.drawables.Count > _index;
        }
    }
}