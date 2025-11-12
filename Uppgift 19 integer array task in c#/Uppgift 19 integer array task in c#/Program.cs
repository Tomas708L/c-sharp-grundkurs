using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_19_integer_array_task_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, };

            int sum = SumOfNumbers(numbers);
            
            Console.WriteLine("Here is the sum off all numbers in the array: " + sum);

            Console.WriteLine($"This is the amount of numbers in the array: {numbers.Length}");

            if(sum > -1)
            {
                Console.WriteLine($"The total is: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }


        }
        static int SumOfNumbers(int[] numbers)
        {
            return numbers.Sum(x => x);
        }
    }
}
