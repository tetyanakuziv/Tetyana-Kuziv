using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if5_16_
{
    class Program
    {
        static void Main(string[] args)
        {//If16. Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию, то удвоить их; в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных A, B, C. 
            try
            {
                int a = Value("the value a ");
                int b = Value("the value b");
                int c = Value("the value c");
                if (a > b && b > c)
                {
                    Console.WriteLine("{0},{1},{2}", 2 * a, 2 * b, 2 * c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", -a, -b, -c);
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
