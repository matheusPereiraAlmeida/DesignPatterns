using DesignPatterns.StrategyPattern.BehaviourExtension.FlyBehavior;
using DesignPatterns.StrategyPattern.BehaviourExtension.QuackBehavior;
using System;

namespace DesignPatterns.StrategyPattern.Entities
{
    public abstract class Duck
    {
        IFlyBehavior _flyBehaviour;
        IQuackBehavior _quackBehaviour;

        public void SetQuackBehaviour(IQuackBehavior quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }
        public void SetFlyBehaviour(IFlyBehavior flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }

        public void PerformFlyBehaviour()
        {
            _flyBehaviour.Fly();
        }

        public void Display()
        {
            Console.WriteLine("Display duck");
        }
    }
}
