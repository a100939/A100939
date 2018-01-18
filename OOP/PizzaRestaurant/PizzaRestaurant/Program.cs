using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza[] pizzas = new Pizza[5];
            int position = 0;

            int option = 0;

            do
            {
                Console.WriteLine("Choose one of the following:\n1. Add to Order\n" +
                    "2. Print Receipt\n3. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option){
                    case 1:
                        if (position < 5)
                        {

                            pizzas[position] = AddToOrder();
                            position++;

                        }
                        else
                        {
                            Console.WriteLine("Maximum order reached!!!");
                        }
                        break;
                    case 2:PrintReceipt(pizzas, position);
                        break;
                    case 3: Console.WriteLine("Bye");
                        break;
                    default: Console.WriteLine("Wrong Option!!");
                        break;

                }


            } while (option != 3);

        }

        public static void PrintReceipt(Pizza[] p, int pos)
        {
            Console.WriteLine("\n\nReceipt:\n");

            double total = 0;

            for(int i = 0; i < pos; i++)
            {
                Console.WriteLine(p[i].TotalPrice());
                total += p[i].TotalPrice();
            }

            Console.WriteLine("*************\n" + total + "\n\n");


        }

        public static Pizza AddToOrder()
        {

            Pizza p = new Pizza();

            Console.Write("Pizza Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Pizza Profit: ");
            p.Profit = Convert.ToInt32(Console.ReadLine());

            int totalIng = 0;
            int ingOption = 0;

            PizzaWithIngredients pi = null;

            do
            {
                Console.WriteLine("\nAdd Ingredients?\n1. Yes\n2. No");
                ingOption = Convert.ToInt32(Console.ReadLine());

                if(ingOption == 1)
                {
                    
                    if(pi == null)
                    {
                        pi = new PizzaWithIngredients(p.Price, p.Profit);
                    }

                    Ingredients i = new Ingredients();

                    Console.Write("Ingredient Name: ");
                    i.Name = Console.ReadLine();

                    Console.Write("Ingredient Price: ");
                    i.Price = Convert.ToDouble(Console.ReadLine());

                    pi.addIngredient(i);
                    totalIng++;
                }

            } while ((totalIng != 3) && (ingOption != 2));


            if (pi == null)
            {
                return p;
            }
            else
            {
                return pi;
            }

        }
    }
}

