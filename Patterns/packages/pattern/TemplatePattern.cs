using Patterns.packages.behavioral.template;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class TemplatePattern: IPattern
    {
        public void Run()
        {
            TestGridTemplate(new CircleGrid());
            TestGridTemplate(new SquareGrid());
        }

        private void TestGridTemplate(GridTemplate gridTemplate)
        {
            gridTemplate.GenerateGrid(2, 2);
        }
    }
}