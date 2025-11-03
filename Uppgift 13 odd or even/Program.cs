using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_13_odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);

            int Divide = number % 2;

            if(Divide == 0)
            {
                Console.WriteLine($"number {number} is even");
            }
            else if(Divide != 0)
            {
                Console.WriteLine($"Number {number} is odd");
            }

        }
    }
}
