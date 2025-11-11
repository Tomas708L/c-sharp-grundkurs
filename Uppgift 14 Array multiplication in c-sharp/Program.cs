using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_14_Array_multiplication_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 6;
            int[] numbers = new int[length];

            for(int i = 1; i < length; i++)
            {
                numbers[i] = i * num;
            }
            for(int i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
