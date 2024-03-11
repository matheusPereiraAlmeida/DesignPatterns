using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";
        public String getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}
