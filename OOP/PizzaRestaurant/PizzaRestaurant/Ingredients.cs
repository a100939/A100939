using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurant
{
    public class Ingredients
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Ingredients()
        {
            Name = "";
            Price = 0.0;
        }

        public Ingredients(string iName, double iPrice)
        {
            Name = iName;
            Price = iPrice;
        }
    }
}
