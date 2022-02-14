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
            // This sets a variable of math1 and instantiates the MathOps method
            MathOps math1 = new MathOps();
            // This calls the method and specifies the parameters by name
            math1.Addition(num1: 22, num2: 25);
        }
    }
}
