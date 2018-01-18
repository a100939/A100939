using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeQualifications
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[5];
            int pos = 0;
            int option = 0;

            do
            {

                Console.WriteLine("Choose one of the following: \n1. Add Employee\n2. List all Employees, \n3. Exit");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: 
                        if(pos < 5)
                        {
                            employees[pos] = addEmployee();
                            pos++;
                        }
                        else
                        {
                            Console.WriteLine("Maximum Reached!!");
                        }
                        break;
                    case 2:
                        listEmployee(employees, pos);
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default: Console.WriteLine("Incorrect Input!!");
                        break;
                }

            } while (option != 3);

        }

        public static void listEmployee(Employee[] emps, int p)
        {
            for(int i = 0; i < p; i++)
            {
                Console.WriteLine(emps[i]);
            }
        }

        public static Employee addEmployee()
        {

            Console.WriteLine("Choose Employee type: \n1. Employee\n2. Employee with Overtime");
            int empType = Convert.ToInt32(Console.ReadLine());

            Employee e = new Employee();

              Console.Write("Employee's name: ");
              e.Name = Console.ReadLine();

              Console.Write("Employee's Salary: ");
              e.Salary = Convert.ToDouble(Console.ReadLine());

              double overtime = 0;

              if(empType == 2)
              {
                  Console.Write("Employee's Overtime: ");
                  overtime = Convert.ToDouble(Console.ReadLine());
              }

              int addQuali = 0;

              do
              {
                  Console.WriteLine("Add Qualification?: \n1. Yes\n2. No");
                  addQuali = Convert.ToInt32(Console.ReadLine());

                  if(addQuali == 1)
                  {
                      if (e.QualiPos < 3)
                      {
                          Qualification q = new Qualification();
                          Console.Write("Qualification's title: ");
                          q.Title = Console.ReadLine();

                          Console.Write("Qualification's Year: ");
                          q.Year = Convert.ToInt32(Console.ReadLine());

                          e.addQualification(q);
                      }
                      else
                      {
                          Console.WriteLine("Employee Already has 3 qualifications");
                          break;
                      }

                  }
                  else if( addQuali == 2)
                  {
                      Console.WriteLine("No Qualifications Added");
                  }
                  else
                  {
                      Console.WriteLine("Wong Input");
                  }

              } while(addQuali != 2);

              if(empType == 1)
              {
                  return e;
              }
              else
              {

                EmployeePlusOvertime epo = new EmployeePlusOvertime(e.Name, e.Salary, overtime);
                return epo;
              }
        }
    }
}
