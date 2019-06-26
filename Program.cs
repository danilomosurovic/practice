using System;
using practice.Abstract;
using practice.Interfaces;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var derivedClass = new DerivedClass1();
            var danilo = new KlasaKojaRadiNesto(derivedClass);
            danilo.radimnesto();
        }
    }
}
