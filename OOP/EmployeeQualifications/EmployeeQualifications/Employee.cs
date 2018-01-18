using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeQualifications
{
    class Employee
    {

        private int qualiPos = 0;

        public int QualiPos
        {
            get { return qualiPos;  }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private Qualification[] qualifications;

        public Employee()
        {
            Name = "";
            Salary = 1000;

            qualifications = new Qualification[3];
        }

        public Employee(string iName, double iSalary)
        {
            Name = iName;
            Salary = iSalary;

            qualifications = new Qualification[3];
        }

        public void addQualification(Qualification q)
        {
            qualifications[qualiPos] = q;
            qualiPos++;
        }

        public override string ToString()
        {

            string output = "Name: " + Name + "\nSalary: " + Salary;

            for(int i = 0; i < qualiPos; i++)
            {
                output += "\n" + qualifications[i];
            }

            return output;
        }

    }
}
