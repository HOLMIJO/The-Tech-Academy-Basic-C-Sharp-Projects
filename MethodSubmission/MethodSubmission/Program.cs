using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This instantiates the method "plus1" from the MethodClass class.
                var plus1 = new MethodClass();
                // Message asks for user input.
                Console.WriteLine("Please enter a whole number, then press ENTER.");
                // This assigns an integer type for the first value.
                int int1 = Convert.ToInt32(Console.ReadLine());
                // Message asks for user input. Actual input is optional.
                Console.WriteLine("Please enter another whole number, (optional), then press ENTER.");
                // This assigns an integer type for the second value.
                int int2;
                // This assigns an integer type for the result.
                int sum;
                // This says if second value is an integer use it.
                if (int.TryParse(Console.ReadLine(), out int2))
                {
                    // This will make the sum value one plus value two.
                    // Using the plus1 method taking the 2 user input values.
                    sum = plus1.Plus1(int1, int2);
                }
                // This says if no second value for user input is given, then do this.
                else
                {
                    // This will be the sum of a single input, plus the parameter value (21) stored in the method
                    sum = plus1.Plus1(int1);
                }
                // Friendly message for user including values and sum.
                Console.WriteLine("The sum of {0} and {1} is: {2}.", int1, int2, sum);
                Console.ReadLine();
            }
            // If a FormatException occurs...
            catch (FormatException)
            {
                // ... User is given friendly message.
                Console.WriteLine("ERROR: Mustchoose a number greater than zero.");
            }
            // This block will run at the end regardless of the messages.
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
