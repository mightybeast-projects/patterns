using System;
using System.Collections.Generic;
using Patterns.packages.entity;

namespace Patterns.packages.structural.composite
{
    public class ShapeGroup: IGroupable
    {
        private List<IGroupable> _children;

        public ShapeGroup()
        {
            _children = new List<IGroupable>();
        }

        public void Group(IGroupable groupable)
        {
            Console.WriteLine(GetType() + " grouped with " + groupable.GetType());
            GroupAll();
        }

        public void GroupAll()
        {
            for (int i = 1; i < _children.Count; i++)
                GroupCurrentChild(i);
        }
        
        public void AddChild(IGroupable child)
        {
            _children.Add(child);
        }

        public void RemoveChild(IGroupable child)
        {
            _children.Remove(child);
        }

        private void GroupCurrentChild(int index)
        {
            IGroupable currentShape = _children[index];
            IGroupable previousShape = _children[index - 1];
            currentShape.Group(previousShape);
        }
    }
}