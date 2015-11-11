using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Showing break
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Found seven");
                    break;
                }
            }

            // Showing simple iteration output
            for (int j = 0; j < 12; j++)
            {
                Console.WriteLine("j: " + j);
            }

            Console.ReadLine(); //Polling
        }
    }
}
