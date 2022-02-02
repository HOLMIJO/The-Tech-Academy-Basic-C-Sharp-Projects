using System;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Decimal hourlyRate1, hourlyRate2, hoursWorked1, hoursWorked2, weeklyPerson1, weeklyPerson2, salaryPerson1, salaryPerson2;
            String hourlyRatePerson1, hourlyRatePerson2, hoursWorkedPerson1, hoursWorkedPerson2;
            bool moreThan;
            int weeksInYear = 52;

            // This is the beginning of the program.
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter the rate of pay."); // User enters a rate of pay
            hourlyRatePerson1 = Console.ReadLine();
            hourlyRate1 = Convert.ToDecimal(hourlyRatePerson1); // User input converts to a decimal
            Console.ReadLine();
            Console.WriteLine("Please enter the number of hours worked per week."); // User enters number of hours worked weekly
            hoursWorkedPerson1 = Console.ReadLine();
            hoursWorked1 = Convert.ToDecimal(hoursWorkedPerson1); // User input converts to a decimal
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter the rate of pay."); // User enters a rate of pay
            hourlyRatePerson2 = Console.ReadLine();
            hourlyRate2 = Convert.ToDecimal(hourlyRatePerson2); // User input converts to a decimal
            Console.ReadLine();
            Console.WriteLine("Please enter the number of hours worked per week."); // User enters number of hours worked weekly
            hoursWorkedPerson2 = Console.ReadLine();
            hoursWorked2 = Convert.ToDecimal(hoursWorkedPerson2); // User input converts to a decimal
            Console.ReadLine();
            Console.WriteLine("Annual Salary Information for Person 1 is: ");
            weeklyPerson1 = hourlyRate1 * hoursWorked1;  // This determines weekly salary
            salaryPerson1 = weeklyPerson1 * weeksInYear; // This determines annual salary
            Console.WriteLine(salaryPerson1);
            Console.ReadLine();
            Console.WriteLine("Annual Salary Information for Person 2 is: ");
            weeklyPerson2 = hourlyRate2 * hoursWorked2;  // This determines weekly salary
            salaryPerson2 = weeklyPerson2 * weeksInYear; // This determines annual salary
            Console.WriteLine(salaryPerson2);
            Console.ReadLine();
            moreThan = salaryPerson1 >= salaryPerson2; // This determines if Person 1 makes more money than Person 2.
            Console.WriteLine("Does Person 1 make more money than Person 2?\nIf Person 1 DOES make more than Person 2, \nthe result will display as TRUE, otherwise it will display as FALSE.");
            Console.ReadLine();
            Console.WriteLine(moreThan); // The result is printed as a boolean statement
            Console.ReadLine();
        }
    }
}