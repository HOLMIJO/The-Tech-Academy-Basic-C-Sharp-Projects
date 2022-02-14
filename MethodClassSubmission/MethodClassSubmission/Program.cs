using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sets a variable of addItUp and instantiates the MathOps method
            var addItUp = new MathOps();
            // This passes in two numbers
            int num1 = 22;
            int num2 = 25;
            // This calls the method and specifies the parameters by name
            addItUp.Addition(num1, num2);
            // This displays the second integer to the screen.
            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }
}
