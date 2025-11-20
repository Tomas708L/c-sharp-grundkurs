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
            //Here is the method that will divide the 2 numbers
            public static double Divide(int x, int y)
            {
                try
                {
                    
                    return (double)x / y;
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Can't divide with zero");
                    return 0.0;
                }

                
                
            }
            //Here is the method that will convert string numbers to int, 
            public static (int num1, int num2) ParseInput(string strnum1, string strnum2)
            {
                try
                {
                    
                    int InputNum1 = Convert.ToInt32(strnum1);
                    int InputNum2 = Convert.ToInt32(strnum2);

                    return (InputNum1, InputNum2);
                    

                }
                catch(FormatException)
                {
                    Console.WriteLine("The input was not a number!");
                    return (-1, -1);

                }
                

            }
        }
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter a second number: ");
            string num2 = Console.ReadLine();

            //Here i used the methods
            var Result = Calculator.ParseInput(num1, num2);

            double divide = Calculator.Divide(Result.num1, Result.num2);

            

            
            

            
        }
    }
}
