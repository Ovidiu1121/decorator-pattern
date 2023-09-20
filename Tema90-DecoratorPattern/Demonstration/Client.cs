using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema90_DecoratorPattern.Demonstration
{
    public class Client
    {
        public Client()
        {
            Console.WriteLine("***Using wrappers in different scenarios.***\n");

            Console.WriteLine("Scenario-1: Making a basic home with standard facilities.");
            Home home1 = new BasicHome();
            Console.WriteLine("Total cost: $" + home1.getPrice());

            Console.WriteLine("\nScenario-2: Making a basic home. Then adding a playground.");
            Home home2 = new BasicHome();
            home2 = new PlayGround(home2);
            Console.WriteLine("Total cost: $" + home2.getPrice());

            Console.WriteLine("\nScenario-3: Making a basic home. Then adding two playgrounds one-by-one.");
            Home home3 = new BasicHome();
            home3 = new PlayGround(home3);
            home3 = new PlayGround(home3);
            Console.WriteLine("Total cost: $" + home3.getPrice());

            Console.WriteLine("\nScenario-4: Making a basic home. Then adding one additional playground and swimming pool.");
            Home home4 = new BasicHome();
            home4 = new PlayGround(home4);
            home4 = new SwimmingPool(home4);
            Console.WriteLine("Total cost: $" + home4.getPrice());

            Console.WriteLine("\nScenario-5: Adding a swimming pool and then a playground to a basic home.");
            Home home5 = new BasicHome();
            home5 = new SwimmingPool(home5);
            home5 = new PlayGround(home5);
            Console.WriteLine("Total cost: $" + home5.getPrice());

            Console.WriteLine("\nScenario-6: Making an advanced home now.");
            Home home6 = new AdvancedHome();
            Console.WriteLine("Total cost: $" + home6.getPrice());

            Console.WriteLine("\nScenario-7: Making an advanced home. Then adding one additional playground to it.");
            Home home7 = new AdvancedHome();
            home7 = new PlayGround(home7);
            Console.WriteLine("Total cost: $" + home7.getPrice());

            Console.WriteLine("\nScenario-8: Making an advanced home. Then adding one additional playground and one swimming pool to it.");
            Home home8 = new AdvancedHome();
            home8 = new PlayGround(home8);
            home8 = new SwimmingPool(home8);
            Console.WriteLine("Total cost: $" + home8.getPrice());
        }

    }
}
