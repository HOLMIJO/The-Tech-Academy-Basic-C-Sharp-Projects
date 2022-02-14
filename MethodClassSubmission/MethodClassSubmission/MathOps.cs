using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    // Created Class of MathOps
    public class MathOps
    {
        // The public void Addition method takes 2 integers as parameters
        public void Addition(int num1, int num2)
        {
            // This sets an integer variable named result,
            // and does math operation on method arguments.
            int result = (num1 + num2) / 6;
            // This prints the result of the math operation to the screen.
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
