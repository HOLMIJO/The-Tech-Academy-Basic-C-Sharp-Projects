using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    // Creates abstract class
    public abstract class Person
    {
        // Properties of Person class set as strings
        public string firstName { get; set; }
        public string lastName { get; set; }

        // SayName method has no implementation here as it is abstract
        public abstract void SayName();
    }
}
