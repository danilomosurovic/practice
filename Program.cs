using System;
using practice.Abstract;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var derivedClass = new DerivedClass();
            derivedClass.PrintToConsole("Danilo");
        }
    }
}
