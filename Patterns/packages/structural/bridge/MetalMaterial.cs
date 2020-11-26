using System;

namespace Patterns.packages.structural.bridge
{
    public class MetalMaterial: IShapeMaterial
    {
        public void ApplyMaterial()
        {
            Console.WriteLine("Applying metal material");
        }
    }
}