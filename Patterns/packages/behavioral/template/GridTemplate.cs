using Patterns.packages.entity;

namespace Patterns.packages.behavioral.template
{
    public abstract class GridTemplate
    {
        protected Shape _gridTileShape;

        public void GenerateGrid(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    InitializeNewTileShape();
                    DrawInitializedShape();
                }
            }
        }

        private void DrawInitializedShape() {_gridTileShape.Draw();}

        protected virtual void InitializeNewTileShape()
        {
            //Some basic grid functionality
        }
        
        
    }
}