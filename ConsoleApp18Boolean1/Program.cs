using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18Boolean1
{
    class Program
    {
        static void Main(string[] args)
        {//Boolean1. Дано целое число A. Проверить истинность высказывания: «Число A является положительным». 
            try
            {
                int a = Value("the value");
                Console.WriteLine(a > 0);
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
