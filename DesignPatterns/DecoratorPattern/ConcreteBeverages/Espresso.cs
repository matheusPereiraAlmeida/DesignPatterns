using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            base.description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
