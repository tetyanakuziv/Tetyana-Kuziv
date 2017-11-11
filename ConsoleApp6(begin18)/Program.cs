using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_begin18_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x1 = getUserValue("the A");
                int x2 = getUserValue("the C");
                int x3 = getUserValue("the B");
                if (x2 < x1 || x2 > x3)
                {
                    Console.WriteLine("C cannot be < A or be >B");
                    Console.ReadKey();
                }
                if (x1 >= x3)
                {
                    Console.WriteLine("A cannot be >= B");
                    Console.ReadKey();
                }
                int AC = Math.Abs(x2 - x1);
                int BC = Math.Abs(x3 - x2);
                int x = AC * BC;
                Console.WriteLine("Result:{0}", x);
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

