using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public abstract class Luxury:Home
    {
        protected Home home;
        public double luxuryCost;
        public Luxury(Home home)
        {
            this.home = home;
        }   

        public override double getPrice()
        {
            return home.getPrice();
        }

    }
}
