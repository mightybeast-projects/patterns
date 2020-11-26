using Patterns.packages.entity;

namespace Patterns.packages.behavioral.mediator
{
    public interface IMediator
    {
        void Notify(Shape sender);
    }
}