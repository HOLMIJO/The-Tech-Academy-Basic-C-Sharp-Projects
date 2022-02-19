using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    public class K9
    {
        // Here we chain the two constructors together.
        // This constructor helps to create a pup profile even before data is stored. 
        // This will create placeholding properties and assign placeholding values that can de overriden later in the program.
        public K9() : this(null, 0)
        {
        }
        // This creates the characteristics of our pups. 
        public K9(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Variable Amount of string type
        public string Name { get; set; }
        // Variable Amount of integer type
        public int Age { get; set; }
    }
}