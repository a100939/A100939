using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public abstract class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }

        }

        private int ssn;

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public Employee()
        {
            name = string.Empty;
            surname = string.Empty;
            ssn = 0;
            role = "Clerk";
        }

        public Employee(string iName, string iSurname, int iSSN, string iRole )
        {
            name = iName;
            surname = iSurname;
            ssn = iSSN;
            role = iRole;
        }

        public abstract double GetWage();


    }
}
