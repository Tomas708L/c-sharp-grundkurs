using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_26_exception_handling_in_c_sharp
{
    internal class Program
    {
        class Calculator
        {

            //Here is the method that will divide 2 integers numbers
            public static double Divide(double a, double b)
            {
                if(b == 0)
                {
                    Console.WriteLine("Cannot devide with 0");
                    return 0.0;
                }
                return a / b;
            }

            
            //The method that converts string to int
            public static (int, int) ParseInput(string Input1, string Input2)
            {
                try
                {
                    int num1 = Convert.ToInt32(Input1);
                    int num2 = Convert.ToInt32(Input2);
                    return (num1,  num2);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Only use numbers");
                    return (-1, -1);
                }
            }


        }
        //The main method
        static void Main(string[] args)
        {
            //Ask the user for numbers
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter a second number: ");
            string num2 = Console.ReadLine();

            
            //Here i call for the methods
            var Conversion = Calculator.ParseInput(num1, num2);

            var result = Calculator.Divide(Conversion.Item1, Conversion.Item2);

            Console.WriteLine("The result of the division is: " + result);

            
        }
    }
}


            
            

            
        }
    }
}

