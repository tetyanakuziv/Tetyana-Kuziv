using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_begin16_
{
    class Program
    {
        static void Main(string[] args)
        {//Begin16. Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2 − x1|.
            try
            {
                int x1 = getUserValue("the x1");
                int x2 = getUserValue("the x2");
                if (x2 <= x1)
                {
                    Console.WriteLine("x2 cannot be <= x1");
                    Console.ReadKey();
                    return;
                }
                int l = Math.Abs(x2 - x1);
                Console.WriteLine("Result: {0}", l);
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

