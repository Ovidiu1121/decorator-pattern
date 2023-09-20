using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public class PlayGround : Luxury
    {
        public PlayGround(Home home) : base(home)
        {
            this.luxuryCost = 20000;
            Console.WriteLine("For a playground, you pay an extra $" + this.luxuryCost);
        }

        public override double getPrice()
        {
            return home.getPrice() + this.luxuryCost;
        }

    }
}
