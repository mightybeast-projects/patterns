using System;
using System.Collections.Generic;
using System.Drawing;
using Patterns.packages.entity;

namespace Patterns.packages.behavioral.observer
{
    public class ColorObserver
    {
        private List<Shape> _shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void UpdateShapeColor(Color color)
        {
            foreach (var shape in _shapes)
            {
                shape.color = color;
                Console.WriteLine(shape.color);
            }
        }
    }
}