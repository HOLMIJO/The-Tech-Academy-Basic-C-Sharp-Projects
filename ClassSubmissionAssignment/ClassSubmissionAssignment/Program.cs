using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            // This instantiates the MathClass class.
            MathClass math1 = new MathClass();
            // Gives friendly message for user input.
            Console.WriteLine("Please enter a number, then press ENTER.");
            // This stores user input to a variable.
            int input = Convert.ToInt32(Console.ReadLine());
            // This variable holds the math operation
            int sum;
            // This calls on the input number and outputs the result
            math1.Divided(input, out sum);
            // This line prints a friendly message including the results.
            Console.WriteLine("Your number divided by 2 equals: " + sum);
            Console.ReadLine();
            // This variable is a list named newList
            List<int> newList = new List<int>() { 12, 40, 6, 28, 10 };
            math1.Output(newList, out int total);
            // This gives a friendly message with the total of items in the list.
            Console.WriteLine("There are " + total + " items in the list.");
            Console.ReadLine();
            // Gives friendly message for input.
            Console.WriteLine("Please enter a number, then press ENTER.");
            // This line stores user input to a variable.
            int input2 = Convert.ToInt32(Console.ReadLine());
            int sumB = math1.Overload(input2);
            Console.WriteLine("I just added 250 to your number. The total is: " + sumB);
            Console.ReadLine();
            // Gives friendly message for input.
            Console.WriteLine("Please enter a number, then press ENTER.");
            // This line stores user input to a variable.
            int input3 = Convert.ToInt32(Console.ReadLine());
            // This line calls the method and the arguments within.
            int sumC = math1.Overload(input2, input3);
            // This gives a friendly message with the sum of the math operation.
            Console.WriteLine("67 plus your 2 input numbers equal: " + sumC);
            Console.ReadLine();
            // This is the variable for the equation in the static class
            int item = 25;
            // This calls the Static class, lastAnswer method
            Static.lastAnswer(item);
            // This writes the response.
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
