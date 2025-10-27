using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_4_if_statement_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 16;

            if(age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else if(age < 18)
            {
                Console.WriteLine("You are not eligible to vote");

            }
        }
    }
}
