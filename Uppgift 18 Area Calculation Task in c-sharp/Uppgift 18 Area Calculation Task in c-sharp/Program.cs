using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_18_Area_Calculation_Task_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            string HeightInString = Console.ReadLine();
            int Height = Convert.ToInt32(HeightInString);

            Console.Write("Enter widgth: ");
            string WidgthInString = Console.ReadLine();
            int Widgth = Convert.ToInt32(WidgthInString);

            int result = Calc(Widgth, Height);

            Console.WriteLine($"Here is the area of a triangle: {result}");

        }

        static int Calc(int Widgth, int Height)
        {
            return (Widgth * Height) / 2;
        }

    }
}
