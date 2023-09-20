using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration2
{
    public class Client
    {

        public Client()
        {
            IProduct pizza = new Pizza();
            Console.WriteLine("Pizza: " + pizza.GetDescription() + ", Cost: " + pizza.GetCost() + " lei");

            // Adăugăm brânză la pizza
            IProduct pizzaCuBranza = new Cheese(pizza);
            Console.WriteLine("Pizza cu branza: " + pizzaCuBranza.GetDescription() + ", Cost: " + pizzaCuBranza.GetCost() + " lei");

            // Adăugăm și ciuperci
            IProduct pizzaCuBranzaSiCiuperci = new Mushroom(pizzaCuBranza);
            Console.WriteLine("Pizza cu branza si ciuperci: " + pizzaCuBranzaSiCiuperci.GetDescription() + ", Cost: " + pizzaCuBranzaSiCiuperci.GetCost() + " lei");
        }

    }
}
