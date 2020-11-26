using System;
using Patterns.packages.creational.singleton;
using Patterns.packages.interfaces;

namespace Patterns.packages.pattern
{
    public class SingletonPattern: IPattern
    {
        public void Run()
        {
            Console.WriteLine(Application.getInstance());
        }
    }
}