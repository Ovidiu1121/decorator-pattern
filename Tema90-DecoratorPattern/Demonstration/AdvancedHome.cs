using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public class AdvancedHome:Home
    {
        public AdvancedHome()
        {
            additionalCost = 25000;
            Console.WriteLine(" It becomes an advanced home with more facilities.");


            Console.WriteLine(" You need to pay $" +this.getPrice() + " for this.");
        }

        public override double getPrice()
        {
            return basePrice + additionalCost;
        }


    }
}
