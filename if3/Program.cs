using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if3
{
    class Program
    {
        static void Main(string[] args)
        {//If3. Дано целое число. Если оно является положительным, то прибавить к нему 1; если отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10. Вывести полученное число. 
            try
            {
                int a = Value("the integer value");
                if (a > 0)
                {
                    Console.WriteLine("{0}", a + 1);

                }
                else if (a < 0)
                {
                    Console.WriteLine("{0}", a - 2);

                }
                else if (a == 0)
                {
                    Console.WriteLine("{0}", 10);
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
