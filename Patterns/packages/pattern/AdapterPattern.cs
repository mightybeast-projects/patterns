using Patterns.packages.entity;
using Patterns.packages.interfaces;
using Patterns.packages.structural.adapter;

namespace Patterns.packages.pattern
{
    public class AdapterPattern: IPattern
    {
        private VectorCircleDrawer _vectorCircleDrawer;
        private IVectorCircleAdapter _vectorCircleDrawerAdapter;
        
        public void Run()
        {
            _vectorCircleDrawer = new VectorCircleDrawer();
            _vectorCircleDrawerAdapter = new VectorCircleDrawerAdapter(_vectorCircleDrawer);
            _vectorCircleDrawerAdapter.ConvertAndDrawCircle(new RasterCircle());
        }
    }
}