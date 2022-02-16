using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This line instantiates a new employee from the Employee class.
            Employee employee = new Employee();
            // This line from the employee method gives a first name as a string.
            employee.firstName = "Sample";
            // This line from the employee method gives a last name as a string.
            employee.lastName = "Student";
            // This line calls the SayName method on the employee object.
            employee.SayName();
            // This line instantiates a new employee from the Employee class. 
            Employee employee1 = new Employee();
            // This line from the employee method gives a first name as a string.
            employee1.firstName = "Joseph";
            // This line from the employee method gives a last name as a string.
            employee1.lastName = "Holmin";
            // This calls the Quit method on the new employee.
            employee1.Quit(employee);
            // The employee2 is created and has access to the IQuittable interface through polymorphism.
            IQuittable employee2 = new Employee();
            // This employee2 has access to the quit method.
            employee2.Quit(employee);
        }
    }
}
