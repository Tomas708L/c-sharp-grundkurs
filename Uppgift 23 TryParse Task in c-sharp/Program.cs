using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_23_TryParse_Task_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if the catch don't run then you know it worked
            //This is not ideal becouse it slows the program down
            Console.Write("Enter a Number: ");
            if (TryParse(Console.ReadLine(), out int result))
                {
                Console.WriteLine("success" + result);

            }
            else
            {
                Console.WriteLine("Oh no something went wrong!");
            }

        }
        static bool TryParse(string input, out int result)
        {
            result = 0;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
