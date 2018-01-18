using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class HourlyEmployee : Employee
    {

        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value;  }
        }

        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public HourlyEmployee()
        {
            rate = 0;
            hours = 0;
        }

        public HourlyEmployee(string iName, string iSurname, int iSSN, string iRole, int iHours, double iRate)
            :base(iName, iSurname, iSSN, iRole)
        {
            hours = iHours;
            rate = iRate;
        }


        public override double GetWage()
        {
            return hours * rate;
        }

    }
}
