using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This asks the user to enter a number
            // then multiplies it and prints result to console
            Console.WriteLine("Enter a number from 1 to 100,000,000 and press Enter.");
            // **** uint firstNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Let's multiply " + firstNumber + " by 50!");
            Console.WriteLine(firstNumber + 50);
            Console.ReadLine();

            Console.WriteLine("Let's add 25 to that and see what we get!\nPress Enter to continue.");
            uint secondNumber = firstNumber + 75;
            Console.WriteLine(secondNumber);
            Console.ReadLine();







            Console.WriteLine("Hello World!");
        }
    }
}
