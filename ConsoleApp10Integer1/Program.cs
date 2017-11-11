using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Integer1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int l = getUserValue("the L");
                if (l <= 0)
                {
                    Console.WriteLine("Please enter another number");
                    Console.ReadKey();
                }
                int lm = l / 100;
                Console.WriteLine("Result:{0}", lm);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static int getUserValue(string nameValue)
        {
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();
            return Int32.Parse(s);
        }
    }
}

