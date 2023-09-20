using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration2
{
    public class Mushroom:Pizza
    {
        private readonly IProduct product;

        public Mushroom(IProduct product)
        {
            product = product;
        }

        public string GetDescription()
        {
            return product.GetDescription() + ", cu ciuperci";
        }

        public double GetCost()
        {
            return (product.GetCost() + 3); 
        }


    }
}
