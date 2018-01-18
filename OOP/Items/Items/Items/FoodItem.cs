using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class FoodItem : Item
    {

        private DateTime expiry;

        public DateTime Expiry
        {
            get { return expiry; }
            set { expiry = value; }
        }

        public FoodItem()
        {
            expiry = DateTime.Now;
        }

        public FoodItem(string iName, string iDescription, double iPrice, DateTime iExpire)
            : base(iName, iDescription, iPrice)
        {
            expiry = iExpire;
        }

        public override string ToString()
        {
            return base.ToString() + "\nExpiry: " + expiry;
        }

    }
}
