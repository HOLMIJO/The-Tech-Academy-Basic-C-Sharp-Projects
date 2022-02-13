using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    public class Counting
    {
        public int AddIt(int number) //Passes in number variable from Main program which is the 
                                     //user input. 
        {
            int a = 25;
            return number + a; // Returning this value to the part of the program that called it. 
        }

        public int SubIt(int number) //Passes in number variable from Main program which is the 
                                     //user input. 
        {
            int b = 2;
            return number - b; // Returning this value to the part of the program that called it. 
        }

        public int TimesIt(int number) //Passes in number variable from Main program which is the 
                                       //user input. 
        {
            int c = 10;
            return number * c; // Returning this value to the part of the program that called it. 
        }
    }
}
