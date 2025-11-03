using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Uppgift_12_Password_Checker_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string passwd = Console.ReadLine();

            Console.Write("Verify your password: ");
            string verifiedPasswd = Console.ReadLine();

            if(passwd != verifiedPasswd)
            {
                Console.WriteLine("Passwords do not match");
            }
            else
            {
                Console.WriteLine("Password match");
            }

                int passLen = passwd.Length;

            if(passwd == "")
            {
                Console.WriteLine("Please enter a password");

                if (passLen >= 6)
                {
                    Console.WriteLine("Password is too short");
                }
            }
           

            
           
            
            
        }
    }
}
