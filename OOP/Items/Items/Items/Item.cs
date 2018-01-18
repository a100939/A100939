using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class Item
    {

        private string name;
        
        public string Name {
            get { return name;}
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Item()
        {
            name = string.Empty;
            description = string.Empty;
            price = 0;
        }

        public Item(string iName, string iDescription, double iPrice)
        {
            name = iName;
            description = iDescription;
            price = iPrice;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nDescription" + Description + "\nPrice:" + Price;
        }

    }
}
