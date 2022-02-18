using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // This takes the current date and time and stores it in the variable "currentDateTime"
            DateTime currentDateTime = DateTime.Now;

            // This prints the value of "currentDateTime" on the console.
            Console.WriteLine("Current Date and Time is: " + currentDateTime.ToString());

            // This asks the user to input a number.
            Console.WriteLine("Type a number between 1-24, then press ENTER.");

            // This converts the data to integer.
            int hours = Convert.ToInt32(Console.ReadLine());

            // This prints to the console the value of variable "currentDateTime" plus the number of hours entered by the user.
            Console.WriteLine("In " + hours + " hour(s), it will be " + currentDateTime.AddHours(hours).ToString());

            Console.ReadLine();
        }
    }
}
