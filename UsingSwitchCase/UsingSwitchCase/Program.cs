using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pick a superhero");
            string userValue = Console.ReadLine();
            string msg = "";

            SuperHero myHero;

            if (Enum.TryParse<SuperHero>(userValue, true, out myHero))
            {
                switch (myHero)
                {
                    case SuperHero.Batman:
                        msg = "Enum says it's batman";
                        break;
                    case SuperHero.Spiderman:
                        msg = "Enum says it's spiderman";
                        break;
                    case SuperHero.Superman:
                        msg = "Enum says it's superman";
                        break;
                    default:
                        break;
                }
            } else {
                msg = "Enum failed";
            }

            Console.WriteLine(msg);
            Console.ReadLine();

        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        Spiderman
    }
}
