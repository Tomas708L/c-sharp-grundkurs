using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_6_Loops_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value of how many times the loop should run: ");
            string num = Console.ReadLine();
            int numToInt = Convert.ToInt32(num);

            for(int i = 1; i <= numToInt; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The loop has finished");
        }
    }
}
