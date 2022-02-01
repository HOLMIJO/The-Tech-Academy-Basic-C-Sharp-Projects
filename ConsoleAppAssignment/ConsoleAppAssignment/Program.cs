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
            uint firstNumber, secondNumber;
            Console.WriteLine("Enter a number from 1 to 10,000,000 and press Enter.");
            uint firstNumber = (uint)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Let's multiply " + firstNumber + " by 50!");
            Console.WriteLine(firstNumber * 50);
            Console.ReadLine();

            Console.WriteLine("Let's add 25 to that and see what we get!\nPress Enter to continue.");
            secondNumber = firstNumber + 25;
            Console.WriteLine(secondNumber);
            Console.ReadLine();

            Console.WriteLine("Let's enter a new number with a decimal, and divide it by 12.5!\nPress Enter to continue.");
            decimal thirdNumber = Console.ReadLine();
            decimal result1 = thirdNumber / 12.5m;
            Console.WriteLine(result1);
            Console.ReadLine();






            // Console.WriteLine("Hello World!");
        }

        private static void WriteLine(string v)
        {
            throw new NotImplementedException();
        }
    }
}
