using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16integer29
{
    class Program
    {
        static void Main(string[] args)
        {//Integer29. Даны целые положительные числа A, B, C. На прямоугольнике размера A × B размещено максимально возможное количество квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника. 
            try
            {
                int a = getUserValue("the side a");
                int b = getUserValue("the side b");

                if (a == b)
                {
                    Console.WriteLine("This is not rectangle");
                    Console.ReadKey();
                    return;
                }

                if (a <= 0)
                {
                    Console.WriteLine("The side cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                if (b <= 0)
                {
                    Console.WriteLine("The side cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                int c = getUserValue("the side of the square");
                if (c <= 0 || c > a || c > b)
                {
                    Console.WriteLine("Please enter another value");
                    Console.ReadKey();
                    return;
                }
                int s = (a / c) * (b / c);
                Console.WriteLine("The number of squares is {0}", s);
                double m = s * (Math.Pow(c, 2));
                double sq = a * b - m;
                Console.WriteLine("The area of not occupied rectangle is {0}", sq);
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
