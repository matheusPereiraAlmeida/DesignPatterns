using DesignPatterns.StrategyPattern.BehaviourExtension.FlyBehavior;
using DesignPatterns.StrategyPattern.Entities;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //teste com o StrategyPattern
            MallardDuck a = new MallardDuck();
            a.SetFlyBehaviour(new FlyNoWay());
            a.PerformFlyBehaviour();
        }
    }
}
