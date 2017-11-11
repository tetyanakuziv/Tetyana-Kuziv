using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_begin17_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x1 = getUserValue("the A");
                int x2 = getUserValue("the B");
                int x3 = getUserValue("the C");

                int AC = Math.Abs(x3 - x1);
                int BC = Math.Abs(x3 - x2);
                int sum = AC + BC;
                Console.WriteLine("AC, BC, sum: {0}, {1}, {2}", AC, BC, sum);
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
