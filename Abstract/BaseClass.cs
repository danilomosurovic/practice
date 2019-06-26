using System;

namespace practice.Abstract
{
    public abstract class BaseClass
    {
        public virtual void PrintToConsole(string text)
        {
            Console.WriteLine(text);
        }
        public abstract void PrintToConsoleToOverride(string text);
      
    }

}