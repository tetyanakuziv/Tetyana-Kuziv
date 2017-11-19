using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20Boolean3
{
    class Program
    {
        static void Main(string[] args)
        {//Boolean4. Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3». 
            try
            {
                int a = Value("the value a");
                int b = Value("the value b");
                Console.WriteLine(a > 2);
                Console.WriteLine(b <= 3);
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