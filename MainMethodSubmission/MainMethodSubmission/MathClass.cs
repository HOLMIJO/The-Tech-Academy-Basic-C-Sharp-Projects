using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class MathClass  // Created MathClass for these math operations.
    {
        // This method will take a user input as an integer and returns an integer back.
        public int AddMeUp(int a)  
        {
            // This takes the user input "a" and adds to it...
            int inputA = a + 250;
            //returned "inputA" value to main program.
            return inputA;  
        }

        // This method has the same name as the one above. However this method is 
        // slightly different as this one now takes in a decimal and returns a decimal.
        public int AddMeUp(decimal b)  
        {
            // This takes the user input "b" and adds to it...
            decimal inputB = b - 12.50m;
            //returned "inputB" value to main program.
            return Convert.ToInt32(inputB);
        }

        // This creates a new method taking user input as a string, converts to an integer
        // before carrying out a math operation.
        public int AddMeUp(string c)
        {
            // This converts user input of string into an integer, assigns as "inputC".
            int inputC = Convert.ToInt32(c);
            // Takes "inputC" multiplys by 24, and stores value, passing it back to the main program.
            int inputD = inputC * 24; 
            return inputD; 
        }
    }
}
