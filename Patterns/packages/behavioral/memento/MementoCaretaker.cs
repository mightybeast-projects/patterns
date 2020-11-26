using System;
using System.Collections.Generic;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.memento
{
    public class MementoCaretaker
    {
        private Shape _shape;
        private Stack<ColorMemento> _history;

        public MementoCaretaker(Shape shape)
        {
            _shape = shape;
            _history = new Stack<ColorMemento>();
        }

        public void SaveShapeColor()
        {
            var colorMemento = _shape.Save();
            _history.Push(colorMemento);
            Console.WriteLine(_shape.color);
        }

        public void Undo()
        {
            var colorMemento = _history.Pop();
            _shape.Restore(colorMemento);
            Console.WriteLine(_shape.color);

        }
    }
}