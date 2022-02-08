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
        // Variable of integer type gets converted as user input is captured and stored.
        int indexOfArray = Convert.ToInt32(Console.ReadLine()); //This line saves the input result
        for (int i = 0; i <= strArray1.Length; i++) // As long as the index which is initially set to zero,
                                                    // is less than or equal to the length of the array, while incrementally looping through, 
        {   // then display the info stored in the associated index.
            if (indexOfArray == i) // If user input is equal to the index of zero then print the message listed below.
            {   // This message prints once the valid index is located.
                Console.WriteLine("You chose: " + strArray1[i]);
            }
            else
            {
                // If user inputs index that does not exist, this message will display.
                Console.WriteLine("ERROR: Index does not exist. Please try again.");
            }
            Console.ReadLine();

        }


        // Array of integer variable format, instantiated.
        int[] intArray1 = new int[] { 25, 33, 100 };
        // Message giving user instructions will be displayed.
        //Console.WriteLine("12+13=?? Enter \"0\" for the answer.\n25+8=?? Enter \"1\" for the answer.\n50+50=??? Enter \"2\" for the answer.");
        // Variable of integer type gets converted as user input is captured and stored.
        int indexOfArray1 = Convert.ToInt32(Console.ReadLine()); //This line saves the input result
        for (int i = 0; i <= intArray1.Length; i++) // As long as the index which is initially set to zero,
                                                    // is less than or equal to the length of the array, while incrementally looping through, 
        {   // then display the info stored in the associated index.
            if (indexOfArray1 == i) // If user input is equal to the index of zero then print the message listed below.
            {   // This message prints once the valid index is located.
                Console.WriteLine("The answer is: " + intArray1[i]);
            }
            else
            {
                // If user inputs index that does not exist, this message will display.
                Console.WriteLine("ERROR: Index does not exist. Please try again.");
            }
            Console.ReadLine();
        }
        // Message giving user instructions will be displayed.
        Console.WriteLine("Enter an index of \"0\" and view the message.");
        int intList1 = Convert.ToInt32(Console.ReadLine()); //This line saves the input result
        // This creates a list of strings and then instantiates the list.
        List<string> intList = new List<string>();
        intList.Add("Joseph Holmin"); // This adds to the empty list.
        intList.Add("The Tech Academy"); // This adds to the empty list
        intList.Add("Software Development Boot Camp"); // This adds to the empty list
        intList.Remove("Joseph Holmin"); // This removes an item from the list
        // This list holds 3 indexes.
        // Since Line 59 is removing index 0,
        // Only "The Tech Academy" will display as it becomes index 0.
        Console.WriteLine(intList[0]); //This prints index 0 in the list
        Console.ReadLine();
    }
}
