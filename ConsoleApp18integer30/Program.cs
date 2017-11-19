using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18integer30
{
    class Program
    {
        static void Main(string[] args)
        {//Integer30. Дан номер некоторого года (целое положительное число). Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год. 
            try
            {
                int y = Value("the year");
                if (y < 0)
                {
                    Console.WriteLine("Please enter another value");
                    Console.ReadKey();
                    return;
                }
                int c = ((y - 1) / 100 + 1);
                Console.WriteLine("The century of this year is {0}", c);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static int Value(string nameValue)
        {
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();
            return Int32.Parse(s);
        }
    }
}
