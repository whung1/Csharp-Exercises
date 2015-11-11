using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime curTime = DateTime.Now;
            Console.WriteLine("current time: " + curTime.ToLongTimeString());
            Console.WriteLine("current date: " + curTime.ToLongDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            DateTime myBirthday = DateTime.Parse("8/6/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("I am this many days old: " + myAge.TotalDays);

            Console.ReadLine(); // Polling
        }
    }
}
