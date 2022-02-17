using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        public static string Names { get; private set; }

        static void Main(string[] args)
        {
            List<String> Employees = new List<String>();
            // Each employee should has a first and last name, as well as an Id
            Employees Emp1 = new Employees();
            Emp1.FirstName = "Joseph";
            Emp1.LastName = "Holmin";
            Emp1.Id = 10;

            Employees Emp2 = new Employees();
            Emp2.FirstName = "Becca";
            Emp2.LastName = "Holmin";
            Emp2.Id = 20;

            Employees Emp3 = new Employees();
            Emp3.FirstName = "Brandon";
            Emp3.LastName = "Holmin";
            Emp3.Id = 30;

            Employees Emp4 = new Employees();
            Emp4.FirstName = "Joe";
            Emp4.LastName = "Brown";
            Emp4.Id = 40;

            Employees Emp5 = new Employees();
            Emp5.FirstName = "Jacinto";
            Emp5.LastName = "Hernandez";
            Emp5.Id = 50;

            Employees Emp6 = new Employees();
            Emp6.FirstName = "Bill";
            Emp6.LastName = "Hale";
            Emp6.Id = 60;

            Employees Emp7 = new Employees();
            Emp7.FirstName = "Stephen";
            Emp7.LastName = "Patterson";
            Emp7.Id = 70;

            Employees Emp8 = new Employees();
            Emp8.FirstName = "Joe";
            Emp8.LastName = "Cool";
            Emp8.Id = 80;

            Employees Emp9 = new Employees();
            Emp9.FirstName = "Molly";
            Emp9.LastName = "Minton";
            Emp9.Id = 90;

            Employees Emp10 = new Employees();
            Emp10.FirstName = "Lauren";
            Emp10.LastName = "Henry";
            Emp10.Id = 100;

            List<string> EmployeesList = new List<string>();
            EmployeesList.Add(Emp1);
            EmployeesList.Add(Emp2);
            EmployeesList.Add(Emp3);
            EmployeesList.Add(Emp4);
            EmployeesList.Add(Emp5);
            EmployeesList.Add(Emp6);
            EmployeesList.Add(Emp7);
            EmployeesList.Add(Emp8);
            EmployeesList.Add(Emp9);
            EmployeesList.Add(Emp10);

            

        }
    }
}
