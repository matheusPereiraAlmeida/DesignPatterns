using System;

namespace DesignPatterns.StrategyPattern.BehaviourExtension.QuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("MuteQuack");
        }
    }
}
