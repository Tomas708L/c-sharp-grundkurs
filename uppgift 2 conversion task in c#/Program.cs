using System;

namespace uppgift_2_conversion_task_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intager as a string and the converting to intager
            string age = "16";
            long intage = Convert.ToInt32(age);
            Console.WriteLine(intage);

        }
    }
}
