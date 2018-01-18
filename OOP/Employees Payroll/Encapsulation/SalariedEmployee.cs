using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class SalariedEmployee : Employee
    {

        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public SalariedEmployee()
        {
            salary = 0;
        }

        public SalariedEmployee(string iName, string iSurname, int iSSN, string iRole, double iSalary)
               : base(iName, iSurname, iSSN, iRole)
        {
            salary = iSalary;
        }

        public override double GetWage()
        {
            return salary;
        }

    }
}
