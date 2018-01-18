using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurant
{
    public class PizzaWithIngredients : Pizza
    {

        private Ingredients[] ingredients;

        public Ingredients[] Ingredients
        {
            get { return ingredients; }
            private set { ingredients = value; }
        }

        private int totalIngredients;

        public int TotalIngredients
        {
            get { return totalIngredients; }
            set { totalIngredients = value; }
        }

        public PizzaWithIngredients()
        {
            ingredients = new Ingredients[3];
            TotalIngredients = 0;
        }

        public PizzaWithIngredients(double iPrice, int iProfit)
            : base(iPrice, iProfit)
        {
            ingredients = new Ingredients[3];
            TotalIngredients = 0;
        }

        public void addIngredient(Ingredients i)
        {
            ingredients[TotalIngredients] = i;
            TotalIngredients++;
        }

        public override double TotalPrice()
        {
            double total = 0;

            for(int i = 0; i < totalIngredients; i++) {
                total += Ingredients[i].Price;
            }

            return base.TotalPrice() + total;
        }

    }
}
