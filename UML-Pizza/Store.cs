using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class Store
    {

        public void Start()
        {
            /*
             * De tre Pizzaer
             */
            Pizza pizza1 = new Pizza(2, "vesio", "med lidt af hvert", 34);
            Pizza pizza2 = new Pizza(4, "quatro statione", "med fire foskellige fyld", 38);
            Pizza pizza3 = new Pizza(6, "BigMama", "med lidt af det hele", 45);


            /*
             * De tre kunder
             */
            Kunde kundeAnonym = new Kunde();
            Kunde kunde1 = new Kunde("Peter", "22334455");
            Kunde kunde2 = new Kunde("Jakob", "11223355");


            /*
             * De tre ordre
             */
            Ordre ordre1 = new Ordre(kunde1, pizza2);
            Ordre ordre2 = new Ordre(kundeAnonym, pizza1);
            Ordre ordre3 = new Ordre(kunde2, pizza3);


            /*
             * Udskrivning
             */

            Console.WriteLine("De tre pizzaer");
            Console.WriteLine(pizza1);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);
            Console.WriteLine(); // blank linje

            Console.WriteLine("De tre kunder");
            Console.WriteLine(kundeAnonym);
            Console.WriteLine(kunde1);
            Console.WriteLine(kunde2);
            Console.WriteLine(); // blank linje

            Console.WriteLine("De tre ordre");
            Console.WriteLine(ordre1);
            Console.WriteLine(ordre2);
            Console.WriteLine(ordre3);
            Console.WriteLine(); // blank linje

        }
    }
}
