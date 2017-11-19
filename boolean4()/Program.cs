using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean4__
{
    class Program
    {
        static void Main(string[] args)
        {//Boolean18.Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих». 
            try
            {
                int a = Value("the value a");
                int b = Value("the value b");
                int c = Value("the value c");
                if (a == c || a == b || b == c)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
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
