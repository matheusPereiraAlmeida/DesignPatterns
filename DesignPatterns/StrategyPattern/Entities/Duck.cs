using DesignPatterns.StrategyPattern.BehaviourExtension.FlyBehavior;
using DesignPatterns.StrategyPattern.BehaviourExtension.QuackBehavior;
using DesignPatterns.StrategyPattern.Interfaces;
using System;

namespace DesignPatterns.StrategyPattern.Entities
{
    public class Duck : IDuck
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
