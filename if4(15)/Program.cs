using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if4_15_
{
    class Program
    {
        static void Main(string[] args)
        {//If15. Даны три числа. Найти сумму двух наибольших из них.
            try
            {
                int a = Value("the value a ");
                int b = Value("the value b");
                int c = Value("the value c");
                if (a > b && b > c)
                {
                    Console.WriteLine("The result is {0}", a + b);
                }
                if (a > b && c > b)
                {
                    Console.WriteLine("The result is {0}", a + c);
                }
                if (b > a && c > a)
                {
                    Console.WriteLine("The result is {0}", b + c);
                }
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
