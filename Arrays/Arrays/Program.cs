using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Should output 4: " + numbers[0]);

            string[] names = new string[] { "John", "Bob", "Joe", "Melissa" };

            Console.WriteLine("Foreach output all names...");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string test = "This is a string that will be converted to an array and reversed";
            char[] charArr = test.ToCharArray();
            Array.Reverse(charArr);

            foreach (char curChar in charArr)
            {
                Console.Write(curChar);
            }

            Console.ReadLine(); // Polling
        }
    }
}
