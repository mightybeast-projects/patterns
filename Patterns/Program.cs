using Patterns.packages.interfaces;
using Patterns.packages.pattern;

namespace Patterns
{
    public static class Program{
        private static IPattern _pattern;

        public static void Main(){
            _pattern = new SingletonPattern();
            _pattern.Run();
        }
    }
}