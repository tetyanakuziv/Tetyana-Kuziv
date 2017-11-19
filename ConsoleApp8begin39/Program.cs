using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8begin39
{
    class Program
    {
        static void Main(string[] args)
        {//Begin40. Найти решение системы линейных уравнений вида A1·x + B1·y = C1, A2·x + B2·y = C2
            try
            {
                int a1 = getUserValue("the A1");
                int b1 = getUserValue("the B1");
                int c1 = getUserValue("the C1");
                int a2 = getUserValue("the A2");
                int b2 = getUserValue("the B2");
                int c2 = getUserValue("the C2");

                int d = a1 * b2 - a2 * b1;
                int x = (c1 * b2 - c2 * b1) / d;
                int y = (a1 * c2 - a2 * c1) / d;

                Console.WriteLine("Result:{0},{1)", x, y);
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


