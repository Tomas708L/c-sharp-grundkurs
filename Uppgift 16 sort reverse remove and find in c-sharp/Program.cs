using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_16_sort_reverse_remove_and_find_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                45, 12, 78, 34, 89, 23
            };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Array.Sort(numbers);


            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Array.Reverse(numbers);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            List<int> NumberList = numbers.ToList();

            NumberList.Remove(78);

            foreach(var i in NumberList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int toSearch = NumberList.IndexOf(34);

            if(toSearch != -1)
            {
                Console.WriteLine($"the number can be found: {toSearch}");
            }
            else
            {
                Console.WriteLine($"Number can not be found: {toSearch}");
            }

        }
    }
}
