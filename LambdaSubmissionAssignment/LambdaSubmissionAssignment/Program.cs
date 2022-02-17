using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a list of all employees.
            List<Employee> Employee = new List<Employee>();
            // Each employee has a first and last name, as well as an Id.
            Employee Emp1 = new Employee();
            Emp1.FirstName = "Joseph";
            Emp1.LastName = "Holmin";
            Emp1.Id = 1;

            Employee Emp2 = new Employee();
            Emp2.FirstName = "Becca";
            Emp2.LastName = "Holmin";
            Emp2.Id = 2;

            Employee Emp3 = new Employee();
            Emp3.FirstName = "Brandon";
            Emp3.LastName = "Holmin";
            Emp3.Id = 3;

            Employee Emp4 = new Employee();
            Emp4.FirstName = "Joe";
            Emp4.LastName = "Brown";
            Emp4.Id = 4;

            Employee Emp5 = new Employee();
            Emp5.FirstName = "Jacinto";
            Emp5.LastName = "Hernandez";
            Emp5.Id = 5;

            Employee Emp6 = new Employee();
            Emp6.FirstName = "Bill";
            Emp6.LastName = "Hale";
            Emp6.Id = 6;

            Employee Emp7 = new Employee();
            Emp7.FirstName = "Stephen";
            Emp7.LastName = "Patterson";
            Emp7.Id = 7;

            Employee Emp8 = new Employee();
            Emp8.FirstName = "Joe";
            Emp8.LastName = "Cool";
            Emp8.Id = 8;

            Employee Emp9 = new Employee();
            Emp9.FirstName = "Molly";
            Emp9.LastName = "Minton";
            Emp9.Id = 9;

            Employee Emp10 = new Employee();
            Emp10.FirstName = "Lauren";
            Emp10.LastName = "Henry";
            Emp10.Id = 10;
            
            // This adds each employee to the EmployeeList list.
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(Emp1);
            EmployeeList.Add(Emp2);
            EmployeeList.Add(Emp3);
            EmployeeList.Add(Emp4);
            EmployeeList.Add(Emp5);
            EmployeeList.Add(Emp6);
            EmployeeList.Add(Emp7);
            EmployeeList.Add(Emp8);
            EmployeeList.Add(Emp9);
            EmployeeList.Add(Emp10);

            // This creates the new "anewList" list.
            List<Employee> anewList = new List<Employee>();
            foreach (Employee employee in EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    anewList.Add(employee);
                }
            }
            Console.WriteLine("Employee named \"Joe\" has been found.");

            for (int i = 0; i < anewList.Count; i++)
            {
                Console.WriteLine(anewList[i].FirstName + " " + anewList[i].LastName + "\n");
            }

            // Here I've created another new list for Employee named Joe and use a lambda expression to find and add them to the list
            List<Employee> anewList1 = EmployeeList.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Employees named \"Joe\" include:");
            for (int j = 0; j < anewList1.Count; j++)
            {
                Console.WriteLine(anewList1[j].FirstName + " " + anewList1[j].LastName + "\n");
            }

            // Here I've created a new list for all of the Employee with Ids higher than five and use a lambda epxression to find and add them to the list
            List<Employee> fivePlus = EmployeeList.Where(x => x.Id > 5).ToList();
            Console.WriteLine("Employees with an Id greater than 5 include: ");
            for (int k = 0; k < fivePlus.Count; k++)
            {
                Console.WriteLine(fivePlus[k].FirstName + " " + fivePlus[k].LastName + "\n");
            }
            Console.ReadLine();






            
        }
    }
}
