using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration2
{
    public class Cheese:Pizza
    {

        private readonly IProduct product;

        public Cheese(IProduct product)
        {
            product = product;
        }

        public string GetDescription()
        {
            return product.GetDescription() + ", cu branza";
        }

        public double GetCost()
        {
            return product.GetCost() + 2.5; 
        }
    }
}
