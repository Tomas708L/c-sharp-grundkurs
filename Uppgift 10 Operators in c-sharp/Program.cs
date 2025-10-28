using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_10_Operators_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;
            int num3 = 4;
            int num4 = 8;
            int num5 = 12;
            int num6 = 20;

            int sum = num1 + num2;
            int product = num3 * num4;
            int devision = num5 % num6;

            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(devision);


            Console.WriteLine("\n" + ++num6);
            Console.WriteLine(num6++);

            Console.WriteLine(--num6);
            Console.WriteLine(num6--);

            int operators = num5 += 5;
            Console.WriteLine("\n" + operators);

            int operators2 = num5 -= 5;
            Console.WriteLine(operators2);

            int operators3 = num5 *= 5;
            Console.WriteLine(operators3);

            int operators4 = num5 %= 5;
            Console.WriteLine(operators4);

            int operators5 = num5 /= 5;
            Console.WriteLine(operators5);

        }
    }
}
