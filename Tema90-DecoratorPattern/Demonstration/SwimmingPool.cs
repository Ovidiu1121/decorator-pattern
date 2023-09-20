using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public class SwimmingPool:Luxury
    {
        public SwimmingPool(Home home):base(home)
        {
            this.luxuryCost = 55000;
            Console.WriteLine(" For a swimming pool, you pay an extra $" + this.luxuryCost);
        }

        public override double getPrice()
        {
            return home.getPrice() + luxuryCost;
        }
    }
}
