using System;
using System.Drawing;
using Patterns.packages.behavioral.observer;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class ObserverPattern: IPattern
    {
        private ColorObserver _colorObserver;
        private Shape _circle;
        
        public void Run()
        {
            InitializeFields();
            TestObserver();
        }

        private void TestObserver()
        {
            _circle.color = Color.Chartreuse;
            Console.WriteLine(_circle.color);
            AddShapesToObserver();
            _colorObserver.UpdateShapeColor(Color.Aqua);
            Console.WriteLine(_circle.color);
        }

        private void AddShapesToObserver()
        {
            _colorObserver.AddShape(new RasterCircle());
            _colorObserver.AddShape(new VectorCircle());
            _colorObserver.AddShape(new Square());
            
        }

        private void InitializeFields()
        {
            _colorObserver = new ColorObserver();
            _circle = new Circle();
        }
    }
}