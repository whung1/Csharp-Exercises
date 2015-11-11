using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                myReader.Close(); // close file
                Console.ReadLine(); // polling
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find file, Directory not found");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find file, File was not in directory");
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't find file, Unhandled Error");
            }
        }
    }
}
