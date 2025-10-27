using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_8_Age_Verification_and_controll_flow_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string stringAge = Console.ReadLine();
            int Age = Convert.ToInt32(stringAge);

            int LegalAge = 18;

            int Counter = 1;



            if(Age >= LegalAge)
            {
                Console.WriteLine("You are an adult");
            }
            else if(Age < LegalAge)
            {
                Console.WriteLine("You are under the legal age");

            }

            while (Counter <= 5)
            {
                Console.WriteLine(Counter);
                Counter++;
            }
            Counter--;

            switch(Counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            var name = "John";

            Console.WriteLine("Hello " + name + ", the result of the switch is " + Counter + " and the result of the loop statement is 1 to 5");

        }
    }
}
