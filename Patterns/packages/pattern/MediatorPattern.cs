using Patterns.packages.behavioral.mediator;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class MediatorPattern: IPattern
    {
        private VectorCircle _vectorCircle;
        private VectorSquare _vectorSquare;
        private IMediator _mediator;
        
        public void Run()
        {
            InitializeShapes();
            InitializeMediator();
            TestMediator();
        }
        
        private void InitializeShapes()
        {
            _vectorCircle = new VectorCircle();
            _vectorSquare = new VectorSquare();
        }
        
        private void InitializeMediator()
        {
            _mediator = new TemplateMediator(_vectorCircle, _vectorSquare);
        }

        private void TestMediator()
        {
            _mediator.Notify(_vectorCircle);
            _mediator.Notify(_vectorSquare);
        }
    }
}