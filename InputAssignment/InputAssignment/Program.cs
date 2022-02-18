using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This asks the user to input a number.
            Console.WriteLine("Please enter your favorite whole number!");
            // This line stores the user input.
            int input = Convert.ToInt32(Console.ReadLine());

            // This uses StreamWriter to append the values to the NumberLog file
            using (StreamWriter file = new StreamWriter(@"C:\Users\joeho\Logs\NumberLog.txt", true))
            {
                file.WriteLine(input);
            }

            // This sets a variable list to capture all the values from the file and print them to the console.
            string list = File.ReadAllText(@"C:\Users\joeho\Logs\NumberLog.txt");
            Console.WriteLine(list);
            Console.ReadLine();
        }
    }
}
