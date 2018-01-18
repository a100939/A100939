using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeQualifications
{
    class EmployeePlusOvertime : Employee
    {

        private double overtime;

        public double Overtime
        {
            get { return overtime; }
            set { overtime = value; }
        }

        public EmployeePlusOvertime()
        {
            overtime = 200;
        }

        public EmployeePlusOvertime(string iName, double iSalary, double iOvertime)
            :base (iName, iSalary)
        {
            overtime = iOvertime;
        }

        public override string ToString()
        {
            return base.ToString() + "\nOvertime: " + Overtime;
        }
    }
}
