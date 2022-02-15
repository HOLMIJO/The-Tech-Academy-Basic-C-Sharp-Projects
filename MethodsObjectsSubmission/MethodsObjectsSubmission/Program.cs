using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the Employee class
            Employee Id = new Employee();
            // This gives object a first name as a string
            Id.FirstName = "Sample";
            // This gives object a last name as a string
            Id.LastName = "Student";
            // This calls superclass method on object
            Id.SayName();
            Console.ReadLine();
        }
    }
}
