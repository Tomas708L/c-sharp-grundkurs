using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_27_Functions_Methods
{
    internal class Program
    {
        class MathOperations
        {
            //The math methods
            public static int Addition(int a, int b)
            {
                return a + b;
            }

            public static int Subtraction(int a, int b)
            {
                return a - b;
            }

            public static int Multiplication(int a, int b)
            {
                return a * b;
            }

            public static double Divide(int a, int b)
            {
                if(b == 0)
                {
    
                    return 0;
                }
                return a / b;
            }
            public static double Power(int a, int b)
            {
                double result = Math.Pow(a, b);
                return result;
            }
        }
        static void Main(string[] args)
        {
            //Asks for 2 numbers
            Console.Write("Enter the first number: ");
            string strNum1 = Console.ReadLine();


            Console.Write("Enter the second number: ");
            string strNum2 = Console.ReadLine();


            int num1 = Convert.ToInt32(strNum1);
            int num2 = Convert.ToInt32(strNum2);

            //Using the math methods
            var add = MathOperations.Addition(num1, num2);
            var sub = MathOperations.Subtraction(num1, num2);
            var mult = MathOperations.Multiplication(num1, num2);
            var div = MathOperations.Divide(num1, num2);
            var pow = MathOperations.Power(num1, num2);

            //Writing the results
            Console.WriteLine("Results:");
            Console.WriteLine($"Addition: {num1} + {num2} = {add}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {sub}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {mult}");
            Console.WriteLine($"Division: {num1} / {num2} = {div}");
            if(num2 == 0)
            {
                Console.WriteLine("You can't divide with 0");
            }
            Console.WriteLine($"Power: {num1} ^ {num2} = {pow}");
        }
    }
}
