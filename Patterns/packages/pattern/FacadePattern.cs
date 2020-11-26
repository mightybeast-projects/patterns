using Patterns.packages.interfaces;
using Patterns.packages.structural.facade;

namespace Patterns.packages.pattern
{
    public class FacadePattern: IPattern
    {
        private ShapeManager _shapeManager;
        
        public void Run()
        {
            _shapeManager = new ShapeManager();
            _shapeManager.DrawSquareAndCircle();
            _shapeManager.DrawTwoCircles();
        }
    }
}