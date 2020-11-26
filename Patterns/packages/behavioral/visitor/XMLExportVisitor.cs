using System;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.visitor
{
    public class XMLExportVisitor: IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            //Get coordinates of the ceenter
            //Export to XML
            PrintSucsess(circle);
        }

        public void VisitSquare(Square square)
        {
            //Get coordinates of the edges
            //Export to XML
            PrintSucsess(square);
        }

        private void PrintSucsess(Shape shape)
        {
            Console.WriteLine("Exported to XML : " + shape.GetType());
        }
    }
}