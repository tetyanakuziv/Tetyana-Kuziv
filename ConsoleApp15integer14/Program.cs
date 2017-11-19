using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15integer14
{
    class Program
    {
        static void Main(string[] args)
        {//Integer14. Дано трехзначное число. В нем зачеркнули первую справа цифру и приписали ее слева. Вывести полученное число. 
            try
            {
                int x = getUserValue("three-digit number");
                int r = (x % 10) * 100 + (x / 10);
                Console.WriteLine("Result:{0}", r);
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
