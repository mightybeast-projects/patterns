using Patterns.packages.entity;

namespace Patterns.packages.behavioral.mediator
{
    public class TemplateMediator: IMediator
    {
        private VectorCircle _vectorCircle;
        private VectorSquare _vectorSquare;

        public TemplateMediator(VectorCircle vectorCircle, VectorSquare vectorSquare)
        {
            _vectorCircle = vectorCircle;
            _vectorSquare = vectorSquare;
            _vectorCircle.mediator = this;
            _vectorSquare.mediator = this;
        }

        public void Notify(Shape sender)
        {
            if (sender == _vectorCircle)
                ReactOnVectorCircle();
            if (sender == _vectorSquare)
                ReactOnVectorSquare();
        }

        private void ReactOnVectorSquare()
        {
            _vectorSquare.DrawVector();
        }

        private void ReactOnVectorCircle()
        {
            _vectorCircle.DrawVector();
        }
    }
}