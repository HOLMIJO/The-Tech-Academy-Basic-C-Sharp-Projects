using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(8);
            intList.Add(10);
            intList.Add(4);
            intList.Add(12);
            intList.Add(7);
            intList.Add(2);

            Console.WriteLine("Pick a number.This number will be used to divide each number in the list.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
            Console.WriteLine("{0} / {1} = {2}", intList, userInput, intList / userInput);
            Console.ReadLine();
        }
    }
}
