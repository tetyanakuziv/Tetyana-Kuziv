using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13integer12
{
    class Program
    {
        static void Main(string[] args)
        {//Integer12. Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево. 
            try
            {
                int x = getUserValue("thee-digit number");
                Console.WriteLine(x.ToString().Reverse().ToArray());
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

