using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean6_20_
{
    class Program
    {
        static void Main(string[] args)
        {//Boolean20. Дано трехзначное число. Проверить истинность высказывания: «Все цифры данного числа различны». 
            try
            {
                int a = Value("the value a");
                int b = Value("the value b");
                int c = Value("the value c");
                if (a == b || b == c || c == a)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
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
