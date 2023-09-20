using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public class BasicHome:Home
    {
        public BasicHome()
        {
            // No additional cost for a basic home.
            Console.WriteLine(" The basic home with some standard facilities are ready.");

            Console.WriteLine(" You need to pay $" + this.getPrice() + " for this.");
        }

        public override double getPrice()
        {
            // There is no additional cost for a basic home
            // So, returning the basic price is sufficient.
            return basePrice;
        }
    }
}
