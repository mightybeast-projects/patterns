using Patterns.packages.behavioral.state_machine;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class StateMachinePattern: IPattern
    {
        private IState _state;
        private Shape _shape;
        
        public void Run()
        {
            TestStateMachine();
        }

        private void TestStateMachine()
        {
            _shape = new Square();
            ApplyState(new CreatingState(_shape));
            ApplyState(new SavingState(_shape));
        }

        private void ApplyState(IState state)
        {
            _state = state;
            _shape.state = _state;
            _shape.ApplyState();
        }
    }
}