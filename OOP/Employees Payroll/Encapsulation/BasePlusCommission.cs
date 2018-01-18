using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class BasePlusCommission : CommissionEmployee
    {
        private double baseSalary;

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public BasePlusCommission()
        {
            baseSalary = 0;
        }

        public BasePlusCommission(string iName, string iSurname, int iSSN, string iRole, 
            double iSales, int iRate, double iBaseSalary)
            :base(iName, iSurname, iSSN, iRole, iSales, iRate)
        {
            baseSalary = iBaseSalary;
        }

        public override double GetWage()
        {
            return base.GetWage() + baseSalary;
        }
    }
}
