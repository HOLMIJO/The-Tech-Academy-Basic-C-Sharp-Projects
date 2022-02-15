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
        }
    }
}
