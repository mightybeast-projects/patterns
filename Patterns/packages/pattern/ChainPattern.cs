using Patterns.packages.behavioral.chain_of_responsibility;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class ChainPattern: IPattern
    {
        private ShapeChecker _firstShapeChecker, _secondShapeChecker;
        private Shape _shape;

        public void Run()
        {
            InitializeShapeCheckers();
            CheckShapeCheckersOn(new Square());
            CheckShapeCheckersOn(new Circle());
        }

        private void InitializeShapeCheckers()
        {
            _firstShapeChecker = new SquareChecker();
            _secondShapeChecker = new CircleChecker();
            
            _firstShapeChecker.SetNext(_secondShapeChecker);
        }

        private void CheckShapeCheckersOn(Shape shape)
        {
            _shape = shape;
            _firstShapeChecker.Check(_shape);
        }
    }
}