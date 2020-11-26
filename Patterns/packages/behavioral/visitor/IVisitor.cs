using Patterns.packages.entity;

namespace Patterns.packages.behavioral.visitor
{
    public interface IVisitor
    {
        void VisitCircle(Circle circle);
        void VisitSquare(Square square);
    }
}