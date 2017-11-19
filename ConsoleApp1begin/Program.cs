using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1begin
{
    class Program
    {
        static void Main(string[] args)
        {//Begin1. Дана сторона квадрата a. Найти его периметр P = 4·a. 
            Console.WriteLine("Please enter the side a");
            string s = Console.ReadLine();
            try
            {
                int a = Int32.Parse(s);
                if (a <= 0)
                {
                    Console.WriteLine("Please enter another number");
                    Console.ReadKey();
                    return;
                }
                int p = 4 * a;
                Console.WriteLine("Result: {0}", p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
