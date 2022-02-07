using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Below are 3 variables of string form and each include a short message to be displayed.
            string concat1 = "Hello, my name is Joseph Holmin. \n";
            string concat2 = "I am a student at The Tech Academy,\n";
            string concat3 = "in the Software Development Boot Camp.";
            // This variable converts the text to all Uppercase letters.
            concat2 = concat2.ToUpper();
            // The StringBuilder creates an easy way to concatenate string statements into a single paragraph.
            StringBuilder sb = new StringBuilder();
            // Here the StringBuilder builds the actual paragraph by the append method.
            sb.Append(concat1 + concat2 + concat3);
            // Here we are writing the concatenated paragraph to the display.
            Console.WriteLine(sb);
            // This command holds the results to the display.
            Console.ReadLine();
        }
    }
}
