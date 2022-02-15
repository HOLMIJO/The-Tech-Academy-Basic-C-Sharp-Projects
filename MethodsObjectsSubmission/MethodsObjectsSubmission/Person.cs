using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsSubmission
{
    public class Person
    {
        // This sets the FirstName and LastName properties as strings
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // This is the superclass method
        public void SayName()
        {
            // This line writes string message plus FirstName and LastName to the display.
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

    }
}
