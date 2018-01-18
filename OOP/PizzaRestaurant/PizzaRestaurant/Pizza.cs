using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurant
{
    public class Pizza
    {
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int profit;

        public int Profit
        {
            get { return profit; }
            set { profit = value; }
        }

        public Pizza()
        {
            Price = 5.50;
            Profit = 10;
        }

        public Pizza(double iPrice, int iProfit)
        {
            Price = iPrice;
            Profit = iProfit;
        }

        public virtual double TotalPrice()
        {
            return (price / 100) * (profit + 100);
        }
    }
}
