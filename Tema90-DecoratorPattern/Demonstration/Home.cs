using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public abstract class Home
    {
        public double basePrice;
        public double additionalCost;

        public Home()
        {
            // Minimum home price is $100000
            this.basePrice = 100000.0;
            this.additionalCost = 0.0;
        }
        public abstract double getPrice();

    }
}
