using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_20_area_of_cicle_calculation_task_c_sharp
{
    class Circle
    {
        public double Radius
        {
            get; set;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius *Radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle RadiusCircle = new Circle(1.5);

            double Area = RadiusCircle.CalculateArea();

            Console.WriteLine($"The Radius: {RadiusCircle}");
            Console.WriteLine($"The Area: {Area}");
        }
    }
}
