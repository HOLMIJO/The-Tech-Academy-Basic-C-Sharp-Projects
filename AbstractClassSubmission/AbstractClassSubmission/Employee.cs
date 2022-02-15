using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person
    {
        // SayName method is implemented here, inherited properties from Person class.
        public override void SayName()
        {
            // Friendly message taking from the Person class through inheritance.
            Console.WriteLine("Greetings: {0} {1}!", firstName, lastName);
        }
    }
}
