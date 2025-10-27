using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5_Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade: ");
            string grade = Console.ReadLine();
            int realGrade = Convert.ToInt32(grade);

            switch(realGrade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Excellent");
                    break;

            }
        }
    }
}
