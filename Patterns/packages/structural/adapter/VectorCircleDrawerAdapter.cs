using Patterns.packages.entity;

namespace Patterns.packages.structural.adapter
{
    public class VectorCircleDrawerAdapter: IVectorCircleAdapter
    {
        private VectorCircleDrawer _vectorDrawer;

        public VectorCircleDrawerAdapter(VectorCircleDrawer vectorDrawer)
        {
            _vectorDrawer = vectorDrawer;
        }

        public void ConvertAndDrawCircle(RasterCircle shape)
        {
            //Convert raster circle to vector
            VectorCircle vectorCircle = new VectorCircle();
            _vectorDrawer.DrawVectorCircle(vectorCircle);
        }
    }
}