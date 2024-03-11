using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.ConcreteCondiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}
