using System;

namespace TTAStudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program is for The Tech Academy
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // This begins the daily report questions
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Welcome " + studentName);
            Console.ReadLine();

            // This asks which program the student is enrolled in
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You're enrolled in " + courseName);
            Console.ReadLine();

            // This asks what page the student is on
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You're working on page number " + pageNumber);
            Console.ReadLine();

            // This asks if the student needs help
            Console.WriteLine("Do you need help with anything?\nPlease answer \"true\" or \"false\".");
            Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("If you need help, please contact the instructors via email or telephone!");
            Console.ReadLine();

            // This asks about the student's experience
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string studentExperience = Console.ReadLine();
            Console.WriteLine("Thank you " + studentName + "!");
            Console.WriteLine("You wrote " + studentExperience);
            Console.ReadLine();

            // This asks for the student's feedback
            Console.WriteLine("Is there any other feedback you;d like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();
            Console.WriteLine("Thank you " + studentName + "!");
            Console.WriteLine("You wrote " + studentFeedback);
            Console.ReadLine();

            // This asks how many hours of study for the day
            Console.WriteLine("How many hours did you study today?");
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("Great job on your studies!");
            Console.ReadLine();

            // This thanks the student for their answers.
            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine();

            // This is the end of the program
            Console.Clear();
        }
    }
}
