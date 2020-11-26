using Patterns.packages.entity;

namespace Patterns.packages.creational.factory
{
    public abstract class ShapeFactory
    {
        protected Shape _shape;

        public Shape GetShape()
        {
            return _shape;
        }
        
        public abstract void CreateShape();
    }
}