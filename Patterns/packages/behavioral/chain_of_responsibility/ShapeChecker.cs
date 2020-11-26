using Patterns.packages.entity;

namespace Patterns.packages.behavioral.chain_of_responsibility
{
    public abstract class ShapeChecker: IShapeChecker
    {
        protected IShapeChecker _next;
        
        public void SetNext(IShapeChecker nextShapeChecker)
        {
            _next = nextShapeChecker;
        }

        public abstract void Check(Shape shape);
    }
}