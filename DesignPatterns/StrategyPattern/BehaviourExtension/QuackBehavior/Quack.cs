using System;

namespace DesignPatterns.StrategyPattern.BehaviourExtension.QuackBehavior
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
