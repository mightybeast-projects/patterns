
using System;
using Patterns.packages.behavioral.visitor;
using ICloneable = Patterns.packages.interfaces.ICloneable;

namespace Patterns.packages.entity
{
    public class Circle: Shape, ICloneable
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");        
        }

        public ICloneable Clone()
        {
            return new Circle();
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}