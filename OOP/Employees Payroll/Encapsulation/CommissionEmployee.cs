using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class CommissionEmployee : Employee
    {
        private double sales;
        
        public double Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        private int rate; //percentage

        public int Rate {
            get { return rate; }
            set { rate = value; }
        }

        public CommissionEmployee()
        {
            rate = 0;
            sales = 0;
        }

        public CommissionEmployee(string iName, string iSurname, int iSSN, string iRole, double iSales, int iRate)
            :base(iName, iSurname, iSSN, iRole)
        {
            sales = iSales;
            rate = iRate;
        }

        public override double GetWage()
        {
            return (sales / 100) * rate;
        }

    }
}
