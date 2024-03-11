using DesignPatterns.AdapterPattern.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern.Entities
{
    public class Turkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I can fly and I'm a turkey");
        }

        public void Gobble()
        {
            Console.WriteLine("I dont quack I gobble");
        }
    }
}
