using Patterns.packages.behavioral.visitor;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class VisitorPattern: IPattern
    {
        private IVisitor _visitor;
        
        public void Run()
        {
            TestXMLEXporter();
        }

        private void TestXMLEXporter()
        {
            InitializeExporter();
            ExportShape(new Square(), _visitor);
            ExportShape(new Circle(), _visitor);
        }

        private void ExportShape(Shape shape, IVisitor visitor)
        {
            shape.Accept(visitor);
        }

        private void InitializeExporter()
        {
            _visitor = new XMLExportVisitor();
        }
    }
}