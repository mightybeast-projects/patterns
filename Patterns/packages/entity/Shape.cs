using System;
using System.Drawing;
using Patterns.packages.behavioral.mediator;
using Patterns.packages.behavioral.state_machine;
using Patterns.packages.behavioral.visitor;
using Patterns.packages.interfaces;
using Patterns.packages.structural.bridge;
using Patterns.packages.structural.composite;

namespace Patterns.packages.entity
{
    public abstract class Shape: IDrawable, IGroupable
    {
        protected int _verticiesCount;
        protected int _edgesCount;
        protected IShapeMaterial _shapeMaterial;
        protected Color _color;
        protected IMediator _mediator;
        protected IState _state;

        public int verticiesCount
        {
            get => _verticiesCount;
            set => _verticiesCount = value;
        }

        public int edgesCount
        {
            get => _edgesCount;
            set => _edgesCount = value;
        }

        public IShapeMaterial shapeMaterial
        {
            get => _shapeMaterial;
            set => _shapeMaterial = value;
        }

        public Color color
        {
            get => _color;
            set => _color = value;
        }

        public IMediator mediator
        {
            get => _mediator;
            set => _mediator = value;
        }

        public IState state
        {
            get => _state;
            set
            {
                _state = value;
            }
        }

        public abstract void Draw();
        
        public void Group(IGroupable groupable)
        {
            Console.WriteLine(GetType() + " grouped with " + groupable.GetType());
            
        }

        public ColorMemento Save()
        {
            return new ColorMemento(_color);
        }

        public void Restore(ColorMemento memento)
        {
            _color = memento.GetColor();
        }

        public void ApplyState()
        {
            _state.Apply();
        }

        public virtual void Accept(IVisitor visitor){}
    }

    public class ColorMemento
    {
        private Color _color;

        internal ColorMemento(Color color)
        {
            _color = color;
        }

        internal Color GetColor()
        {
            return _color;
        }
    }
}