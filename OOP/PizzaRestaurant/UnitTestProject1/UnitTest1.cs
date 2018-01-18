using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaRestaurant;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pizza p = new Pizza(5.50, 10);

            Assert.AreEqual(6.05, p.TotalPrice());
        }

        [TestMethod]
        public void TestWithIngredients()
        {
            PizzaWithIngredients p = new PizzaWithIngredients(5.50, 10);

            p.addIngredient(new Ingredients("Peperoni", 1));
            p.addIngredient(new Ingredients("Onions", 0.50));

            Assert.AreEqual(7.55, p.TotalPrice());
        }
    }
}
