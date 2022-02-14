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
            // This sets a variable of math0 and instantiates the MathOps class.
            MathOps math0 = new MathOps();
            // This sets a variable of math1 and instantiates the MathOps class.
            MathOps math1 = new MathOps();
            // This variable calls the Addition method in MathOps class and passes in two numbers.
            math0.Addition(6, 4);
            // This calls the Addition method and specifies the parameters by name
            math1.Addition(num1: 22, num2: 12);
        }
    }
}
