using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class Program
    {
        static void Main(string[] args)
        {

            Item i = new Item("Socks", "Smelly socks", 5.50);

            FoodItem fi = new FoodItem("Cheese", "Aged Chees", 10.25, new DateTime(2018, 07, 30));

            Item[] items = new Item[2];
            items[0] = i;
            items[1] = fi;

            foreach(Item it in items)
            {
                Console.WriteLine(it);
                Console.WriteLine("\n\n");
            }
 

            Console.ReadLine();
        }
    }
}
