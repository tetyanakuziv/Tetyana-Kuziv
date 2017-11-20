using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if8_29_
{
    class Program
    {
        static void Main(string[] args)
        {//If29. Дано целое число. Вывести его строку-описание вида «отрицательное четное число», «нулевое число», «положительное нечетное число» и т. д.  
            try
            {
                int a = Value("the integer value ");
                if (a > 0 && a % 2 == 0)
                {
                    Console.WriteLine("Even positive value");
                }
                if (a < 0 && (a % 2) != 0)
                {
                    Console.WriteLine("Odd negative value");
                }
                if (a < 0 && a % 2 == 0)
                {
                    Console.WriteLine("Even negative value");
                }
                if (a > 0 && (a % 2) != 0)
                {
                    Console.WriteLine("Odd positive value");
                }
                if (a == 0)
                {
                    Console.WriteLine("Zero value");
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
