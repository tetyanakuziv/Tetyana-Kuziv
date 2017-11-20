using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if9_30_
{
    class Program
    {
        static void Main(string[] args)
        {//If30. Дано целое число, лежащее в диапазоне 1–999. Вывести его строку-описание вида «четное двузначное число», «нечетное трехзначное число» и т. д. 
            try
            {
                int a = Value("the integer value ");
                if (a > 0 && a % 2 == 0 && a<100 && a>9)
                {
                    Console.WriteLine("Even positive two-digit value");
                }
                if (a > 0 && a % 2 == 0 && a % 100 == 0)
                {
                    Console.WriteLine("Even positive three-digit value");
                }
                if (a > 0 && a % 2 == 0 && a < 10)
                {
                    Console.WriteLine("Even positive one-digit value");
                }
                if (a > 0 && (a % 2) != 0 && a<100 && a>9)
                {
                    Console.WriteLine("Odd positive two-digit value");
                }
                if (a > 0 && (a % 2) != 0 && a % 100 == 0)
                {
                    Console.WriteLine("Odd positive three-digit value");
                }
                if (a > 0 && (a % 2) != 0 && a < 10)
                {
                    Console.WriteLine("Odd positive one-digit value");
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
