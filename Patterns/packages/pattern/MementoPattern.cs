using System.Drawing;
using Patterns.packages.behavioral.memento;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class MementoPattern: IPattern
    {
        private Shape _shape;
        private MementoCaretaker _mementoCaretaker;
        
        public void Run()
        {
            InitializeShape();
            TestMemento();
        }

        private void TestMemento()
        {
            ChangeShapeColorAndSave(Color.OldLace);
            ChangeShapeColorAndSave(Color.Azure);
            ChangeShapeColor(Color.Olive);
            _mementoCaretaker.Undo();
            _mementoCaretaker.Undo();
            
        }

        private void ChangeShapeColor(Color color)
        {
            _shape.color = color;
        }

        private void ChangeShapeColorAndSave(Color color)
        {
            _shape.color = color;
            _mementoCaretaker.SaveShapeColor();
        }

        private void InitializeShape()
        {
            _shape = new Circle();
            _mementoCaretaker = new MementoCaretaker(_shape);
        }
    }
}