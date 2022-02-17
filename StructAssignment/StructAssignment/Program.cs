using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // From Number struct BitCoin is the instantiated object.
            Number BitCoin = new Number
            {
                Amount = 3250
            };
            // This line writes the BitCoint amount to console.
            Console.WriteLine(BitCoin.Amount);
        }
    }
}
