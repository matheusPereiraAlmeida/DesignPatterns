using System;

namespace DesignPatterns.StrategyPattern.BehaviourExtension.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No flying at all");
        }
    }
}
