namespace Patterns.packages.creational.singleton
{
    public class Application
    {
        private static Application INSTANCE;
        
        private Application(){}

        public static Application getInstance()
        {
            if(INSTANCE == null)
                INSTANCE = new Application();
            return INSTANCE;
        }
    }
}