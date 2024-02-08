using System;

namespace DesignPatterns.StrategyPattern.BehaviourExtension.QuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
