using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If2
{
    class Program
    {
        static void Main(string[] args)
        {//If2. Дано целое число. Если оно является положительным, то прибавить к нему 1; в противном случае вычесть из него 2. Вывести полученное число. 
            try
            {
                int a = Value("the integer value");
                if (a > 0)
                {
                    Console.WriteLine("{0}", a + 1);

                }
                else
                {
                    Console.WriteLine("{0}", a-2);
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
