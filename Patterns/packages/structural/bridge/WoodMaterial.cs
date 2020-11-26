using System;

namespace Patterns.packages.structural.bridge
{
    public class WoodMaterial: IShapeMaterial
    {
        public void ApplyMaterial()
        {
            Console.WriteLine("Applying wood material");
        }
    }
}