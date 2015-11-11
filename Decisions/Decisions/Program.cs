using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing if statement, enter 1, 2, or 3");
            string userInput = Console.ReadLine();
            string msg; 
            if (userInput == "1")
            {
                msg = "You chose 1";
            }
            else if (userInput == "2")
            {
                msg = "You chose 2";
            }
            else if (userInput == "3")
            {
                msg = "You chose 3";
            }
            else
            {
                msg = "You did not choose a num";
            }

            Console.WriteLine(msg);
            
            Console.WriteLine("Testing inline if and WriteLine with args, enter 1 or aynthing else:");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered {0}", userInput);

            Console.ReadLine();
        }
    }
}
