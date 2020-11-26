using Patterns.packages.interfaces;

namespace Patterns.packages.behavioral.iterator
{
    public interface IIterator
    {
        IDrawable GetNext();
        bool HasMore();
    }
}