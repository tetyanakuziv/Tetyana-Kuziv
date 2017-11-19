using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14integer13
{
    class Program
    {
        static void Main(string[] args)
        {//Integer13. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее справа. Вывести полученное число. 
            try
            {
                int x = getUserValue("thee-digit number");
                int y = (x % 100) * 10 + (x / 100);
                Console.WriteLine("Result:{0}", y);
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

