using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // This instantiates the new Employee as a string
            Employee<string> employee = new Employee<string>();
            // This is a list of string with variable of thingys
            List<string> thingys = new List<string>()
            {
                "House", "Ball", "Car"
            };
            // This takes from the Employee class and things method. 
            employee.things = thingys;
            // This says to print each item in the list to the console.
            foreach (string thing in employee.things)
            {
                // This prints to console.
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
