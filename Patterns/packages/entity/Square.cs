using System;
using Patterns.packages.behavioral.visitor;
using ICloneable = Patterns.packages.interfaces.ICloneable;

namespace Patterns.packages.entity
{
    public class Square: Shape, ICloneable
    {
        public override void Draw()
        {
            Console.WriteLine("Draw square");
        }

        public ICloneable Clone()
        {
            return new Square();
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitSquare(this);
        }
    }
}