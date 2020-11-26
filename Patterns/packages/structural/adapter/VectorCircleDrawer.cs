using Patterns.packages.entity;
using Patterns.packages.interfaces;

namespace Patterns.packages.structural.adapter
{
    public class VectorCircleDrawer
    {
        public void DrawVectorCircle(VectorCircle vectorCircle)
        {
            vectorCircle.DrawVector();
        }
    }
}