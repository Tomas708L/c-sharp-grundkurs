using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_9_boolean_task_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            int num3 = 8;
            int num4 = 4;

            bool isTrue = true;

            bool result1 = isTrue && (num1 > num3) && (num2 < num4);
            bool result2 = isTrue || (num1 < num3) || (num2 > num4);
            bool resultNot = !isTrue;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(resultNot + "\n");

            bool num1GreaterThanNum3 = num2 > num3;

            bool num2GreaterThanNum4 = num2 < num4;

            bool num1EqualNum3 = num1 == num3;

            Console.WriteLine(num1GreaterThanNum3);
            Console.WriteLine(num2GreaterThanNum4);
            Console.WriteLine(num1EqualNum3 + "\n");

            bool expression1 = isTrue && (num1 > num3 && num2 < num4);
            bool expression2 = isTrue || (num1 < num3 || (num2 > num4));

            Console.WriteLine(expression1);
            Console.WriteLine(expression2);

        }
    }
}
