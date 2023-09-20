using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration2
{
    public class Pizza:IProduct
    {

        public double GetCost()
        {
            return 10.0;
        }

        public string GetDescription()
        {
            return "Pizza";
        }


    }
}
