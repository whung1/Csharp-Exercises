using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = aHelperMethod();
            Console.WriteLine(msg);
            
            Console.WriteLine("Enter your name (testing overloading): ");
            string userInput = Console.ReadLine();
            Console.WriteLine(aHelperMethod(userInput));
            
            Console.ReadLine(); // Polling
        }

        private static string aHelperMethod()
        {
            return "This is string created via helper method";
        }

        private static string aHelperMethod(string inString)
        {
            return String.Format("Hello, {0}!", inString);
        }
    }
}
