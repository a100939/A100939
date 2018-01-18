using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {

        static void Main(string[] args)
        {

            SalariedEmployee se = new SalariedEmployee("Joe", "Abela", 123456, "Director", 2500);
            HourlyEmployee he = new HourlyEmployee("Mike", "Borg", 22222, "Driver", 20, 15.23);
            CommissionEmployee ce = new CommissionEmployee("Jane", "Peters", 3333, "Agent", 20000, 10);
            BasePlusCommission bpc = new BasePlusCommission("Vanessa", "Camilleri", 4444, "Agent", 10000, 6, 800);

            Employee[] employees = new Employee[4];

            employees[0] = se;
            employees[1] = he;
            employees[2] = ce;
            employees[3] = bpc;

            foreach(Employee e in employees)
            {
                Console.WriteLine(e.Name + " " + e.Surname + " : " + e.GetWage());
            }

            Console.ReadLine();

        }
    }
}
