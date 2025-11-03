using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11_message_printer_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message you want to say: ");
            string msg = Console.ReadLine();

            Console.WriteLine(msg);

            char[] chars = msg.ToCharArray();
            Array.Reverse(chars);


            string reverseMsg = new string(chars);
            Console.WriteLine(reverseMsg);

            Console.WriteLine();

            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine(msg[i]);
            }

            Console.WriteLine();

            for (int i = msg.Length - 1; i >= 0; i--)
            {
                
                Console.WriteLine(msg[i]);
            }






        }
    }
}
