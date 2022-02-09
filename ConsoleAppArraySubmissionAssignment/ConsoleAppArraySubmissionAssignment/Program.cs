using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Array of string variable format, instantiated.
        string[] strArray1 = new string[] { "Joseph Holmin", "The Tech Academy", "Software Development Bootcamp" };
        // Message giving user instructions will be displayed.
        Console.WriteLine("Enter \"0\" to display the Student's Name.\nEnter \"1\" to display the school name.\nEnter \"2\" to display current course.");
        int strList1 = Convert.ToInt32(Console.ReadLine()); //This line saves the input result
        // Switch case will display a preselected message and value of index chosen.
        switch (strList1)
        {
            case 0:
                Console.WriteLine("The answer is: " + strArray1[strList1]);
                break;

            case 1:
                Console.WriteLine("The answer is: " + strArray1[strList1]);
                break;

            case 2:
                Console.WriteLine("The answer is: " + strArray1[strList1]);
                break;

            default:
                Console.WriteLine("Index is not available.");
                break;
        }
        Console.ReadLine();


        // Array of integer variable format, instantiated.
        int[] intArray1 = new int[] { 25, 33, 100 };
        // Message giving user instructions will be displayed.
        Console.WriteLine("12+13=?? Enter \"0\" for the answer.\n25+8=?? Enter \"1\" for the answer.\n50+50=??? Enter \"2\" for the answer.");
        int indexOfArray1 = int.Parse(Console.ReadLine()); //This line saves the input result
        // Variable of integer type gets converted as user input is captured and stored.
        //Loop that prints items in array
        foreach (int i in intArray1)
        //{
        //    Console.WriteLine(i);
        //}
        if (indexOfArray1 > 2) // If user input is greater than 2
        { // then the message of index is not available will display
            Console.WriteLine("Index is not available.");
            Environment.Exit(0); // This allows the program to break free
        }
        else
        { // Otherwise the message below displays with the record based on user input
            Console.WriteLine("The answer is: " + intArray1[indexOfArray1]);
        }
        Console.ReadLine();


       


        // This creates a list of strings and then instantiates the list.
        List<string> intList = new List<string>();
        intList.Add("Joseph Holmin"); // This adds to the empty list.
        intList.Add("The Tech Academy"); // This adds to the empty list
        intList.Add("Software Development Boot Camp"); // This adds to the empty list
        intList.Add("HTTPS://LEARNCODINGANYWHERE.COM"); // This adds to the empty list.
        intList.Remove("Joseph Holmin"); // This removes an item from the list
        // Message giving user instructions will be displayed.
        Console.WriteLine("Enter an index of \"0\", \"1\", or \"2\" and view the message.");
        int intList1 = Convert.ToInt32(Console.ReadLine()); //This line saves the input result

        switch (intList1)
        {
            case  0: // If user input is 0, the value of index 0 is displayed
                Console.WriteLine("You chose: " + intList[intList1]);
                break;

            case 1: //If user input is 0, the value of index 0 is displayed
                Console.WriteLine("You chose: " + intList[intList1]);
                break;

            case 2: // If user input is 0, the value of index 0 is displayed
                Console.WriteLine("You chose: " + intList[intList1]);
                break;

            default: // If user input is an index not found, this message is displayed
                Console.WriteLine("Index is not available.");
                break;
        }
        Console.ReadLine();
    }
}
