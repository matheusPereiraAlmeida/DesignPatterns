using System;

namespace DesignPatterns.StrategyPattern.BehaviourExtension.FlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}
