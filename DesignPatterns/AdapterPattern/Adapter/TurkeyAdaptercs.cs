using DesignPatterns.AdapterPattern.Entities;
using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void PerformFlyBehaviour()
        {
            turkey.Fly();
        }

        public void PerformQuack()
        {
            turkey.Gobble();
        }
    }
}
