using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            string y = "5";

            int intConversion = x + int.Parse(y);
            string stringConversion = x.ToString() + y;

            Console.WriteLine("int conversion: " + intConversion);
            Console.WriteLine("string conversion: " + stringConversion);
            Console.ReadLine();
        }
    }
}
