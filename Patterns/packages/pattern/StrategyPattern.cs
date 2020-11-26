using Patterns.packages.behavioral.strategy;
using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class StrategyPattern: IPattern
    {
        private Shape _shape;
        private IStrategy _strategy;
        
        public void Run()
        {
            _shape = new Circle();
            TestStrategies();
        }

        private void TestStrategies()
        {
            TestNewStrategy(new HorizontalGradientStrategy(_shape));
            TestNewStrategy(new VerticalGradientStrategy(_shape));
        }

        private void TestNewStrategy(IStrategy strategy)
        {
            _strategy = strategy;
            _strategy.Execute();
        }
    }
}