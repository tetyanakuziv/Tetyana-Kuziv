using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3begin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = getUserValue("the side a");
                int b = getUserValue("the side b");
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Please enter another number");
                    Console.ReadKey();
                }
                if (a == b)
                {
                    Console.WriteLine("a cannot = b");
                }
                int S = a * b;
                int P = 2 * (a + b);
                Console.WriteLine("Result: {0}, {1}", S, P);
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

