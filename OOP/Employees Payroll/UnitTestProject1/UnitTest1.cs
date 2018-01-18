using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encapsulation;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHourlyWage()
        {
            HourlyEmployee he = new HourlyEmployee("Joe", "Borg", 12345, "Driver" ,10, 5.0);

            Assert.AreEqual(50.0, he.GetWage());



        }
    }
}
